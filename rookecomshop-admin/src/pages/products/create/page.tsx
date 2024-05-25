/* eslint-disable @typescript-eslint/no-unused-vars */
import { ContentSidebarLayout } from '@/components/layouts';
import { useAppDispatch } from '@/redux/reduxHooks';
import { CreateUpdateProductInputs } from '@/services/products/products.type';
import { useState } from 'react';
import { useToast } from '@/components/ui/use-toast';
import CreateUpdateProductForm from '@/components/page/CreateUpdateProductForm';
import { useMutation, useQueryClient } from '@tanstack/react-query';
import productsService from '@/services/products/products.service';

const CreateProductPage = () => {
	const { toast } = useToast();
	const dispatch = useAppDispatch();
	const queryClient = useQueryClient();

	const createProductMutation = useMutation({
		mutationFn: productsService.createProductAsync,
		onSuccess: () => {
			queryClient.invalidateQueries({ queryKey: ['products'] });
		},
	});

	const onSubmit = async (data: CreateUpdateProductInputs) => {
		await createProductMutation.mutateAsync(data);
		toast({
			title: 'Create Product Succeeded',
			description: (
				<pre className="mt-2 w-[340px] rounded-md bg-slate-950 p-4">
					<code className="text-white">{JSON.stringify(data, null, 2)}</code>
				</pre>
			),
		});
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
