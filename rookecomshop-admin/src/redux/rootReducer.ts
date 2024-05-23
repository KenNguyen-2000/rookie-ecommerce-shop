import { combineReducers } from "@reduxjs/toolkit";

import authReducer from "./slices/auth.slice";
import productsReducer from "./slices/products.slice";

const rootReducer = combineReducers({
    auth: authReducer,
    products: productsReducer,
});

export default rootReducer;