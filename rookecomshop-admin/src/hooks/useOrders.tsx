import ordersService from '@/services/orders/orders.services';
import { UseQueryOptions, useQuery, useQueryClient } from '@tanstack/react-query';

export default function useOrders(props?: UseQueryOptions) {
	const queryClient = useQueryClient();
	const queryResult = useQuery({
		queryKey: ['orders'],
		queryFn: () => ordersService.getListAsync(),
	});

	const onCancel = async (id: string) => {
		await ordersService.updateOrderStatusAsync({ id, action: 'cancel' });
		queryClient.invalidateQueries({ queryKey: ['orders'] });
	};

	const onConfirm = async (id: string) => {
		await ordersService.updateOrderStatusAsync({ id, action: 'confirm' });
		queryClient.invalidateQueries({ queryKey: ['orders'] });
	};

	return { queryResult, onCancel, onConfirm };
}
