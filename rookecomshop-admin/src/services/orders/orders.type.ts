import { ProductDto } from '../products/products.type';
import { UserDto } from '../users/users.type';
import { OrderStatus } from './orders.enum';

export type OrderDto = {
	id: string;
	status: OrderStatus;
	totalAmount: number;
	orderDate: string;
	user: UserDto;
	items: OrderDetailDto[];
};

export type OrderDetailDto = {
	id: string;
	quantity: number;
	unitPrice: number;
	totalPrice: number;
	product: ProductDto;
};

export type UpdateOrderDto = {
	id: string;
	action: 'confirm' | 'cancel' | 'deliver';
};
