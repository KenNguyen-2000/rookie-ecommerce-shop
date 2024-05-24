/* eslint-disable @typescript-eslint/no-explicit-any */
import { createSlice } from '@reduxjs/toolkit';
import { deleteProductAsync, getProductsAsync } from '../thunks/products.thunk';

type ProductState = {
    products: any[];
    isLoading: boolean;
};

const initialState: ProductState = {
    products: [],
    isLoading: false,
};

const productSlice = createSlice({
    initialState,
    name: 'products',
    reducers: {
        setProducts(state, action) {
            state.products = action.payload;
        },
    },
    extraReducers(builder) {
        builder
            .addCase(getProductsAsync.pending, (state) => {
                state.isLoading = true;
            })
            .addCase(getProductsAsync.fulfilled, (state, action) => {
                state.isLoading = false;
                state.products = action.payload.items;
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
