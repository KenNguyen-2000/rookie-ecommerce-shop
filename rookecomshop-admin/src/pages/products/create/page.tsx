import { ContentSidebarLayout } from '@/components/layouts';
import { CreateUpdateProductInputs } from '@/services/products/products.type';
import CreateUpdateProductForm from '@/components/page/CreateUpdateProductForm';
import { useMutation, useQueryClient } from '@tanstack/react-query';
import productsService from '@/services/products/products.service';
import { toast } from 'react-toastify';

const CreateProductPage = () => {
	const queryClient = useQueryClient();

	const createProductMutation = useMutation({
		mutationFn: productsService.createProductAsync,
		onSuccess: () => {
			queryClient.invalidateQueries({ queryKey: ['products'] });
		},
	});

	const onSubmit = async (data: CreateUpdateProductInputs) => {
		console.log(data);
		await createProductMutation.mutateAsync(data);
		toast.success('Product created!');
	};

	return (
		<ContentSidebarLayout>
			<CreateUpdateProductForm
				defaultValue={{
					name: '',
					price: 0,
					stockQuantity: 0,
					description: '',
					categoryName: '',
				}}
				handleSubmitForm={onSubmit}
			/>
		</ContentSidebarLayout>
	);
};

export default CreateProductPage;
