/* eslint-disable @typescript-eslint/no-explicit-any */
import { File, ListFilter, MoreHorizontal, PlusCircle } from 'lucide-react';

import { Badge } from '@/components/ui/badge';
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
	DropdownMenuItem,
	DropdownMenuLabel,
	DropdownMenuSeparator,
	DropdownMenuTrigger,
} from '@/components/ui/dropdown-menu';
import {
	Table,
	TableBody,
	TableCell,
	TableHead,
	TableHeader,
	TableRow,
} from '@/components/ui/table';
import { Tabs, TabsContent, TabsList, TabsTrigger } from '@/components/ui/tabs';
import moment from 'moment';
import { useEffect, useMemo, useState } from 'react';
import { useAppDispatch } from '@/redux/reduxHooks';
import { useNavigate, useSearchParams } from 'react-router-dom';
import { deleteProductAsync } from '@/redux/thunks/products.thunk';
import { ContentSidebarLayout } from '@/components/layouts';
import {
	Pagination,
	PaginationContent,
	PaginationEllipsis,
	PaginationItem,
	PaginationLink,
	PaginationNext,
	PaginationPrevious,
} from '@/components/ui/pagination';
import { AlertPopup } from '@/components/page';
import { QueryDto } from '@/types/query-dto';
import { useQuery, useQueryClient } from '@tanstack/react-query';
import productsService from '@/services/products/products.service';
import { Skeleton } from '@/components/ui/skeleton';
import { toast } from '@/components/ui/use-toast';
import { PagniatedList } from '@/types/pagniated-list.type';
import { ProductDto } from '@/services/products/products.type';
import ProductRow from './components/ProductRow';
import ReusePagination from '@/components/page/ReusePagination';

const ProductPage = () => {
	const navigate = useNavigate();
	const dispatch = useAppDispatch();
	const queryClient = useQueryClient();

	const [searchParams, setSearchParams] = useSearchParams();
	const [isOpen, setIsOpen] = useState(false);
	const [productId, setProductId] = useState<string | null>(null);
	const [queryDto, setQueryDto] = useState<QueryDto>({
		page: parseInt(searchParams.get('page') ?? '1'),
		pageSize: parseInt(searchParams.get('pageSize') ?? '5'),
		searchTerm: searchParams.get('searchTerm') ?? '',
		sortOrder: searchParams.get('sortOrder') ?? 'asc',
	});
	const { data: products, isLoading } = useQuery({
		queryKey: ['products', queryDto],
		queryFn: () => productsService.getProductsAsync(queryDto),
	});

	const handleDeleteProduct = async () => {
		if (productId) {
			//Delete product
			console.log('Delete product');
			await dispatch(deleteProductAsync(productId));
			queryClient.invalidateQueries({ queryKey: ['products', queryDto] });
			toast({
				title: 'Product Deleted',
				description: 'Product has been deleted successfully',
			});
		}
		setIsOpen(false);
	};

	const onSelectProductToDelete = (productId: string) => {
		setIsOpen(true);
		setProductId(productId);
	};

	const handleAddParams = (page: number, pageSize?: number) => {
		setQueryDto({ ...queryDto, page, pageSize: pageSize ?? queryDto.pageSize });
	};

	// useEffect(() => {
	// 	const page = searchParams.get('page') ?? '1';
	// 	const pageSize = searchParams.get('pageSize') ?? '5';
	// 	if (page && pageSize) {
	// 		setQueryDto({ page: parseInt(page), pageSize: parseInt(pageSize) });
	// 	}
	// }, [searchParams]);

	useEffect(() => {
		function updateQueryParams(queryDto: QueryDto) {
			const newParams = new URLSearchParams(searchParams);
			newParams.set('page', queryDto.page.toString());
			newParams.set('pageSize', queryDto.pageSize.toString());
			setSearchParams(newParams);
		}

		updateQueryParams(queryDto);
	}, [queryDto]);

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
										Filter
									</span>
								</Button>
							</DropdownMenuTrigger>
							<DropdownMenuContent align="end">
								<DropdownMenuLabel>Filter by</DropdownMenuLabel>
								<DropdownMenuSeparator />
								<DropdownMenuCheckboxItem checked>Active</DropdownMenuCheckboxItem>
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
										<TableHead>Name</TableHead>
										<TableHead>Status</TableHead>
										<TableHead className="hidden md:table-cell">
											Price
										</TableHead>
										<TableHead className="hidden md:table-cell">
											Stock
										</TableHead>
										<TableHead className="hidden md:table-cell">
											Category
										</TableHead>
										<TableHead className="hidden md:table-cell">
											Created at
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

									<TableRow>
										<TableCell className="hidden sm:table-cell">
											<img
												alt="Product image"
												className="aspect-square rounded-md object-cover"
												height="64"
												src="/placeholder.svg"
												width="64"
											/>
										</TableCell>
										<TableCell className="font-medium">
											TechTonic Energy Drink
										</TableCell>
										<TableCell>
											<Badge variant="secondary">Active</Badge>
										</TableCell>
										<TableCell className="hidden md:table-cell">
											$2.99
										</TableCell>
										<TableCell className="hidden md:table-cell">0</TableCell>
										<TableCell className="hidden md:table-cell">
											2023-12-25 11:59 PM
										</TableCell>
										<TableCell>
											<DropdownMenu>
												<DropdownMenuTrigger asChild>
													<Button
														aria-haspopup="true"
														size="icon"
														variant="ghost"
													>
														<MoreHorizontal className="h-4 w-4" />
														<span className="sr-only">Toggle menu</span>
													</Button>
												</DropdownMenuTrigger>
												<DropdownMenuContent align="end">
													<DropdownMenuLabel>Actions</DropdownMenuLabel>
													<DropdownMenuItem>Edit</DropdownMenuItem>
													<DropdownMenuItem>Delete</DropdownMenuItem>
												</DropdownMenuContent>
											</DropdownMenu>
										</TableCell>
									</TableRow>
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
											handleChangePage={handleAddParams}
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

const ProductsSkeleton = ({ count }: { count: number }) => {
	return (
		<>
			{Array.from({ length: count }).map((_, index) => (
				<TableRow key={index}>
					<TableCell className="hidden sm:table-cell">
						<Skeleton className="bg-slate-300 h-16 w-16 rounded-full" />
					</TableCell>
					<TableCell className="font-medium">
						<Skeleton className="bg-slate-300 h-6 w-32 rounded-full" />
					</TableCell>
					<TableCell>
						<Skeleton className="bg-slate-300 h-6 w-10 rounded-full" />
					</TableCell>
					<TableCell className="hidden md:table-cell">
						<Skeleton className="bg-slate-300 h-6 w-32 rounded-full" />
					</TableCell>
					<TableCell className="hidden md:table-cell">
						<Skeleton className="bg-slate-300 h-6 w-32 rounded-full" />
					</TableCell>
					<TableCell className="hidden md:table-cell">
						<Skeleton className="bg-slate-300 h-6 w-32 rounded-full" />
					</TableCell>
					<TableCell className="hidden md:table-cell">
						<Skeleton className="bg-slate-300 h-6 w-32 rounded-full" />
					</TableCell>
					<TableCell>
						<DropdownMenu>
							<DropdownMenuTrigger asChild>
								<Button aria-haspopup="true" size="icon" variant="ghost">
									<MoreHorizontal className="h-4 w-4" />
									<span className="sr-only">Toggle menu</span>
								</Button>
							</DropdownMenuTrigger>
							<DropdownMenuContent align="end">
								<DropdownMenuLabel>Actions</DropdownMenuLabel>
								<DropdownMenuItem>Edit</DropdownMenuItem>

								<DropdownMenuItem>Delete</DropdownMenuItem>
							</DropdownMenuContent>
						</DropdownMenu>
					</TableCell>
				</TableRow>
			))}
		</>
	);
};
