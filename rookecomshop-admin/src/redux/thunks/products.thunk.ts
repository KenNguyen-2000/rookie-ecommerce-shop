/* eslint-disable @typescript-eslint/no-explicit-any */
import productsService from '@/services/products/products.service';
import { CreateProductInputs } from '@/services/products/products.type';
import { createAsyncThunk } from '@reduxjs/toolkit';

export const getProductsAsync = createAsyncThunk(
    'products/getProducts',
    async () => {
        return await productsService.getProductsAsync();
    },
);

export const createProductAsync = createAsyncThunk(
    'products/createProduct',
    async (request: CreateProductInputs) => {
        await productsService.createProductAsync(request);
    },
);

export const deleteProductAsync = createAsyncThunk(
    'products/deleteProduct',
    async (productId: number) => {
        await productsService.deleteProductAsync(productId);
    },
);
