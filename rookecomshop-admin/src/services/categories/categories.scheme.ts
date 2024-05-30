import { z } from 'zod';

export const CreateCategoryScheme = z.object({
	name: z
		.string({
			message: 'Name is required',
		})
		.min(3, {
			message: 'Name must be at least 3 characters long',
		})
		.max(50, {
			message: 'Name must be at most 50 characters long',
		}),
	description: z
		.string()
		.max(200, {
			message: 'Description must be at most 200 characters long',
		})
		.optional(),
	parentId: z.string().optional(),
});
