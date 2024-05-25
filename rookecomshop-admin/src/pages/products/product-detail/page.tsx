import { ContentSidebarLayout } from '@/components/layouts';
import { useQuery } from '@tanstack/react-query';
import { useParams } from 'react-router-dom';
import productsService from '@/services/products/products.service';
import { CreateUpdateProductInputs } from '@/services/products/products.type';
import { useAppDispatch } from '@/redux/reduxHooks';
import CreateUpdateProductForm from '@/components/page/CreateUpdateProductForm';
import { updateProductAsync } from '@/redux/thunks/products.thunk';
import { toast } from '@/components/ui/use-toast';

const ProductDetailPage = () => {
	const { id } = useParams();
	const dispatch = useAppDispatch();
	const {
		data: product,
		isLoading,
		isError,
	} = useQuery({
		queryKey: ['product', id],
		queryFn: () => productsService.getByIdAsync(parseInt(id!)),
	});

	const onSubmit = async (data: CreateUpdateProductInputs) => {
		if (!product) return;
		console.log(data);
		await dispatch(
			updateProductAsync({
				...data,
				id: product.id,
				status: product.status,
			}),
		);
		toast({
			title: 'Update Product Succeeded',
			description: (
				<pre className="mt-2 w-[340px] rounded-md bg-slate-950 p-4">
					<code className="text-white">{JSON.stringify(data, null, 2)}</code>
				</pre>
			),
		});
	};

	if (isLoading) return <div>Loading...</div>;

	if (isError || !product) return <div>Error...</div>;

	return (
		<ContentSidebarLayout>
			<CreateUpdateProductForm
				defaultValue={{
					id: product.id,
					name: product.name,
					description: product.description,
					price: product.price,
					stockQuantity: product.stockQuantity,
					categoryName: product.category.name,
					imgUrls: product.imgUrls,
					category: product.category,
				}}
				handleSubmitForm={onSubmit}
			/>
		</ContentSidebarLayout>
	);
};

export default ProductDetailPage;
