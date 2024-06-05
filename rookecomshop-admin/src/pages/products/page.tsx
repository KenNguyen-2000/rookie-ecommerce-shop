import { File, ListFilter, PlusCircle } from 'lucide-react';

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
import {
	Table,
	TableBody,
	TableHead,
	TableHeader,
	TableRow,
} from '@/components/ui/table';
import { Tabs, TabsContent, TabsList, TabsTrigger } from '@/components/ui/tabs';
import {  useState } from 'react';
import { useAppDispatch } from '@/redux/reduxHooks';
import { useNavigate } from 'react-router-dom';
import { deleteProductAsync } from '@/redux/thunks/products.thunk';
import { ContentSidebarLayout } from '@/components/layouts';
import { AlertPopup } from '@/components/page';
import {  useQueryClient } from '@tanstack/react-query';
import { ProductDto } from '@/services/products/products.type';
import ProductRow from './components/ProductRow';
import ReusePagination from '@/components/page/ReusePagination';
import { ScrollArea } from '@/components/ui/scroll-area';
import { CaretSortIcon } from '@radix-ui/react-icons';
import useQueryProducts, { useFetchProducts } from './useQueryProducts';
import  { useFetchListCategory } from '../categories/useCategories';
import { toast } from 'react-toastify';
import ProductsSkeleton from './components/ProductsSkeleton';

const ProductPage = () => {
	const navigate = useNavigate();
	const dispatch = useAppDispatch();
	const queryClient = useQueryClient();
	const  { queryDto, handleCategoryQuery, handlePaginate, handleSortQuery} = useQueryProducts();

	const [isOpen, setIsOpen] = useState(false);
	const [productId, setProductId] = useState<string | null>(null);
	const { data: products, isLoading } = useFetchProducts(queryDto);
	const { data: categories } = useFetchListCategory();
	
	const handleDeleteProduct = async () => {
		if (productId) {
			//Delete product
			await dispatch(deleteProductAsync(productId));
			queryClient.invalidateQueries({ queryKey: ['products', queryDto] });
			toast.success('Product has been deleted successfully');
		}
		setIsOpen(false);
	};

	const onSelectProductToDelete = (productId: string) => {
		setIsOpen(true);
		setProductId(productId);
	};


	return (
		<ContentSidebarLayout>
			<AlertPopup
				open={isOpen}
				closeModal={() => setIsOpen(false)}
				confirmAction={handleDeleteProduct}
			/>
			<Tabs defaultValue="all">
				<div className="flex items-center">
					<TabsList>
						<TabsTrigger value="all">All</TabsTrigger>
						<TabsTrigger value="active">Active</TabsTrigger>
						<TabsTrigger value="draft">Draft</TabsTrigger>
						<TabsTrigger value="archived" className="hidden sm:flex">
							Archived
						</TabsTrigger>
					</TabsList>
					<div className="ml-auto flex items-center gap-2">
						<DropdownMenu>
							<DropdownMenuTrigger asChild>
								<Button variant="outline" size="sm" className="h-8 gap-1">
									<ListFilter className="h-3.5 w-3.5" />
									<span className="sr-only sm:not-sr-only sm:whitespace-nowrap">
										Categories
									</span>
								</Button>
							</DropdownMenuTrigger>
							<DropdownMenuContent align="end">
								<DropdownMenuLabel>Filter by</DropdownMenuLabel>
								<DropdownMenuSeparator />
								<ScrollArea className="max-h-64 h-64">
									<DropdownMenuCheckboxItem
										checked={queryDto.categoryName === ''}
										onClick={() => handleCategoryQuery('')}
									>
										All
									</DropdownMenuCheckboxItem>
									{categories?.map((category) => (
										<DropdownMenuCheckboxItem
											checked={queryDto.categoryName === category.name}
											onClick={() => handleCategoryQuery(category.name)}
											key={category.id}
										>
											{category.name}
										</DropdownMenuCheckboxItem>
									))}
								</ScrollArea>
							</DropdownMenuContent>
						</DropdownMenu>
						<Button size="sm" variant="outline" className="h-8 gap-1">
							<File className="h-3.5 w-3.5" />
							<span className="sr-only sm:not-sr-only sm:whitespace-nowrap">
								Export
							</span>
						</Button>
						<Button
							size="sm"
							className="h-8 gap-1"
							onClick={() => navigate('/products/create')}
						>
							<PlusCircle className="h-3.5 w-3.5" />
							<span className="sr-only sm:not-sr-only sm:whitespace-nowrap">
								Add Product
							</span>
						</Button>
					</div>
				</div>
				<TabsContent value="all">
					<Card x-chunk="dashboard-06-chunk-0">
						<CardHeader>
							<CardTitle>Products</CardTitle>
							<CardDescription>
								Manage your products and view their sales performance.
							</CardDescription>
						</CardHeader>
						<CardContent>
							<Table>
								<TableHeader>
									<TableRow>
										<TableHead className="hidden w-[100px] sm:table-cell">
											<span className="sr-only">img</span>
										</TableHead>
										<TableHead>
											<div className="flex gap-3">
												Name
												<button
													type="button"
													onClick={handleSortQuery.bind(null, 'name')}
												>
													<CaretSortIcon />
												</button>
											</div>
										</TableHead>
										<TableHead>Status</TableHead>
										<TableHead className="hidden md:table-cell">
											<div className="flex gap-3">
												Price
												<button
													type="button"
													onClick={handleSortQuery.bind(null, 'price')}
												>
													<CaretSortIcon />
												</button>
											</div>
										</TableHead>
										<TableHead className="hidden md:table-cell">
											<div className="flex gap-3">
												Stock
												<button
													type="button"
													onClick={handleSortQuery.bind(
														null,
														'stockQuantity',
													)}
												>
													<CaretSortIcon />
												</button>
											</div>
										</TableHead>
										<TableHead className="hidden md:table-cell">
											Category
										</TableHead>
										<TableHead className="hidden md:table-cell">
											<div className="flex gap-3">
												Created date
												<button
													type="button"
													onClick={handleSortQuery.bind(
														null,
														'createdAt',
													)}
												>
													<CaretSortIcon />
												</button>
											</div>
										</TableHead>
										<TableHead>
											<span className="sr-only">Actions</span>
										</TableHead>
									</TableRow>
								</TableHeader>
								<TableBody>
									{!isLoading ? (
										products?.items?.map((product: any) => (
											<ProductRow
												key={product.id}
												product={product}
												onSelectProductToDelete={onSelectProductToDelete}
											/>
										))
									) : (
										<ProductsSkeleton count={5} />
									)}
								</TableBody>
							</Table>
						</CardContent>
						<CardFooter>
							<div className="w-full flex items-center">
								<div className="text-xs text-muted-foreground">
									Showing <strong>1-10</strong> of <strong>32</strong> products
								</div>
								<div className="ml-auto">
									{products && (
										<ReusePagination<ProductDto>
											data={products}
											queryDto={queryDto}
											handleChangePage={handlePaginate}
										/>
									)}
								</div>
							</div>
						</CardFooter>
					</Card>
				</TabsContent>
			</Tabs>
		</ContentSidebarLayout>
	);
};
export default ProductPage;


