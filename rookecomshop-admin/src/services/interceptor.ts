import axios, {
    AxiosError,
    InternalAxiosRequestConfig,
    AxiosResponse,
} from "axios";
import Cookies from "js-cookie";

const interceptor = axios.create({
    baseURL: process.env.NEXT_PUBLIC_SERVER_API,
    timeout: 10000,
});

// eslint-disable-next-line @typescript-eslint/no-explicit-any
interceptor.interceptors.request.use((req: InternalAxiosRequestConfig<any>) => {
    const token = Cookies.get("ecommer-token");
    if (token && req.headers) req.headers.Authorization = `Bearer ${token}`;

    return req;
});

interceptor.interceptors.response.use(
    (res: AxiosResponse) => {
        const { code } = res.data;
        if (code === 401) {
            throw new Error("Unauthorized");
        }

        return res;
    },
    (error: AxiosError) => {
        if (error.response?.status === 401) {
            Cookies.remove("ecommer-token");
        }
        if (error.response?.status === 403) {
            return Promise.reject(error.response);
        }
        if (error.response) {
            return error.response;
        } else {
            return Promise.reject(error);
        }
    }
);

export default interceptor;