import { ProductDto } from '../products/products.type';
import { UserDto } from '../users/users.type';
import { OrderStatus } from './orders.enum';

export type OrderDto = {
	id: string;
	status: OrderStatus;
	totalAmount: number;
	orderDate: string;
	user: UserDto;
	orderItems: OrderDetailDto[];
	paymentTransaction: PaymentTransactionDto;
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

export type PaymentTransactionDto = {
	status: PaymentTransactionStatus;
	totalAmount: number;
	transactionDate: string;
	user: UserDto;
	paymentInfo: PaymentInfoDto;
};
export type PaymentInfoDto = {
	contactInfo: string;
	firstName: string;
	lastName: string;
	shippingAddress: string;
	city?: string;
	postalCode?: string;
	province?: string;
};

export enum PaymentTransactionStatus {
	Pending = 0,
	Success = 1,
	Failed = 2,
}
