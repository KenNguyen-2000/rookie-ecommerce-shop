import { ContentSidebarLayout } from '@/components/layouts';
import { Button } from '@/components/ui/button';
import {
	Card,
	CardContent,
	CardDescription,
	CardFooter,
	CardHeader,
	CardTitle,
} from '@/components/ui/card';
import {
	DropdownMenu,
	DropdownMenuCheckboxItem,
	DropdownMenuContent,
	DropdownMenuLabel,
	DropdownMenuSeparator,
	DropdownMenuTrigger,
} from '@/components/ui/dropdown-menu';
import { Table, TableBody, TableHead, TableHeader, TableRow } from '@/components/ui/table';
import { Tabs, TabsContent } from '@/components/ui/tabs';
import categoriesService from '@/services/categories/categories.service';
import { useQuery, useQueryClient } from '@tanstack/react-query';
import { File, ListFilter, PlusCircle } from 'lucide-react';
import CategoryCard from './components/CategoryCard';
import CreateCategoryDialog from './components/CreateCategoryDialog';
import { useState } from 'react';
import { CategoryDto, CreateCategoryDto } from '@/services/categories/categories.type';
import { AlertPopup } from '@/components/page';

const CategoriesPage = () => {
	const queryClient = useQueryClient();

	const [showDialog, setShowDialog] = useState(false);
	const [showAlert, setShowAlert] = useState(false);
	const [selectedCategory, setSelectedCategory] = useState<CategoryDto | null>();
	const { data: categories } = useQuery({
		queryKey: ['categories'],
		queryFn: () => categoriesService.getCategoriesAsync(),
		select(data) {
			return data.filter((category) => !category.parentId);
		},
	});

	const handleToggleDialog = () => {
		if (showDialog) setSelectedCategory(null);
		setShowDialog(!showDialog);
	};

	const handleSelectCategory = (category: CategoryDto, action: 'edit' | 'delete') => {
		setSelectedCategory(category);
		if (action === 'edit') {
			setShowDialog(true);
		} else {
			setShowAlert(true);
		}
	};

	const handleConfirm = async (data: CreateCategoryDto) => {
		if (selectedCategory) {
			await handleUpdateCategory(data);
		} else await handleCreateCategory(data);
		await queryClient.invalidateQueries({ queryKey: ['categories'] });
		handleToggleDialog();
	};

	const handleCreateCategory = async (data: CreateCategoryDto) => {
		await categoriesService.createCategoryAsync(data);
	};

	const handleUpdateCategory = async (data: CreateCategoryDto) => {
		await categoriesService.updateCategoryAsync({
			...data,
			id: selectedCategory!.id,
		});
	};

	const handleDeleteCategory = async () => {
		await categoriesService.deleteCategoryAsync(selectedCategory!.id);
		setShowAlert(false);
		setSelectedCategory(null);
		await queryClient.invalidateQueries({ queryKey: ['categories'] });
	};

	return (
		<ContentSidebarLayout>
			<AlertPopup
				open={showAlert}
				closeModal={() => {
					setShowAlert(false);
					setSelectedCategory(null);
				}}
				confirmAction={handleDeleteCategory}
			/>
			{categories && (
				<CreateCategoryDialog
					open={showDialog}
					closeDialog={() => setShowDialog(false)}
					categories={categories}
					onConfirm={handleConfirm}
					defaultValues={
						selectedCategory != null
							? {
									name: selectedCategory.name,
									description: selectedCategory.description,
									parentId: selectedCategory.parentId,
								}
							: {
									name: '',
									description: '',
								}
					}
				/>
			)}
			<main className="grid flex-1 items-start gap-4 p-4 sm:px-6 sm:py-0 md:gap-8">
				<Tabs defaultValue="all">
					<div className="flex items-center">
						{/* <TabsList>
							<TabsTrigger value="all">All</TabsTrigger>
							<TabsTrigger value="active">Active</TabsTrigger>
							<TabsTrigger value="draft">Draft</TabsTrigger>
							<TabsTrigger value="archived" className="hidden sm:flex">
								Archived
							</TabsTrigger>
						</TabsList> */}
						<div className="ml-auto flex items-center gap-2">
							<DropdownMenu>
								<DropdownMenuTrigger asChild>
									<Button variant="outline" size="sm" className="h-8 gap-1">
										<ListFilter className="h-3.5 w-3.5" />
										<span className="sr-only sm:not-sr-only sm:whitespace-nowrap">
											Filter
										</span>
									</Button>
								</DropdownMenuTrigger>
								<DropdownMenuContent align="end">
									<DropdownMenuLabel>Filter by</DropdownMenuLabel>
									<DropdownMenuSeparator />
									<DropdownMenuCheckboxItem checked>
										Active
									</DropdownMenuCheckboxItem>
									<DropdownMenuCheckboxItem>Draft</DropdownMenuCheckboxItem>
									<DropdownMenuCheckboxItem>Archived</DropdownMenuCheckboxItem>
								</DropdownMenuContent>
							</DropdownMenu>
							<Button size="sm" variant="outline" className="h-8 gap-1">
								<File className="h-3.5 w-3.5" />
								<span className="sr-only sm:not-sr-only sm:whitespace-nowrap">
									Export
								</span>
							</Button>
							<Button size="sm" className="h-8 gap-1" onClick={handleToggleDialog}>
								<PlusCircle className="h-3.5 w-3.5" />
								<span className="sr-only sm:not-sr-only sm:whitespace-nowrap">
									Add Category
								</span>
							</Button>
						</div>
					</div>
					<TabsContent value="all">
						<Card x-chunk="dashboard-06-chunk-0">
							<CardHeader>
								<CardTitle>Categories</CardTitle>
								<CardDescription>
									Manage your products and view their sales performance.
								</CardDescription>
							</CardHeader>
							<CardContent>
								<Table>
									<TableHeader>
										<TableRow>
											<TableHead>Name</TableHead>
											<TableHead>Description</TableHead>

											<TableHead className="hidden md:table-cell">
												Created at
											</TableHead>
											<TableHead className="hidden md:table-cell">
												Updated at
											</TableHead>
											<TableHead>
												<span className="sr-only">Actions</span>
											</TableHead>
										</TableRow>
									</TableHeader>
									<TableBody>
										{categories?.map((category) => (
											<CategoryCard
												key={category.id}
												category={category}
												onSelected={handleSelectCategory}
											/>
										))}
									</TableBody>
								</Table>
							</CardContent>
							<CardFooter>
								<div className="text-xs text-muted-foreground">
									Showing <strong>1-10</strong> of <strong>32</strong> products
								</div>
							</CardFooter>
						</Card>
					</TabsContent>
				</Tabs>
			</main>
		</ContentSidebarLayout>
	);
};

export default CategoriesPage;
