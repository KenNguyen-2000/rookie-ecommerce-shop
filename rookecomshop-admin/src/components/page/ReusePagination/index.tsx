import {
	Pagination,
	PaginationContent,
	PaginationEllipsis,
	PaginationItem,
	PaginationLink,
	PaginationNext,
	PaginationPrevious,
} from '@/components/ui/pagination';
import { PagniatedList } from '@/types/pagniated-list.type';
import { QueryDto } from '@/types/query-dto';
import { useMemo } from 'react';

type ReusePagination<T> = {
	data: PagniatedList<T>;
	queryDto: QueryDto;
	handleChangePage: (page: number, pageSize?: number) => void;
};

function ReusePagination<T>({ data, queryDto, handleChangePage }: ReusePagination<T>) {
	const totalPages = useMemo(
		() => Math.ceil((data?.totalCount ?? 0) / queryDto.pageSize),
		[data, queryDto],
	);
	const currentPage = queryDto.page;
	const MAX_TO_SHOW = 3;
	let startPage: number, endPage: number;

	if (totalPages <= MAX_TO_SHOW) {
		// Show all pages if total pages is less than or equal to maxPagesToShow
		startPage = 1;
		endPage = totalPages;
	} else {
		// Calculate start and end page
		if (currentPage <= Math.ceil(MAX_TO_SHOW / 2)) {
			startPage = 1;
			endPage = MAX_TO_SHOW;
		} else if (currentPage + Math.floor(MAX_TO_SHOW / 2) >= totalPages) {
			startPage = totalPages - MAX_TO_SHOW + 1;
			endPage = totalPages;
		} else {
			startPage = currentPage - Math.floor(MAX_TO_SHOW / 2);
			endPage = currentPage + Math.floor(MAX_TO_SHOW / 2);
		}
	}

	return (
		<Pagination>
			<PaginationContent>
				{data?.hasPreviousPage && (
					<PaginationItem className="cursor-pointer">
						<PaginationPrevious onClick={() => handleChangePage(queryDto.page - 1)} />
					</PaginationItem>
				)}

				{startPage > 1 && (
					<>
						<PaginationItem className="cursor-pointer">
							<PaginationLink onClick={handleChangePage.bind(null, 1, undefined)}>
								1
							</PaginationLink>
						</PaginationItem>
						{startPage > 2 && (
							<PaginationItem className="cursor-pointer">
								<PaginationEllipsis />
							</PaginationItem>
						)}
					</>
				)}
				{new Array(endPage - startPage + 1).fill(0).map((_, index) => (
					<PaginationItem key={startPage + index} className="cursor-pointer">
						<PaginationLink
							onClick={handleChangePage.bind(null, startPage + index, undefined)}
							isActive={queryDto.page === startPage + index}
						>
							{startPage + index}
						</PaginationLink>
					</PaginationItem>
				))}
				{endPage < totalPages && (
					<>
						{endPage < totalPages - 1 && (
							<PaginationItem className="cursor-pointer">
								<PaginationEllipsis />
							</PaginationItem>
						)}
						<PaginationItem className="cursor-pointer">
							<PaginationLink
								onClick={handleChangePage.bind(null, totalPages, undefined)}
							>
								{totalPages}
							</PaginationLink>
						</PaginationItem>
					</>
				)}
				{data?.hasNextPage && (
					<PaginationItem className="cursor-pointer">
						<PaginationNext onClick={() => handleChangePage(queryDto.page + 1)} />
					</PaginationItem>
				)}
			</PaginationContent>
		</Pagination>
	);
}

export default ReusePagination;
