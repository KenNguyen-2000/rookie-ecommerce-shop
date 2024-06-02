import { Badge } from '@/components/ui/badge';
import { Button } from '@/components/ui/button';
import {
	DropdownMenu,
	DropdownMenuContent,
	DropdownMenuItem,
	DropdownMenuLabel,
	DropdownMenuTrigger,
} from '@/components/ui/dropdown-menu';
import { TableCell, TableRow } from '@/components/ui/table';
import { OrderStatus } from '@/services/orders/orders.enum';
import { OrderDto } from '@/services/orders/orders.type';
import { MoreHorizontal } from 'lucide-react';
import moment from 'moment';
import React, { FC } from 'react';

type OrderRowProps = {
	order: OrderDto;
	onConfirm: (id: string) => void;
	onCancel: (id: string) => void;
	onSelectOrder: (order: OrderDto) => void;
};

const OrderRow: FC<OrderRowProps> = ({ order, onCancel, onConfirm, onSelectOrder }) => {
	return (
		<TableRow>
			<TableCell onClick={onSelectOrder.bind(null, order)}>
				<div className="font-medium">
					{order.user.firstName} {order.user.lastName}
				</div>
				<div className="hidden text-sm text-muted-foreground md:inline">
					{order.user.email ?? order.user.phoneNumber ?? 'N/A'}
				</div>
			</TableCell>
			<TableCell className="hidden sm:table-cell">
                {order.paymentTransaction.paymentInfo.contactInfo}
            </TableCell>
			<TableCell className="hidden sm:table-cell">
				<Badge className="text-xs" variant={order.status === OrderStatus.Cancelled ? "outline" :"secondary"}>
					{OrderStatus[order.status]}
				</Badge>
			</TableCell>
			<TableCell className="hidden md:table-cell">
				{moment(order.orderDate).format('DD/MM/YYYY')}
			</TableCell>
			<TableCell className="text-right">${order.totalAmount.toFixed(2)}</TableCell>
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
						<DropdownMenuItem onClick={onConfirm.bind(null, order.id)}>
							Confirm
						</DropdownMenuItem>

						<DropdownMenuItem onClick={onCancel.bind(null, order.id)}>
							Cancel
						</DropdownMenuItem>
					</DropdownMenuContent>
				</DropdownMenu>
			</TableCell>
		</TableRow>
	);
};

export default OrderRow;
