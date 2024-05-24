/* eslint-disable @typescript-eslint/no-explicit-any */
import { createSlice } from "@reduxjs/toolkit";
import { getProductsAsync } from "../thunks/product.thunk";

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
  name: "products",
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
  },
});

export const { setProducts } = productSlice.actions;
export default productSlice.reducer;
