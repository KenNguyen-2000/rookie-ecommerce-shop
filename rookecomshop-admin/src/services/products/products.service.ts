/* eslint-disable @typescript-eslint/no-explicit-any */
import interceptor from "@/components/hoc/AxiosInterceptor";
import { CreateProductInputs } from "./products.type";
import { QueryDto, defaultQuery } from "@/types/query-dto";

const getProductsAsync = async (queryDto?: QueryDto): Promise<any> => {
  const res = await interceptor.get("/products", {
    params: queryDto ?? defaultQuery,
  });
  return res.data;
};

const createProductAsync = async (
  request: CreateProductInputs,
): Promise<void> => {
  const createProductForm = new FormData();
  createProductForm.append("name", request.name);
  createProductForm.append("price", request.price.toString());
  createProductForm.append("stock", request.stock.toString());
  createProductForm.append("description", request.description ?? "");
  createProductForm.append("categoryName", request.categoryName.toString());
  createProductForm.append("images", request.images);

  await interceptor.post("/products", createProductForm);
};

const productsService = {
  getProductsAsync,
  createProductAsync,
};

export default productsService;
