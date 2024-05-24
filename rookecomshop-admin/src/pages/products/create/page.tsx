/* eslint-disable @typescript-eslint/no-unused-vars */
import { ContentSidebarLayout } from '@/components/layouts';
import { useAppDispatch } from '@/redux/reduxHooks';
import { createProductAsync } from '@/redux/thunks/products.thunk';
import { CreateUpdateProductInputs } from '@/services/products/products.type';
import { useState } from 'react';
import { useToast } from '@/components/ui/use-toast';
import CreateUpdateProductForm from '@/components/page/CreateUpdateProductForm';

const CreateProductPage = () => {
	const { toast } = useToast();
	const dispatch = useAppDispatch();

	const [createProductLoading, setCreateProductLoading] = useState(false);

	const onSubmit = async (data: CreateUpdateProductInputs) => {
		setCreateProductLoading(true);
		await dispatch(createProductAsync(data));
		setCreateProductLoading(false);
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
					name: "",
					price: 0,
					stockQuantity: 0,
					description: "",
					categoryName: "",
				}}
				handleSubmitForm={onSubmit}
			/>
		</ContentSidebarLayout>
	);
};

export default CreateProductPage;
