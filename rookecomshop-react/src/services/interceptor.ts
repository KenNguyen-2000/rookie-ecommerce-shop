import axios, {
  AxiosError,
  InternalAxiosRequestConfig,
  AxiosResponse,
} from "axios";
import { toast } from "react-toastify";
import Cookies from "js-cookie";

import { decryptData } from "@/helpers/authHelpers";

const interceptor = axios.create({
  baseURL: process.env.NEXT_PUBLIC_SERVER_API,
});

interceptor.interceptors.request.use((req: InternalAxiosRequestConfig<any>) => {
  const token = decryptData("rookecomshop-token");
  if (token && req.headers) req.headers.Authorization = `Bearer ${token}`;

  return req;
});

interceptor.interceptors.response.use(
  (res: AxiosResponse) => {
    const { code, auto } = res.data;
    if (code === 401) {
      throw new Error("Unauthorized");
    }

    return res;
  },
  (error: AxiosError) => {
    if (error.response?.status === 401) {
      Cookies.remove("rookecomshop-token");
    }
    if (error.response?.status === 403) {
      return Promise.reject(error.response);
    }
    if (error.response) {
      return error.response;
    } else {
      return Promise.reject(error);
    }
  },
);

export default interceptor;
