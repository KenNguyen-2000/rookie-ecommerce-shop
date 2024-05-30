import { TOKEN_STRING } from '@/lib/constants/cookies.constant';
import { useAppDispatch, useAppSelector } from '@/redux/reduxHooks';
import { getUserAsync, logoutAsync } from '@/redux/thunks/auth.thunk';
import Cookies from 'js-cookie';
import { useEffect } from 'react';
import { Outlet, useNavigate } from 'react-router-dom';
import { jwtDecode } from 'jwt-decode';
import { isValidToken, validateIsAdmin } from '@/lib/helpers/validate-token';

const PrivateRoute = () => {
	const navigate = useNavigate();
	const token = Cookies.get(TOKEN_STRING);
	const dispatch = useAppDispatch();
	useEffect(() => {
		
			if (!token) {
				navigate('/');
			} else {
				if (!isValidToken(token) || !validateIsAdmin(token)){
					dispatch(logoutAsync());
				} else dispatch(getUserAsync());
			}
	}, [navigate, dispatch, token]);
	return token ? <Outlet /> : null;
};

export default PrivateRoute;
