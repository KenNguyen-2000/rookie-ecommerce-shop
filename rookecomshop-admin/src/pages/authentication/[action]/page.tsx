import { useAppDispatch, useAppSelector } from '@/redux/reduxHooks';
import {
	completedLoginAsync,
	completedLogoutAsync,
	loginAsync,
	logoutAsync,
	renewTokenAsync,
} from '@/redux/thunks/auth.thunk';
import { useEffect } from 'react';
import { useNavigate, useParams } from 'react-router-dom';

const OidcConnectPage = () => {
	const navigate = useNavigate();
	const dispatch = useAppDispatch();
	const { action } = useParams<{ action: string }>();
	const { isAuthenticated } = useAppSelector((state) => state.auth);

	useEffect(() => {
		const handleLogin = async () => {
			switch (action) {
				case 'login':
					dispatch(loginAsync());
					break;
				case 'login-callback':
					await dispatch(completedLoginAsync());
					navigate('/dashboard');
					break;
				case 'logout':
					dispatch(logoutAsync());
					break;
				case 'logout-callback':
					dispatch(completedLogoutAsync());
					navigate('/');
					break;
				case 'renew-token':
					dispatch(renewTokenAsync());
					break;
				default:
					break;
			}
		};

		handleLogin();
	}, [dispatch, navigate, action]);

	if (!isAuthenticated) return null;

	return <>Loading</>;
};

export default OidcConnectPage;
