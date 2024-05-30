import { jwtDecode } from 'jwt-decode';

export const isValidToken = (token?: string | null) => {
	if (!token) return false;

	const decoded: any = jwtDecode(token);
	const exp = decoded.exp!;
	const current = new Date().getTime() / 1000;
	return exp > current;
};

export const validateIsAdmin = (token?: string | null) => {
	if (!token) return false;

	const decoded: any = jwtDecode(token);
	const isAdmin = decoded.role.toUpperCase() === 'ADMIN';
	return isAdmin;
};
