import {
	ChevronLeft,
	ChevronRight,
	Copy,
	CreditCard,
	File,
	Home,
	LineChart,
	ListFilter,
	MoreVertical,
	Package,
	Package2,
	PanelLeft,
	Search,
	ShoppingCart,
	Truck,
	Users2,
} from 'lucide-react';

import { Badge } from '@/components/ui/badge';
import {
	Breadcrumb,
	BreadcrumbItem,
	BreadcrumbLink,
	BreadcrumbList,
	BreadcrumbPage,
	BreadcrumbSeparator,
} from '@/components/ui/breadcrumb';
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
import { Input } from '@/components/ui/input';
import { Pagination, PaginationContent, PaginationItem } from '@/components/ui/pagination';
import { Progress } from '@/components/ui/progress';
import { Separator } from '@/components/ui/separator';
import { Sheet, SheetContent, SheetTrigger } from '@/components/ui/sheet';
import {
	Table,
	TableBody,
	TableCell,
	TableHead,
	TableHeader,
	TableRow,
} from '@/components/ui/table';
import { Tabs, TabsContent, TabsList, TabsTrigger } from '@/components/ui/tabs';
import { RookEcomSidebar } from '@/components/page';
import OrderRow from './components/OrderRow';
import useOrders from '@/hooks/useOrders';
import OrderDetail from './components/OrderDetail';
import { useState } from 'react';
import { OrderDto } from '@/services/orders/orders.type';

const OrdersPage = () => {
	const {
		queryResult: { data: orders },
		onConfirm,
		onCancel,
	} = useOrders();
	const [selectedOrder, setSelectedOrder] = useState<OrderDto | null>(null);

	return (
		<div className="flex min-h-screen w-full flex-col bg-muted/40">
			<RookEcomSidebar />

			<div className="flex flex-col sm:gap-4 sm:py-4 sm:pl-14">
				<header className="sticky top-0 z-30 flex h-14 items-center gap-4 border-b bg-background px-4 sm:static sm:h-auto sm:border-0 sm:bg-transparent sm:px-6">
					<Sheet>
						<SheetTrigger asChild>
							<Button size="icon" variant="outline" className="sm:hidden">
								<PanelLeft className="h-5 w-5" />
								<span className="sr-only">Toggle Menu</span>
							</Button>
						</SheetTrigger>
						<SheetContent side="left" className="sm:max-w-xs">
							<nav className="grid gap-6 text-lg font-medium">
								<a
									href="#"
									className="group flex h-10 w-10 shrink-0 items-center justify-center gap-2 rounded-full bg-primary text-lg font-semibold text-primary-foreground md:text-base"
								>
									<Package2 className="h-5 w-5 transition-all group-hover:scale-110" />
									<span className="sr-only">Acme Inc</span>
								</a>
								<a
									href="#"
									className="flex items-center gap-4 px-2.5 text-muted-foreground hover:text-foreground"
								>
									<Home className="h-5 w-5" />
									Dashboard
								</a>
								<a
									href="#"
									className="flex items-center gap-4 px-2.5 text-foreground"
								>
									<ShoppingCart className="h-5 w-5" />
									Orders
								</a>
								<a
									href="#"
									className="flex items-center gap-4 px-2.5 text-muted-foreground hover:text-foreground"
								>
									<Package className="h-5 w-5" />
									Products
								</a>
								<a
									href="#"
									className="flex items-center gap-4 px-2.5 text-muted-foreground hover:text-foreground"
								>
									<Users2 className="h-5 w-5" />
									Customers
								</a>
								<a
									href="#"
									className="flex items-center gap-4 px-2.5 text-muted-foreground hover:text-foreground"
								>
									<LineChart className="h-5 w-5" />
									Settings
								</a>
							</nav>
						</SheetContent>
					</Sheet>
					<Breadcrumb className="hidden md:flex">
						<BreadcrumbList>
							<BreadcrumbItem>
								<BreadcrumbLink asChild>
									<a href="#">Dashboard</a>
								</BreadcrumbLink>
							</BreadcrumbItem>
							<BreadcrumbSeparator />
							<BreadcrumbItem>
								<BreadcrumbLink asChild>
									<a href="#">Orders</a>
								</BreadcrumbLink>
							</BreadcrumbItem>
							<BreadcrumbSeparator />
							<BreadcrumbItem>
								<BreadcrumbPage>Recent Orders</BreadcrumbPage>
							</BreadcrumbItem>
						</BreadcrumbList>
					</Breadcrumb>
					<div className="relative ml-auto flex-1 md:grow-0">
						<Search className="absolute left-2.5 top-2.5 h-4 w-4 text-muted-foreground" />
						<Input
							type="search"
							placeholder="Search..."
							className="w-full rounded-lg bg-background pl-8 md:w-[200px] lg:w-[336px]"
						/>
					</div>
					<DropdownMenu>
						<DropdownMenuTrigger asChild>
							<Button
								variant="outline"
								size="icon"
								className="overflow-hidden rounded-full"
							>
								<img
									src="/placeholder-user.jpg"
									width={36}
									height={36}
									alt="Avatar"
									className="overflow-hidden rounded-full"
								/>
							</Button>
						</DropdownMenuTrigger>
						<DropdownMenuContent align="end">
							<DropdownMenuLabel>My Account</DropdownMenuLabel>
							<DropdownMenuSeparator />
							<DropdownMenuItem>Settings</DropdownMenuItem>
							<DropdownMenuItem>Support</DropdownMenuItem>
							<DropdownMenuSeparator />
							<DropdownMenuItem>Logout</DropdownMenuItem>
						</DropdownMenuContent>
					</DropdownMenu>
				</header>
				<main className="grid flex-1 items-start gap-4 p-4 sm:px-6 sm:py-0 md:gap-8 lg:grid-cols-3 xl:grid-cols-3">
					<div className="grid auto-rows-max items-start gap-4 md:gap-8 lg:col-span-2">
						<div className="grid gap-4 sm:grid-cols-2 md:grid-cols-4 lg:grid-cols-2 xl:grid-cols-4">
							<Card className="sm:col-span-2" x-chunk="dashboard-05-chunk-0">
								<CardHeader className="pb-3">
									<CardTitle>Your Orders</CardTitle>
									<CardDescription className="max-w-lg text-balance leading-relaxed">
										Introducing Our Dynamic Orders Dashboard for Seamless
										Management and Insightful Analysis.
									</CardDescription>
								</CardHeader>
								<CardFooter>
									<Button>Create New Order</Button>
								</CardFooter>
							</Card>
							<Card x-chunk="dashboard-05-chunk-1">
								<CardHeader className="pb-2">
									<CardDescription>This Week</CardDescription>
									<CardTitle className="text-4xl">$1,329</CardTitle>
								</CardHeader>
								<CardContent>
									<div className="text-xs text-muted-foreground">
										+25% from last week
									</div>
								</CardContent>
								<CardFooter>
									<Progress value={25} aria-label="25% increase" />
								</CardFooter>
							</Card>
							<Card x-chunk="dashboard-05-chunk-2">
								<CardHeader className="pb-2">
									<CardDescription>This Month</CardDescription>
									<CardTitle className="text-4xl">$5,329</CardTitle>
								</CardHeader>
								<CardContent>
									<div className="text-xs text-muted-foreground">
										+10% from last month
									</div>
								</CardContent>
								<CardFooter>
									<Progress value={12} aria-label="12% increase" />
								</CardFooter>
							</Card>
						</div>
						<Tabs defaultValue="week">
							<div className="flex items-center">
								<TabsList>
									<TabsTrigger value="week">Week</TabsTrigger>
									<TabsTrigger value="month">Month</TabsTrigger>
									<TabsTrigger value="year">Year</TabsTrigger>
								</TabsList>
								<div className="ml-auto flex items-center gap-2">
									<DropdownMenu>
										<DropdownMenuTrigger asChild>
											<Button
												variant="outline"
												size="sm"
												className="h-7 gap-1 text-sm"
											>
												<ListFilter className="h-3.5 w-3.5" />
												<span className="sr-only sm:not-sr-only">
													Filter
												</span>
											</Button>
										</DropdownMenuTrigger>
										<DropdownMenuContent align="end">
											<DropdownMenuLabel>Filter by</DropdownMenuLabel>
											<DropdownMenuSeparator />
											<DropdownMenuCheckboxItem checked>
												Fulfilled
											</DropdownMenuCheckboxItem>
											<DropdownMenuCheckboxItem>
												Declined
											</DropdownMenuCheckboxItem>
											<DropdownMenuCheckboxItem>
												Refunded
											</DropdownMenuCheckboxItem>
										</DropdownMenuContent>
									</DropdownMenu>
									<Button
										size="sm"
										variant="outline"
										className="h-7 gap-1 text-sm"
									>
										<File className="h-3.5 w-3.5" />
										<span className="sr-only sm:not-sr-only">Export</span>
									</Button>
								</div>
							</div>
							<TabsContent value="week">
								<Card x-chunk="dashboard-05-chunk-3">
									<CardHeader className="px-7">
										<CardTitle>Orders</CardTitle>
										<CardDescription>
											Recent orders from your store.
										</CardDescription>
									</CardHeader>
									<CardContent>
										<Table>
											<TableHeader>
												<TableRow>
													<TableHead>Customer</TableHead>
													<TableHead className="hidden sm:table-cell">
														Contact Info
													</TableHead>
													<TableHead className="hidden sm:table-cell">
														Status
													</TableHead>
													<TableHead className="hidden md:table-cell">
														Date
													</TableHead>
													<TableHead className="text-right">
														Amount
													</TableHead>
													<TableHead>
														<span className="sr-only">Actions</span>
													</TableHead>
												</TableRow>
											</TableHeader>
											<TableBody>
												{orders?.items?.map((order) => (
													<OrderRow
														key={order.id}
														order={order}
														onConfirm={onConfirm}
														onCancel={onCancel}
														onSelectOrder={(order) =>
															setSelectedOrder(order)
														}
													/>
												))}
											</TableBody>
										</Table>
									</CardContent>
								</Card>
							</TabsContent>
						</Tabs>
					</div>
					<div>
						<OrderDetail order={selectedOrder} />
					</div>
				</main>
			</div>
		</div>
	);
};

export default OrdersPage;
