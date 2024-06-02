import React, { useEffect, useRef } from 'react';
import { useAppDispatch, useAppSelector } from '@/redux/reduxHooks';
import { Navigate, Outlet } from 'react-router-dom';
import authService from '@/services/auth/auth.service';
import { getUserAsync } from '@/redux/thunks/auth.thunk';

export type PrivateRouteProps = {
	children: React.ReactNode;
};

const PrivateRoute: React.FC<PrivateRouteProps> = ({ children }) => {
	const isAuthenticate = authService.isAuthenticated();
  const dispatch = useAppDispatch();
  const { user } = useAppSelector((state) => state.auth);

  useEffect(() => {
    if(isAuthenticate && !user)
      {
          dispatch(getUserAsync())
      }
  },[user])
	return isAuthenticate ? <Outlet /> : <Navigate to="/authentication/login" />;
};

export default PrivateRoute;
