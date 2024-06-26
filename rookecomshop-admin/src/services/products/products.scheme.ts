import { z } from 'zod';
import { ProductStatus } from './products.enum';

const ACCEPTED_IMAGE_TYPES = ['image/jpeg', 'image/jpg', 'image/png', 'image/webp'];
const fileSchema = z
	.instanceof(File)
	.refine((file) => file.size < 700000, {
		message: 'Your image must be less than 7MB.',
	})
	.refine(
		(file) => ACCEPTED_IMAGE_TYPES.includes(file.type),
		'Only these types are allowed .jpg, .jpeg, .png and .webp',
	)
	.optional();

export const CreateProductScheme = z.object({
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
			message: 'Name must be at most 200 characters long',
		})
		.optional(),
	price: z.coerce.number({
		message: 'Price is required',
	}),
	stockQuantity: z.coerce.number({
		message: 'Price is required',
	}),
	categoryName: z.string({
		message: 'Category is required',
	}),
	images: z
		.instanceof(FileList)
		.refine((file) => file.length > 3, {
			message: 'Please select at least 3 images.',
		})
		.refine((fileList) => {
			return Array.from(fileList).every((file) => fileSchema.safeParse(file).success);
		})
		.optional(),
});

export const UpdateProductScheme = z.object({
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
	description: z.string().optional(),
	price: z.coerce.number({
		message: 'Price is required',
	}),
	stockQuantity: z.coerce.number({
		message: 'Price is required',
	}),
	categoryName: z.string({
		message: 'Category is required',
	}),
	subCategoryName: z.string().optional(),
	images: z
		.instanceof(FileList)
		.refine((file) => file.length >= 3, {
			message: 'Please select at least 3 images.',
		})
		.refine((fileList) => {
			return Array.from(fileList).every((file) => fileSchema.safeParse(file).success);
		})
		.optional(),
	status: z.nativeEnum(ProductStatus).optional(),
});

export const CreateUpdateProductScheme = CreateProductScheme.merge(UpdateProductScheme);
