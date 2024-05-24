/* eslint-disable @typescript-eslint/no-explicit-any */
import interceptor from "../interceptor";

const getProductsAsync = async (): Promise<any> => {
  const res = await interceptor.get("/products", {
    params: {
      pageSize: 5,
    },
  });
  return res.data;
};

const productsService = {
  getProductsAsync,
};

export default productsService;
