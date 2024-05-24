import { z } from 'zod';

import { CreateProductScheme } from './products.scheme';
import { CategoryDto } from '../categories/categories.type';

export type CreateProductInputs = z.infer<typeof CreateProductScheme>;

export type ProductDto = {
    id: number;
    name: string;
    description: string;
    price: number;
    stockQuantity: string;
    category: CategoryDto;
    imgUrls: string[];
};
