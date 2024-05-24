export type CategoryDto = {
    id: string;
    name: string;
    descriptiong?: string;
    subCategories: CategoryDto[];
};
