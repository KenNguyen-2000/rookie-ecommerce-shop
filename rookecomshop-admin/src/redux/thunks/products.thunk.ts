import productsService from "@/services/products/products.service";
import { CreateProductInputs } from "@/services/products/products.type";
import { createAsyncThunk } from "@reduxjs/toolkit";

export const getProductsAsync = createAsyncThunk(
  "products/getProducts",
  async () => {
    return await productsService.getProductsAsync();
  },
);

export const createProductAsync = createAsyncThunk(
  "categories/createCategory",
  async (request: CreateProductInputs) => {
    await productsService.createProductAsync(request);
  },
);
