import categoriesService from '@/services/categories/categories.service';
import { createAsyncThunk } from '@reduxjs/toolkit';

export const getCategoriesAsync = createAsyncThunk(
    'categories/getCategories',
    async () => {
        return await categoriesService.getCategoriesAsync();
    },
);
