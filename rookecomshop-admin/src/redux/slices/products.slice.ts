/* eslint-disable @typescript-eslint/no-explicit-any */
import { createSlice } from '@reduxjs/toolkit';
import { deleteProductAsync, getProductsAsync } from '../thunks/products.thunk';
import { ProductDto } from '@/services/products/products.type';
import { PagniatedList } from '@/types/pagniated-list.type';

type ProductState = PagniatedList<ProductDto> & {
	isLoading: boolean;
};

const initialState: ProductState = {
	isLoading: false,
	hasNextPage: false,
	hasPreviousPage: false,
	items: [],
	page: 1,
	pageSize: 5,
	totalCount: 0,
};

const productSlice = createSlice({
	initialState,
	name: 'products',
	reducers: {
		setProducts(state, action) {
			state.items = action.payload;
		},
	},
	extraReducers(builder) {
		builder
			.addCase(getProductsAsync.pending, (state) => {
				state.isLoading = true;
			})
			.addCase(getProductsAsync.fulfilled, (state, action) => {
				state.isLoading = false;
				state = { ...state, ...action.payload };
			})
			.addCase(getProductsAsync.rejected, (state) => {
				state.isLoading = false;
			});

		builder
			.addCase(deleteProductAsync.pending, (state) => {
				state.isLoading = true;
			})
			.addCase(deleteProductAsync.fulfilled, (state) => {
				state.isLoading = false;
			})
			.addCase(deleteProductAsync.rejected, (state) => {
				state.isLoading = false;
			});
	},
});

export const { setProducts } = productSlice.actions;
export default productSlice.reducer;
