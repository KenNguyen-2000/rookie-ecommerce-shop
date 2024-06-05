import { Badge } from '@/components/ui/badge';
import { Button } from '@/components/ui/button';
import {
	DropdownMenu,
	DropdownMenuContent,
	DropdownMenuItem,
	DropdownMenuLabel,
	DropdownMenuTrigger,
} from '@/components/ui/dropdown-menu';
import { TableCell, TableRow } from '@/components/ui/table';
import { Gender } from '@/services/users/users.enum';
import { UserDto } from '@/services/users/users.type';
import { MoreHorizontal } from 'lucide-react';
import React from 'react';

type UserRowProps = {
	user: UserDto;
};
const UserRow: React.FC<UserRowProps> = ({ user }) => {
	return (
		<TableRow>
			<TableCell className="hidden sm:table-cell">
				<img
					alt="Avatar"
					className="aspect-square rounded-md object-cover"
					height="64"
					src="/placeholder.svg"
					width="64"
				/>
			</TableCell>
			<TableCell className="font-medium">
				{user.firstName} {user.lastName}
			</TableCell>

			<TableCell className="hidden md:table-cell">{user.address ?? 'Not provided'}</TableCell>
			<TableCell>
				<Badge variant="outline">{Gender[user.gender]}</Badge>
			</TableCell>
			<TableCell className="hidden md:table-cell">{user.dob ?? 'Not provided'}</TableCell>
			<TableCell className="hidden md:table-cell">{user.email ?? 'Not provided'}</TableCell>
			<TableCell className="hidden md:table-cell">
				{user.phoneNumber ?? 'Not provided'}
			</TableCell>
			<TableCell>
				<DropdownMenu>
					<DropdownMenuTrigger asChild>
						<Button aria-haspopup="true" size="icon" variant="ghost">
							<MoreHorizontal className="h-4 w-4" />
							<span className="sr-only">Toggle menu</span>
						</Button>
					</DropdownMenuTrigger>
					<DropdownMenuContent align="end">
						<DropdownMenuLabel>Actions</DropdownMenuLabel>
						<DropdownMenuItem>Block</DropdownMenuItem>
						<DropdownMenuItem>Un-block</DropdownMenuItem>
					</DropdownMenuContent>
				</DropdownMenu>
			</TableCell>
		</TableRow>
	);
};

export default UserRow;
