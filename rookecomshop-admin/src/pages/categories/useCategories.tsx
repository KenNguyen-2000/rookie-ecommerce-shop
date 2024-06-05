import categoriesService from '@/services/categories/categories.service';
import { CreateCategoryDto } from '@/services/categories/categories.type';
import { useMutation, useQuery, useQueryClient } from '@tanstack/react-query';
import React from 'react'
import { toast } from 'react-toastify';

const useCategories = () => {
    const queryClient = useQueryClient();
    const useFetchListCategory = ()=> useQuery({
		queryKey: ['categories'],
		queryFn: () => categoriesService.getCategoriesAsync(),
		select(data) {
			return data.filter((category) => !category.parentId);
		},
	});
    const useFetchById = (categoryId: string) =>  useQuery({
		queryKey: ['categories', categoryId],
		queryFn: () => categoriesService.getByNameAsync(categoryId!),
	});


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


  return {useFetchListCategory, useFetchById, deleteMutate,updateCategory, createCategory }
}

export default useCategories