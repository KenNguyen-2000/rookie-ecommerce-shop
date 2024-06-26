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
	DropdownMenuContent,
	DropdownMenuItem,
	DropdownMenuSeparator,
	DropdownMenuTrigger,
} from '@/components/ui/dropdown-menu';
import { Pagination, PaginationContent, PaginationItem } from '@/components/ui/pagination';
import { Separator } from '@/components/ui/separator';
import { OrderDto } from '@/services/orders/orders.type';
import { ChevronLeft, ChevronRight, Copy, CreditCard, MoreVertical, Truck } from 'lucide-react';
import moment from 'moment';
import React, { FC } from 'react';

type OrderDetailProps = {
	order: OrderDto | null;
};

const OrderDetail: FC<OrderDetailProps> = ({ order }) => {
	if (!order) {
		return <EmptyOrder />;
	}

	const {
		paymentTransaction: { paymentInfo, transactionDate },
	} = order;
	return (
		<Card className="overflow-hidden" x-chunk="dashboard-05-chunk-4">
			<CardHeader className="flex flex-row items-start bg-muted/50">
				<div className="grid gap-0.5">
					<CardTitle className="group flex items-center gap-2 text-lg">
						Order {order.id.substring(0, 8)}
						<Button
							size="icon"
							variant="outline"
							className="h-6 w-6 opacity-0 transition-opacity group-hover:opacity-100"
						>
							<Copy className="h-3 w-3" />
							<span className="sr-only">Copy Order ID</span>
						</Button>
					</CardTitle>
					<CardDescription>
						Date: {moment(order.orderDate).format('MMMM DD, YYYY')}
					</CardDescription>
				</div>
				<div className="ml-auto flex items-center gap-1">
					<Button size="sm" variant="outline" className="h-8 gap-1">
						<Truck className="h-3.5 w-3.5" />
						<span className="lg:sr-only xl:not-sr-only xl:whitespace-nowrap">
							Track Order
						</span>
					</Button>
					<DropdownMenu>
						<DropdownMenuTrigger asChild>
							<Button size="icon" variant="outline" className="h-8 w-8">
								<MoreVertical className="h-3.5 w-3.5" />
								<span className="sr-only">More</span>
							</Button>
						</DropdownMenuTrigger>
						<DropdownMenuContent align="end">
							<DropdownMenuItem>Edit</DropdownMenuItem>
							<DropdownMenuItem>Export</DropdownMenuItem>
							<DropdownMenuSeparator />
							<DropdownMenuItem>Trash</DropdownMenuItem>
						</DropdownMenuContent>
					</DropdownMenu>
				</div>
			</CardHeader>
			<CardContent className="p-6 text-sm">
				<div className="grid gap-3">
					<div className="font-semibold">Order Details</div>
					<ul className="grid gap-3">
						{order.orderItems.map((item) => (
							<li key={item.id} className="flex items-center justify-between">
								<span className="text-muted-foreground">
									{item.product.name} x <span>{item.quantity}</span>
								</span>
								<span>${item.totalPrice}</span>
							</li>
						))}
					</ul>
					<Separator className="my-2" />
					<ul className="grid gap-3">
						<li className="flex items-center justify-between">
							<span className="text-muted-foreground">Subtotal</span>
							<span>${order.totalAmount}</span>
						</li>
						<li className="flex items-center justify-between">
							<span className="text-muted-foreground">Shipping</span>
							<span>$0.00</span>
						</li>
						<li className="flex items-center justify-between">
							<span className="text-muted-foreground">Tax</span>
							<span>$00.00</span>
						</li>
						<li className="flex items-center justify-between font-semibold">
							<span className="text-muted-foreground">Total</span>
							<span>${order.totalAmount}</span>
						</li>
					</ul>
				</div>
				<Separator className="my-4" />
				<div className="grid grid-cols-1 gap-4">
					<div className="grid gap-3">
						<div className="font-semibold">Shipping Information</div>
						<address className="grid gap-0.5 not-italic text-muted-foreground">
							<span>
								{paymentInfo.firstName} {paymentInfo.lastName}
							</span>
							<span>{paymentInfo.contactInfo}</span>
							<span>{paymentInfo.shippingAddress}</span>
							<span>
								{paymentInfo.city}, {paymentInfo.province} {paymentInfo.postalCode}
							</span>
						</address>
					</div>
					{/* <div className="grid auto-rows-max gap-3">
						<div className="font-semibold">Billing Information</div>
						<div className="text-muted-foreground">Same as shipping address</div>
					</div> */}
				</div>
				<Separator className="my-4" />
				<div className="grid gap-3">
					<div className="font-semibold">Customer Information</div>
					<dl className="grid gap-3">
						<div className="flex items-center justify-between">
							<dt className="text-muted-foreground">Customer</dt>
							<dd>
								{order.user.firstName} {order.user.lastName}
							</dd>
						</div>
						<div className="flex items-center justify-between">
							<dt className="text-muted-foreground">Email</dt>
							<dd>
								<a href="mailto:">{order.user.email ?? 'N/A'}</a>
							</dd>
						</div>
						<div className="flex items-center justify-between">
							<dt className="text-muted-foreground">Phone</dt>
							<dd>
								<a href="tel:">{order.user.phoneNumber ?? 'N/A'}</a>
							</dd>
						</div>
					</dl>
				</div>
				<Separator className="my-4" />
				<div className="grid gap-3">
					<div className="font-semibold">Payment Information</div>
					<dl className="grid gap-3">
						<div className="flex items-center justify-between">
							<dt className="flex items-center gap-1 text-muted-foreground">
								<CreditCard className="h-4 w-4" />
								Visa
							</dt>
							<dd>**** **** **** 4532</dd>
						</div>
					</dl>
				</div>
			</CardContent>
			<CardFooter className="flex flex-row items-center border-t bg-muted/50 px-6 py-3">
				<div className="text-xs text-muted-foreground">
					Updated{' '}
					<time dateTime="2023-11-23">
						{moment(transactionDate).format('MMMM DD, YYYY')}
					</time>
				</div>
				<Pagination className="ml-auto mr-0 w-auto">
					<PaginationContent>
						<PaginationItem>
							<Button size="icon" variant="outline" className="h-6 w-6">
								<ChevronLeft className="h-3.5 w-3.5" />
								<span className="sr-only">Previous Order</span>
							</Button>
						</PaginationItem>
						<PaginationItem>
							<Button size="icon" variant="outline" className="h-6 w-6">
								<ChevronRight className="h-3.5 w-3.5" />
								<span className="sr-only">Next Order</span>
							</Button>
						</PaginationItem>
					</PaginationContent>
				</Pagination>
			</CardFooter>
		</Card>
	);
};

export default OrderDetail;

const EmptyOrder = () => {
	return (
		<Card className="overflow-hidden" x-chunk="dashboard-05-chunk-4">
			<CardHeader className="flex flex-row items-start bg-muted/50">
				<div className="grid gap-0.5">
					<CardTitle className="group flex items-center gap-2 text-lg">
						Order
						<Button
							size="icon"
							variant="outline"
							className="h-6 w-6 opacity-0 transition-opacity group-hover:opacity-100"
						>
							<Copy className="h-3 w-3" />
							<span className="sr-only">Copy Order ID</span>
						</Button>
					</CardTitle>
					<CardDescription>Date:</CardDescription>
				</div>
				<div className="ml-auto flex items-center gap-1">
					<Button size="sm" variant="outline" className="h-8 gap-1">
						<Truck className="h-3.5 w-3.5" />
						<span className="lg:sr-only xl:not-sr-only xl:whitespace-nowrap">
							Track Order
						</span>
					</Button>
					<DropdownMenu>
						<DropdownMenuTrigger asChild>
							<Button size="icon" variant="outline" className="h-8 w-8">
								<MoreVertical className="h-3.5 w-3.5" />
								<span className="sr-only">More</span>
							</Button>
						</DropdownMenuTrigger>
						<DropdownMenuContent align="end">
							<DropdownMenuItem>Edit</DropdownMenuItem>
							<DropdownMenuItem>Export</DropdownMenuItem>
							<DropdownMenuSeparator />
							<DropdownMenuItem>Trash</DropdownMenuItem>
						</DropdownMenuContent>
					</DropdownMenu>
				</div>
			</CardHeader>
			<CardContent className="p-6 text-sm">
				<div className="grid gap-3">
					<div className="font-semibold">Order Details</div>
					<ul className="grid gap-3"></ul>
					<Separator className="my-2" />
					<ul className="grid gap-3">
						<li className="flex items-center justify-between">
							<span className="text-muted-foreground">Subtotal</span>
							<span>$00.00</span>
						</li>
						<li className="flex items-center justify-between">
							<span className="text-muted-foreground">Shipping</span>
							<span>$00.00</span>
						</li>
						<li className="flex items-center justify-between">
							<span className="text-muted-foreground">Tax</span>
							<span>$00.00</span>
						</li>
						<li className="flex items-center justify-between font-semibold">
							<span className="text-muted-foreground">Total</span>
							<span>$00.00</span>
						</li>
					</ul>
				</div>
				<Separator className="my-4" />
				<div className="grid grid-cols-2 gap-4">
					<div className="grid gap-3">
						<div className="font-semibold">Shipping Information</div>
						<address className="grid gap-0.5 not-italic text-muted-foreground">
							<span>N/A</span>
							<span>N/A</span>
							<span>N/A</span>
						</address>
					</div>
					<div className="grid auto-rows-max gap-3">
						<div className="font-semibold">Billing Information</div>
						<div className="text-muted-foreground">Same as shipping address</div>
					</div>
				</div>
				<Separator className="my-4" />
				<div className="grid gap-3">
					<div className="font-semibold">Customer Information</div>
					<dl className="grid gap-3">
						<div className="flex items-center justify-between">
							<dt className="text-muted-foreground">Customer</dt>
							<dd>N/A</dd>
						</div>
						<div className="flex items-center justify-between">
							<dt className="text-muted-foreground">Email</dt>
							<dd>
								<a href="mailto:">N/A</a>
							</dd>
						</div>
						<div className="flex items-center justify-between">
							<dt className="text-muted-foreground">Phone</dt>
							<dd>
								<a href="tel:">N/A</a>
							</dd>
						</div>
					</dl>
				</div>
				<Separator className="my-4" />
				<div className="grid gap-3">
					<div className="font-semibold">Payment Information</div>
					<dl className="grid gap-3">
						<div className="flex items-center justify-between">
							<dt className="flex items-center gap-1 text-muted-foreground">
								<CreditCard className="h-4 w-4" />
								Visa
							</dt>
							<dd>N/A</dd>
						</div>
					</dl>
				</div>
			</CardContent>
			<CardFooter className="flex flex-row items-center border-t bg-muted/50 px-6 py-3">
				<div className="text-xs text-muted-foreground">
					Updated <time dateTime="2023-11-23">N/A</time>
				</div>
				<Pagination className="ml-auto mr-0 w-auto">
					<PaginationContent>
						<PaginationItem>
							<Button size="icon" variant="outline" className="h-6 w-6">
								<ChevronLeft className="h-3.5 w-3.5" />
								<span className="sr-only">Previous Order</span>
							</Button>
						</PaginationItem>
						<PaginationItem>
							<Button size="icon" variant="outline" className="h-6 w-6">
								<ChevronRight className="h-3.5 w-3.5" />
								<span className="sr-only">Next Order</span>
							</Button>
						</PaginationItem>
					</PaginationContent>
				</Pagination>
			</CardFooter>
		</Card>
	);
};
