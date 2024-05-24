/* eslint-disable @typescript-eslint/no-explicit-any */
import interceptor from '@/components/hoc/AxiosInterceptor';
import { CreateProductInputs, ProductDto } from './products.type';
import { QueryDto, defaultQuery } from '@/types/query-dto';
import { PagniatedList } from '@/types/pagniated-list.type';

const getProductsAsync = async (
    queryDto?: QueryDto,
): Promise<PagniatedList<ProductDto>> => {
    const res = await interceptor.get<PagniatedList<ProductDto>>('/products', {
        params: queryDto ?? defaultQuery,
    });
    return res.data;
};

const createProductAsync = async (
    request: CreateProductInputs,
): Promise<void> => {
    const createProductForm = new FormData();
    createProductForm.append('name', request.name);
    createProductForm.append('price', request.price.toString());
    createProductForm.append('stock', request.stock.toString());
    createProductForm.append('description', request.description ?? '');
    createProductForm.append('categoryName', request.categoryName.toString());
    createProductForm.append('images', request.images);

    await interceptor.post('/products', createProductForm);
};

const deleteProductAsync = async (productId: number) => {
    await interceptor.delete(`/products/${productId}`);
};

const productsService = {
    getProductsAsync,
    createProductAsync,
    deleteProductAsync,
};

export default productsService;
