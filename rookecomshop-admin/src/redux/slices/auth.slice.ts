import { createSlice } from '@reduxjs/toolkit';
import { Profile } from 'oidc-client';
import {
    completedLoginAsync,
    getUserAsync,
    renewTokenAsync,
} from '../thunks/auth.thunk';
import Cookies from 'js-cookie';
import {
    COOKIES_CONFIGS,
    TOKEN_STRING,
} from '@/lib/constants/cookies.constant';

type AuthSliceState = {
    isAuthenticated: boolean;
    user: Profile | null;
    isLoading: boolean;
    error: string | null;
};

const initialState: AuthSliceState = {
    isAuthenticated: false,
    user: null,
    isLoading: false,
    error: null,
};

const authSlice = createSlice({
    initialState,
    name: 'auth',
    reducers: {
        setUser: (state, action) => {
            state.user = action.payload;
        },
    },
    extraReducers(builder) {
        builder
            .addCase(completedLoginAsync.pending, (state) => {
                state.isLoading = true;
            })
            .addCase(completedLoginAsync.fulfilled, (state, action) => {
                console.log(action.payload);
                state.user = action.payload?.profile ?? null;
                state.isAuthenticated = true;
                state.isLoading = false;
                if (action.payload)
                    Cookies.set(
                        TOKEN_STRING,
                        action.payload?.access_token,
                        COOKIES_CONFIGS,
                    );
            })
            .addCase(completedLoginAsync.rejected, (state) => {
                state.isLoading = false;
                state.error = 'Failed to login';
            });
        builder
            .addCase(getUserAsync.pending, (state) => {
                state.isLoading = true;
            })
            .addCase(getUserAsync.fulfilled, (state, action) => {
                state.user = action.payload?.profile ?? null;
                state.isAuthenticated = true;
                state.isLoading = false;
                if (action.payload)
                    Cookies.set(
                        TOKEN_STRING,
                        action.payload?.access_token,
                        COOKIES_CONFIGS,
                    );
            })
            .addCase(getUserAsync.rejected, (state, action) => {
                console.log(action.payload);
                state.isLoading = false;
                state.error = 'Failed to login';
            });
        builder
            .addCase(renewTokenAsync.pending, (state) => {
                state.isLoading = true;
            })
            .addCase(renewTokenAsync.fulfilled, (state, action) => {
                state.user = action.payload?.profile ?? null;
                state.isAuthenticated = true;
                state.isLoading = false;
                if (action.payload)
                    Cookies.set(TOKEN_STRING, action.payload?.access_token);
            })
            .addCase(renewTokenAsync.rejected, (state, action) => {
                console.log(action.payload);
                state.isLoading = false;
                state.error = 'Failed to login';
            });
    },
});

export const { setUser } = authSlice.actions;
export default authSlice.reducer;
