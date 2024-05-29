import { z } from 'zod';

import {
	CreateProductScheme,
	CreateUpdateProductScheme,
	UpdateProductScheme,
} from './products.scheme';
import { CategoryDto } from '../categories/categories.type';
import { ProductStatus } from './products.enum';

export type CreateProductInputs = z.infer<typeof CreateProductScheme>;

export type UpdateProductInputs = z.infer<typeof UpdateProductScheme>;
export type CreateUpdateProductInputs = z.infer<typeof CreateUpdateProductScheme> & {
	id?: string;
	imgUrls?: string[];
	category?: CategoryDto;
	status?: number;
};

export type ProductDto = {
	id: string;
	name: string;
	description: string;
	price: number;
	stockQuantity: number;
	category: CategoryDto;
	status: ProductStatus;
	imgUrls: string[];
	createdAt: string;
	updatedAt: string;
};
