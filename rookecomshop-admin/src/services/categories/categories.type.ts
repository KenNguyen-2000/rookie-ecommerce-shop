import { z } from 'zod';
import { CreateCategoryScheme } from './categories.scheme';

export type CategoryDto = {
	id: string;
	name: string;
	description?: string;
	parentId?: string;
	subCategories: CategoryDto[];
	createdAt: string;
	updatedAt: string;
};

export type CreateCategoryDto = z.infer<typeof CreateCategoryScheme>;

export type UpdateCategoryDto = CreateCategoryDto & {
	id: string;
};
