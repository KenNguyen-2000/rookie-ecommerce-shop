/* eslint-disable @typescript-eslint/no-explicit-any */
import interceptor from '@/components/hoc/AxiosInterceptor';
import { CreateUpdateProductInputs, ProductDto } from './products.type';
import { ProductQueryDto, defaultQuery } from '@/types/query-dto';
import { PagniatedList } from '@/types/pagniated-list.type';

const getProductsAsync = async (queryDto?: ProductQueryDto): Promise<PagniatedList<ProductDto>> => {
	const res = await interceptor.get<PagniatedList<ProductDto>>('/products', {
		params: queryDto ?? defaultQuery,
	});
	return res.data;
};

const getByIdAsync = async (productId: string): Promise<ProductDto> => {
	const res = await interceptor.get<ProductDto>(`/products/${productId}`);
	return res.data;
};

const createProductAsync = async (request: CreateUpdateProductInputs): Promise<void> => {
	const createProductForm = new FormData();
	createProductForm.append('name', request.name);
	createProductForm.append('price', request.price.toString());
	createProductForm.append('stockQuantity', request.stockQuantity.toString());
	createProductForm.append('description', request.description ?? '');
	createProductForm.append('categoryName', request.subCategoryName ?? request.categoryName);
	if (request.images) {
		Array.from(request.images).forEach((image) => {
			createProductForm.append('images', image);
		});
	}

	await interceptor.post('/products', createProductForm);
};

const updateProductAsync = async (request: CreateUpdateProductInputs): Promise<void> => {
	console.log(request);
	const updateProductForm = new FormData();
	updateProductForm.append('name', request.name);
	updateProductForm.append('price', request.price.toString());
	updateProductForm.append('stockQuantity', request.stockQuantity.toString());
	updateProductForm.append('description', request.description ?? '');
	updateProductForm.append('categoryName', request.categoryName.toString());
	updateProductForm.append('status', request.status?.toString() ?? '');
	if (request.images) {
		Array.from(request.images).forEach((image) => {
			updateProductForm.append('images', image);
		});
	}

	await interceptor.put(`/products/${request.id}`, updateProductForm);
};

const deleteProductAsync = async (productId: string) => {
	await interceptor.delete(`/products/${productId}`);
};

const productsService = {
	getProductsAsync,
	createProductAsync,
	deleteProductAsync,
	getByIdAsync,
	updateProductAsync,
};

export default productsService;
