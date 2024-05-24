import interceptor from '@/components/hoc/AxiosInterceptor';
import { CategoryDto } from './categories.type';

const getCategoriesAsync = async (): Promise<CategoryDto[]> => {
    const res = await interceptor.get('/categories');
    return res.data;
};

const categoriesService = {
    getCategoriesAsync,
};

export default categoriesService;
