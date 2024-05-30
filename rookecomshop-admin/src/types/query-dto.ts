import { ProductStatus } from '@/services/products/products.enum';

export type QueryDto = {
	searchTerm?: string;
	sortOrder?: string;
	sortColumn?: string;
	page: number;
	pageSize: number;
};

export type ProductQueryDto = QueryDto & {
	categoryName: string | null;
	status: ProductStatus | null;
};

export const defaultQuery: QueryDto = {
	page: 1,
	pageSize: 10,
};
