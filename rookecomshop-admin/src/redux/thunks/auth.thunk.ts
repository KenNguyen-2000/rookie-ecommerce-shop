import { TOKEN_STRING } from '@/lib/constants/cookies.constant';
import authService from '@/services/auth/auth.service';
import { createAsyncThunk } from '@reduxjs/toolkit';
import Cookies from 'js-cookie';
import { jwtDecode } from 'jwt-decode';

export const loginAsync = createAsyncThunk('auth/login', async () => {
	await authService.login();
});
export const completedLoginAsync = createAsyncThunk('auth/completed-login', async () => {
	await authService.completedLogin(window.location.href);
	const user = await authService.getUser();
	return user;
});

export const getUserAsync = createAsyncThunk('auth/get-user', async () => {
	return await authService.getUser();
});

export const logoutAsync = createAsyncThunk('auth/logout', async () => {
	await authService.logout();
});

export const completedLogoutAsync = createAsyncThunk('auth/completed-logout', async () => {
	Cookies.remove(TOKEN_STRING);
	await authService.completeLogoutAsync('/');
});

export const renewTokenAsync = createAsyncThunk('auth/renew-token', async () => {
	return await authService.renewToken();
});
