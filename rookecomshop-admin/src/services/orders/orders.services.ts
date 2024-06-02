import interceptor from '@/components/hoc/AxiosInterceptor';
import { OrderDto, UpdateOrderDto } from './orders.type';
import { PagniatedList } from '@/types/pagniated-list.type';

const getListAsync = async (): Promise<PagniatedList<OrderDto>> => {
	const res = await interceptor.get<PagniatedList<OrderDto>>('/orders');

	return res.data;
};

const getByIdAsync = async (id: string): Promise<OrderDto> => {
	const res = await interceptor.get<OrderDto>(`/orders/${id}`);

	return res.data;
};

const updateOrderStatusAsync = async (request: UpdateOrderDto): Promise<void> => {
	switch (request.action) {
		case 'confirm':
			await interceptor.patch(`/orders/${request.id}/confirm`);
			break;
		case 'cancel':
			await interceptor.patch(`/orders/${request.id}/cancel`);
			break;
		default:
			break;
	}
};

const ordersService = {
	getListAsync,
	getByIdAsync,
	updateOrderStatusAsync,
};

export default ordersService;
