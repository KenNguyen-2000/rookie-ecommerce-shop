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
import { ProductStatus } from '@/services/products/products.enum';
import { ProductDto } from '@/services/products/products.type';
import { MoreHorizontal } from 'lucide-react';
import moment from 'moment';
import React from 'react';
import { useNavigate } from 'react-router-dom';
type ProductRowProps = {
	product: ProductDto;
	onSelectProductToDelete: (id: string) => void;
};
const ProductRow: React.FC<ProductRowProps> = ({ product, onSelectProductToDelete }) => {
	const navigate = useNavigate();

	return (
		<TableRow>
			<TableCell className="hidden sm:table-cell">
				<img
					alt="Product image"
					className="aspect-square rounded-md object-cover"
					height="64"
					src={`${import.meta.env.VITE_IMG_URL}${product.imgUrls.length > 0 ? product.imgUrls[0] : ''}`}
					width="64"
				/>
			</TableCell>
			<TableCell className="font-medium">{product.name}</TableCell>
			<TableCell>
				<Badge variant="outline">{ProductStatus[product.status] ?? 'Draft'}</Badge>
			</TableCell>
			<TableCell className="hidden md:table-cell">${product.price}</TableCell>
			<TableCell className="hidden md:table-cell">{product.stockQuantity}</TableCell>
			<TableCell className="hidden md:table-cell">{product.category.name}</TableCell>
			<TableCell className="hidden md:table-cell">
				{moment(product.createdAt).format('DD/MM/yyyy')}
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
						<DropdownMenuItem onClick={() => navigate(`/products/${product.id}`)}>
							Edit
						</DropdownMenuItem>

						<DropdownMenuItem onClick={onSelectProductToDelete.bind(null, product.id)}>
							Delete
						</DropdownMenuItem>
					</DropdownMenuContent>
				</DropdownMenu>
			</TableCell>
		</TableRow>
	);
};

export default ProductRow;
