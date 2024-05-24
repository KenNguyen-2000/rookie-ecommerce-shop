export type QueryDto = {
    searchTerm?: string;
    sortOrder?: string;
    sortColumn?: string;
    page: number;
    pageSize: number;
};

export const defaultQuery: QueryDto = {
    page: 1,
    pageSize: 10,
};
