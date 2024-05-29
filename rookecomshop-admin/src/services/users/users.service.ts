import { PagniatedList } from '@/types/pagniated-list.type';
import { UserDto } from './users.type';
import { QueryDto, defaultQuery } from '@/types/query-dto';
import interceptor from '@/components/hoc/AxiosInterceptor';

const getListUsers = async (queryDto?: QueryDto): Promise<PagniatedList<UserDto>> => {
	const res = await interceptor.get<PagniatedList<UserDto>>('/users', {
		params: queryDto ?? defaultQuery,
	});
	return res.data;
};

const usersService = {
	getListUsers,
};

export default usersService;
