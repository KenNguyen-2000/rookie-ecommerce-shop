/* eslint-disable @typescript-eslint/no-explicit-any */
import productsService from '@/services/products/products.service';
import { CreateUpdateProductInputs } from '@/services/products/products.type';
import { QueryDto, defaultQuery } from '@/types/query-dto';
import { createAsyncThunk } from '@reduxjs/toolkit';

export const getProductsAsync = createAsyncThunk(
	'products/getProducts',
	async (queryDto?: QueryDto) => {
		return await productsService.getProductsAsync(queryDto);
	},
);

export const createProductAsync = createAsyncThunk(
	'products/createProduct',
	async (request: CreateUpdateProductInputs) => {
		await productsService.createProductAsync(request);
	},
);

export const updateProductAsync = createAsyncThunk(
	'products/updateProduct',
	async (request: CreateUpdateProductInputs) => {
		await productsService.updateProductAsync(request);
	},
);

export const deleteProductAsync = createAsyncThunk(
	'products/deleteProduct',
	async (productId: string) => {
		await productsService.deleteProductAsync(productId);
	},
);
