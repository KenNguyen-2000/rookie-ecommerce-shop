import authService from '@/services/auth/auth.service';
import { createAsyncThunk } from '@reduxjs/toolkit';

export const loginAsync = createAsyncThunk('auth/login', async () => {
    await authService.loginAsync();
});
export const completedLoginAsync = createAsyncThunk(
    'auth/completed-login',
    async () => {
        await authService.completeLoginAsync(window.location.href);
        const user = await authService.getUserAsync();
        return user;
    },
);

export const getUserAsync = createAsyncThunk('auth/get-user', async () => {
    return await authService.getUserAsync();
});

export const logoutAsync = createAsyncThunk('auth/logout', async () => {
    await authService.logoutAsync();
});

export const completedLogoutAsync = createAsyncThunk(
    'auth/completed-logout',
    async () => {
        await authService.logoutAsync();
    },
);

export const renewTokenAsync = createAsyncThunk(
    'auth/renew-token',
    async () => {
        return await authService.renewTokenAsync();
    },
);
