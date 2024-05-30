import interceptor from '@/components/hoc/AxiosInterceptor';
import { CategoryDto, CreateCategoryDto, UpdateCategoryDto } from './categories.type';

const getByNameAsync = async (name: string): Promise<CategoryDto> => {
	const res = await interceptor.get<CategoryDto>(`/categories/${name}`);
	return res.data;
};
const getCategoriesAsync = async (): Promise<CategoryDto[]> => {
	const res = await interceptor.get('/categories');
	return res.data;
};
const createCategoryAsync = async (request: CreateCategoryDto): Promise<void> => {
	await interceptor.post('/categories', request);
};

const updateCategoryAsync = async (request: UpdateCategoryDto): Promise<void> => {
	await interceptor.put(`/categories/${request.id}`, request);
};


const deleteCategoryAsync = async (id: string): Promise<void> => {
	await interceptor.delete(`/categories/${id}`);
};

const categoriesService = {
	getCategoriesAsync,
	createCategoryAsync,
	updateCategoryAsync,
	getByNameAsync,
	deleteCategoryAsync
};

export default categoriesService;
