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
import { CategoryDto } from '@/services/categories/categories.type';
import { MoreHorizontal } from 'lucide-react';
import React from 'react';
import { Link } from 'react-router-dom';

type CategoryCardProps = {
	category: CategoryDto;
	onSelected: (category: CategoryDto, action: 'edit' | 'delete') => void;
};

const CategoryCard: React.FC<CategoryCardProps> = ({ category, onSelected }) => {
	return (
		<TableRow>
			<TableCell className="font-medium">
				<Link to={`/categories/${category.name}`}>{category.name}</Link>
			</TableCell>
			<TableCell>{category.description}</TableCell>
			<TableCell className="hidden md:table-cell">{category.createdAt}</TableCell>
			<TableCell className="hidden md:table-cell">{category.updatedAt}</TableCell>
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
						<DropdownMenuItem onClick={onSelected.bind(null, category, 'edit')}>
							Edit
						</DropdownMenuItem>
						<DropdownMenuItem onClick={onSelected.bind(null, category, 'delete')}>
							Delete
						</DropdownMenuItem>
					</DropdownMenuContent>
				</DropdownMenu>
			</TableCell>
		</TableRow>
	);
};

export default CategoryCard;
