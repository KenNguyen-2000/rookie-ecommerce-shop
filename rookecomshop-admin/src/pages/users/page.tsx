import { File, ListFilter, MoreHorizontal, PlusCircle } from 'lucide-react';

import { Badge } from '@/components/ui/badge';
import { Button } from '@/components/ui/button';
import {
	Card,
	CardContent,
	CardDescription,
	CardFooter,
	CardHeader,
	CardTitle,
} from '@/components/ui/card';
import {
	DropdownMenu,
	DropdownMenuCheckboxItem,
	DropdownMenuContent,
	DropdownMenuItem,
	DropdownMenuLabel,
	DropdownMenuSeparator,
	DropdownMenuTrigger,
} from '@/components/ui/dropdown-menu';
import {
	Table,
	TableBody,
	TableCell,
	TableHead,
	TableHeader,
	TableRow,
} from '@/components/ui/table';
import { Tabs, TabsContent, TabsList, TabsTrigger } from '@/components/ui/tabs';
import { ContentSidebarLayout } from '@/components/layouts';
import { useQuery } from '@tanstack/react-query';
import usersService from '@/services/users/users.service';
import { QueryDto } from '@/types/query-dto';
import { useEffect, useState } from 'react';
import { useSearchParams } from 'react-router-dom';
import { Gender } from '@/services/users/users.enum';
import ReusePagination from '@/components/page/ReusePagination';
import { UserDto } from '@/services/users/users.type';
import UserRow from './components/UserRow';

const UsersPage = () => {
	const [searchParams, setSearchParams] = useSearchParams();
	const [queryDto, setQueryDto] = useState<QueryDto>({
		page: parseInt(searchParams.get('page') ?? '1'),
		pageSize: parseInt(searchParams.get('pageSize') ?? '5'),
		searchTerm: searchParams.get('searchTerm') ?? '',
		sortOrder: searchParams.get('sortOrder') ?? 'asc',
	});
	const { data, isLoading } = useQuery({
		queryKey: ['users'],
		queryFn: () => usersService.getListUsers(queryDto),
	});

	const handleAddParams = (page: number, pageSize?: number) => {
		setQueryDto({ ...queryDto, page, pageSize: pageSize ?? queryDto.pageSize });
	};

	useEffect(() => {
		function updateQueryParams(queryDto: QueryDto) {
			const newParams = new URLSearchParams(searchParams);
			newParams.set('page', queryDto.page.toString());
			newParams.set('pageSize', queryDto.pageSize.toString());
			setSearchParams(newParams);
		}

		updateQueryParams(queryDto);
	}, [queryDto]);

	return (
		<ContentSidebarLayout>
			<main className="grid flex-1 items-start gap-4 p-4 sm:px-6 sm:py-0 md:gap-8">
				<Tabs defaultValue="all">
					<TabsContent value="all">
						<Card x-chunk="dashboard-06-chunk-0">
							<CardHeader>
								<CardTitle>Users</CardTitle>
								<CardDescription>
									Manage your products and view their sales performance.
								</CardDescription>
							</CardHeader>
							<CardContent>
								<Table>
									<TableHeader>
										<TableRow>
											<TableHead className="hidden w-[100px] sm:table-cell">
												<span className="sr-only">Image</span>
											</TableHead>
											<TableHead>Name</TableHead>
											<TableHead>Address</TableHead>
											<TableHead className="hidden md:table-cell">
												Gender
											</TableHead>
											<TableHead className="hidden md:table-cell">
												Dob
											</TableHead>
											
											<TableHead className="hidden md:table-cell">
												Email
											</TableHead>
											<TableHead className="hidden md:table-cell">
												Phone Number
											</TableHead>
											<TableHead>
												<span className="sr-only">Actions</span>
											</TableHead>
										</TableRow>
									</TableHeader>
									<TableBody>
										{data?.items?.map((user) => (
											<UserRow key={user.id} user={user} />
										))}
									</TableBody>
								</Table>
							</CardContent>
							<CardFooter>
								<div className="w-full flex items-center">
									<div className="text-xs text-muted-foreground">
										Showing <strong>1-10</strong> of <strong>32</strong>{' '}
										products
									</div>
									<div className="ml-auto">
										{data && (
											<ReusePagination<UserDto>
												data={data}
												queryDto={queryDto}
												handleChangePage={handleAddParams}
											/>
										)}
									</div>
								</div>
							</CardFooter>
						</Card>
					</TabsContent>
				</Tabs>
			</main>
		</ContentSidebarLayout>
	);
};

export default UsersPage;
