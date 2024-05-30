import { jwtDecode } from 'jwt-decode';
import { COOKIES_CONFIGS } from './../constants/cookies.constant';
import Cookies from 'js-cookie';

export const saveTokenToCookies = (key: string, token: string) => {
	const decoded = jwtDecode(token);
	const exp = decoded.exp!;
	Cookies.set(key, token, {
		...COOKIES_CONFIGS,
		expires: new Date(exp * 1000),
	});
};
