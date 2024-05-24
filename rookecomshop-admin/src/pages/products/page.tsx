/* eslint-disable @typescript-eslint/no-explicit-any */
import { File, ListFilter, MoreHorizontal, PlusCircle } from 'lucide-react';

import { Badge } from '@/components/ui/badge';
import { Button } from '@/components/ui/button';
import { Card, CardContent, CardDescription, CardFooter, CardHeader, CardTitle } from '@/components/ui/card';
import {
	DropdownMenu,
	DropdownMenuCheckboxItem,
	DropdownMenuContent,
	DropdownMenuItem,
	DropdownMenuLabel,
	DropdownMenuSeparator,
	DropdownMenuTrigger,
} from '@/components/ui/dropdown-menu';
import { Table, TableBody, TableCell, TableHead, TableHeader, TableRow } from '@/components/ui/table';
import { Tabs, TabsContent, TabsList, TabsTrigger } from '@/components/ui/tabs';
import moment from 'moment';
import { useEffect, useState } from 'react';
import { useAppDispatch, useAppSelector } from '@/redux/reduxHooks';
import { useNavigate } from 'react-router-dom';
import { deleteProductAsync, getProductsAsync } from '@/redux/thunks/products.thunk';
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

const ProductPage = () => {
	const navigate = useNavigate();
	const dispatch = useAppDispatch();
	const { products } = useAppSelector((state) => state.products);
	const [isOpen, setIsOpen] = useState(false);
	const [productId, setProductId] = useState<number | null>(null);

	const handleDeleteProduct = () => {
		if (productId) {
			//Delete product
			console.log('Delete product');
			dispatch(deleteProductAsync(productId));
		}
		setIsOpen(false);
	};

	const onSelectProductToDelete = (productId: number) => {
		setIsOpen(true);
		setProductId(productId);
	};

	useEffect(() => {
		dispatch(getProductsAsync());
	}, [dispatch]);

	return (
		<ContentSidebarLayout>
			<AlertPopup open={isOpen} confirmAction={handleDeleteProduct} />
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
									<span className="sr-only sm:not-sr-only sm:whitespace-nowrap">Filter</span>
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
							<span className="sr-only sm:not-sr-only sm:whitespace-nowrap">Export</span>
						</Button>
						<Button size="sm" className="h-8 gap-1" onClick={() => navigate('/products/create')}>
							<PlusCircle className="h-3.5 w-3.5" />
							<span className="sr-only sm:not-sr-only sm:whitespace-nowrap">Add Product</span>
						</Button>
					</div>
				</div>
				<TabsContent value="all">
					<Card x-chunk="dashboard-06-chunk-0">
						<CardHeader>
							<CardTitle>Products</CardTitle>
							<CardDescription>Manage your products and view their sales performance.</CardDescription>
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
										<TableHead className="hidden md:table-cell">Price</TableHead>
										<TableHead className="hidden md:table-cell">Total Sales</TableHead>
										<TableHead className="hidden md:table-cell">Category</TableHead>
										<TableHead className="hidden md:table-cell">Created at</TableHead>
										<TableHead>
											<span className="sr-only">Actions</span>
										</TableHead>
									</TableRow>
								</TableHeader>
								<TableBody>
									{products?.map((product: any) => (
										<TableRow key={product.id}>
											<TableCell className="hidden sm:table-cell">
												<img
													alt="Product image"
													className="aspect-square rounded-md object-cover"
													height="64"
													src="/placeholder.svg"
													width="64"
												/>
											</TableCell>
											<TableCell className="font-medium">{product.name}</TableCell>
											<TableCell>
												<Badge variant="outline">Draft</Badge>
											</TableCell>
											<TableCell className="hidden md:table-cell">${product.price}</TableCell>
											<TableCell className="hidden md:table-cell">25</TableCell>
											<TableCell className="hidden md:table-cell">
												{product.category.name}
											</TableCell>
											<TableCell className="hidden md:table-cell">
												{moment(product.createdAt).format('DD/MM/yyyy')}
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
														<DropdownMenuItem
															onClick={() => navigate(`/products/${product.id}`)}
														>
															Edit
														</DropdownMenuItem>

														<DropdownMenuItem
															onClick={onSelectProductToDelete.bind(null, product.id)}
														>
															Delete
														</DropdownMenuItem>
													</DropdownMenuContent>
												</DropdownMenu>
											</TableCell>
										</TableRow>
									))}

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
										<TableCell className="font-medium">TechTonic Energy Drink</TableCell>
										<TableCell>
											<Badge variant="secondary">Active</Badge>
										</TableCell>
										<TableCell className="hidden md:table-cell">$2.99</TableCell>
										<TableCell className="hidden md:table-cell">0</TableCell>
										<TableCell className="hidden md:table-cell">2023-12-25 11:59 PM</TableCell>
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
								</TableBody>
							</Table>
						</CardContent>
						<CardFooter>
							<div className="w-full flex items-center">
								<div className="text-xs text-muted-foreground">
									Showing <strong>1-10</strong> of <strong>32</strong> products
								</div>
								<div className="ml-auto">
									<Pagination>
										<PaginationContent>
											<PaginationItem>
												<PaginationPrevious href="#" />
											</PaginationItem>
											<PaginationItem>
												<PaginationLink href="#">1</PaginationLink>
											</PaginationItem>
											<PaginationItem>
												<PaginationLink href="#" isActive>
													2
												</PaginationLink>
											</PaginationItem>
											<PaginationItem>
												<PaginationLink href="#">3</PaginationLink>
											</PaginationItem>
											<PaginationItem>
												<PaginationEllipsis />
											</PaginationItem>
											<PaginationItem>
												<PaginationNext href="#" />
											</PaginationItem>
										</PaginationContent>
									</Pagination>
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
