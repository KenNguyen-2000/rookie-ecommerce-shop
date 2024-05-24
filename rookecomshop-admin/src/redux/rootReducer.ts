import { combineReducers } from '@reduxjs/toolkit';

import authReducer from './slices/auth.slice';
import productsReducer from './slices/products.slice';
import categoriesReducer from './slices/categories.slice';

const rootReducer = combineReducers({
    auth: authReducer,
    products: productsReducer,
    categories: categoriesReducer,
});

export default rootReducer;
