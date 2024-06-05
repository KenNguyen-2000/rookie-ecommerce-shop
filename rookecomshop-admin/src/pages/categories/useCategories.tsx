import categoriesService from '@/services/categories/categories.service';
import { CreateCategoryDto } from '@/services/categories/categories.type';
import {  useQuery, useQueryClient } from '@tanstack/react-query';
import { toast } from 'react-toastify';

export const useFetchListCategory = () => useQuery({
    queryKey: ['categories'],
    queryFn: () => categoriesService.getCategoriesAsync(),
    select(data) {
        return data.filter((category) => !category.parentId);
    },
});

export const useFetchCategoryById = (categoryId: string) =>  useQuery({
    queryKey: ['categories', categoryId],
    queryFn: () => categoriesService.getByNameAsync(categoryId!),
});

const useCategories = () => {
    const queryClient = useQueryClient();
    
    const deleteMutate = async (categoryId: string) =>
    {
        await categoriesService.deleteCategoryAsync(categoryId);
		await queryClient.invalidateQueries({ queryKey: ['categories'] });
        toast.success("Delete category success!")
    }

    const updateCategory = async (categoryId: string,data: CreateCategoryDto) => {
         await categoriesService.updateCategoryAsync({
			...data,
			id: categoryId,
		});
        await queryClient.invalidateQueries({ queryKey: ['categories'] });
        toast.success("Update category success!")

    }

    const createCategory = async (data: CreateCategoryDto) => {
         await categoriesService.createCategoryAsync(data);
         await queryClient.invalidateQueries({ queryKey: ['categories'] });
        toast.success("Create category success!")

    }


  return {  deleteMutate,updateCategory, createCategory }
}

export default useCategories