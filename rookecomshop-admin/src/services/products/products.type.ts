import { z } from "zod";

import { CreateProductScheme } from "./products.scheme";

export type CreateProductInputs = z.infer<typeof CreateProductScheme>;
