import React, { useEffect, useRef } from 'react';
import { useAppSelector } from '@/redux/reduxHooks';
import { Navigate, Outlet } from 'react-router-dom';
import authService from '@/services/auth/auth.service';

export type PrivateRouteProps = {
	children: React.ReactNode;
};

const PrivateRoute: React.FC<PrivateRouteProps> = ({ children }) => {
	const isAuthenticate = authService.isAuthenticated();

	useEffect(() => {
		const getToken = async () => {
			const user = await authService.getUser();
		};

		getToken();
	}, []);
	return isAuthenticate ? <Outlet /> : <Navigate to="/authentication/login" />;
};

export default PrivateRoute;
