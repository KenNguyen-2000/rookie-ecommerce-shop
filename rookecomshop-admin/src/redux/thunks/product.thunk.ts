import productsService from "@/services/products/product.service";
import { createAsyncThunk } from "@reduxjs/toolkit";

export const getProductsAsync = createAsyncThunk(
  "products/getProducts",
  async () => {
    return await productsService.getProductsAsync();
  },
);
