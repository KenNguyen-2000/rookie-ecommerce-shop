import { CategoryDto } from "@/services/categories/categories.type";
import { createSlice } from "@reduxjs/toolkit";
import { getCategoriesAsync } from "../thunks/categories.thunk";

type CategoriesState = {
  categories: CategoryDto[];
  selectedTopCategory: CategoryDto | null;
  isLoading: boolean;
  error: string;
};

const initialState: CategoriesState = {
  categories: [],
  isLoading: false,
  error: "",
  selectedTopCategory: null,
};

const categoriesSlice = createSlice({
  initialState,
  name: "categories",
  reducers: {
    setSelectedTopCategory: (state, action) => {
      console.log("Set");
      state.selectedTopCategory = action.payload;
    },
  },
  extraReducers(builder) {
    builder.addCase(getCategoriesAsync.pending, (state) => {
      state.isLoading = true;
    });
    builder.addCase(getCategoriesAsync.fulfilled, (state, action) => {
      state.isLoading = false;
      state.categories = action.payload;
    });
    builder.addCase(getCategoriesAsync.rejected, (state, action) => {
      state.isLoading = false;
      state.error = action.error.message || "";
    });
  },
});

export const { setSelectedTopCategory } = categoriesSlice.actions;

export default categoriesSlice.reducer;
