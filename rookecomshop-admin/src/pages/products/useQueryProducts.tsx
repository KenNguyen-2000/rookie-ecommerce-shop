import productsService from '@/services/products/products.service';
import { ProductQueryDto } from '@/types/query-dto';
import { useQuery } from '@tanstack/react-query';
import React, { useEffect, useState } from 'react'
import { useSearchParams } from 'react-router-dom';

export const useFetchProducts =(queryDto: ProductQueryDto) => useQuery({
    queryKey: ['products', queryDto],
    queryFn: () => productsService.getProductsAsync(queryDto),
});
const useQueryProducts = () => {
    const [searchParams, setSearchParams] = useSearchParams();
    const [queryDto, setQueryDto] = useState<ProductQueryDto>({
		page: parseInt(searchParams.get('page') ?? '1'),
		pageSize: parseInt(searchParams.get('pageSize') ?? '5'),
		searchTerm: searchParams.get('searchTerm') ?? '',
		sortOrder: searchParams.get('sortOrder') ?? 'asc',
		sortColumn: searchParams.get('sortColumn') ?? '',
		categoryName: searchParams.get('categoryName') ?? null,
		status: null,
	});
    

    const handlePaginate = (page: number, pageSize?: number) => {
		const newParams = new URLSearchParams(searchParams);
		newParams.set('page', page.toString());
		newParams.set('pageSize', (pageSize ?? 5).toString());
		setSearchParams(newParams);
	};

	const handleSortQuery = (sortColumn: string) => {
		const newParams = new URLSearchParams(searchParams);
		newParams.set('sortOrder', queryDto.sortOrder === 'asc' ? 'desc' : 'asc');
		newParams.set('sortColumn', sortColumn);
		setSearchParams(newParams);
	};

	const handleCategoryQuery = (categoryName: string) => {
		const newParams = new URLSearchParams(searchParams);
		newParams.set('categoryName', categoryName);
		setSearchParams(newParams);
	};

    useEffect(() => {
		setQueryDto({
			page: parseInt(searchParams.get('page') ?? '1'),
			pageSize: parseInt(searchParams.get('pageSize') ?? '5'),
			searchTerm: searchParams.get('searchTerm') ?? '',
			sortOrder: searchParams.get('sortOrder') ?? 'asc',
			sortColumn: searchParams.get('sortColumn') ?? '',
			categoryName: searchParams.get('categoryName') ?? null,
			status: null,
		});
	}, [searchParams]);

  return {queryDto, handleCategoryQuery, handlePaginate, handleSortQuery}
}

export default useQueryProducts