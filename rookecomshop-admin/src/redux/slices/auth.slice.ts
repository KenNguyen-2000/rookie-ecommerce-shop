import { createSlice } from "@reduxjs/toolkit";
import { User } from "oidc-client";
import { completedLoginAsync } from "../thunks/auth.thunk";

type AuthSliceState = {
    isAuthenticated: boolean;
    user : User | null;
    isLoading: boolean;
    error: string | null;
};

const initialState: AuthSliceState = {
    isAuthenticated: false,
    user: null,
    isLoading: false,
    error: null
};

const authSlice = createSlice({
    initialState,
    name: "auth",
    reducers: {
        setUser: (state, action) => {
            state.user = action.payload;
        }
    },
    extraReducers(builder) {
       builder
        .addCase(completedLoginAsync.pending, (state) => {
                state.isLoading = true;
        }).addCase(completedLoginAsync.fulfilled, (state, action) => {
                state = {
                    ...state,
                    isAuthenticated: true,
                    user: action.payload,
                    isLoading: false,
                }
        })
        .addCase(completedLoginAsync.rejected, (state) => {
                state.isLoading = false;
                state.error = "Failed to login";
        });
    },
});

export const { setUser } = authSlice.actions;
export default authSlice.reducer;