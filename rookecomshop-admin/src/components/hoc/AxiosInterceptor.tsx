import { TOKEN_STRING } from '@/lib/constants/cookies.constant';
import { useAppDispatch } from '@/redux/reduxHooks';
import { renewTokenAsync } from '@/redux/thunks/auth.thunk';
import axios, { AxiosError, AxiosResponse, InternalAxiosRequestConfig } from 'axios';
import Cookies from 'js-cookie';
import React, { useEffect } from 'react';
import { toast } from 'react-toastify';

const UNAUTHORIZED = 401;
const interceptor = axios.create({
	baseURL: import.meta.env.VITE_API_URL,
	timeout: 10000,
	withCredentials: true,
});

type AxiosInterceptorProps = {
	children: React.ReactNode;
};

const AxiosInterceptor: React.FC<AxiosInterceptorProps> = ({ children }) => {
	const dispatch = useAppDispatch();

	useEffect(() => {
		// eslint-disable-next-line @typescript-eslint/no-explicit-any
		interceptor.interceptors.request.use((req: InternalAxiosRequestConfig<unknown>) => {
			const token = Cookies.get(TOKEN_STRING);
			if (token && req.headers) req.headers.Authorization = `Bearer ${token}`;

			return req;
		});

		interceptor.interceptors.response.use(
			(res: AxiosResponse) => {
				const { code } = res.data;
				if (code === UNAUTHORIZED) {
					throw new Error('Unauthorized');
				}

				return res;
			},
			(error: AxiosError<any, any>) => {
				if (error.response?.status === UNAUTHORIZED) {
					Cookies.remove(TOKEN_STRING);
					dispatch(renewTokenAsync());
				}
				if (error.response?.status === 403) {
					return Promise.reject(error.response);
				}
				console.log(error);
				
				if (error.response) {
					if(error.response.data.errors)
						{
							Object.keys(error.response.data.errors).forEach((key) => {
								toast.error(error.response!.data.errors[key][0]);
							});
						}else{

							toast.error(error.response.data.detail ?? 'Something went wrong');
						}
					return error.response;
				} else {
					return Promise.reject(error);
				}
			},
		);
	}, [dispatch]);

	return children;
};

export default interceptor;

export { AxiosInterceptor };
