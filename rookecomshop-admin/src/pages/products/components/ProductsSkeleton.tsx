import { Skeleton } from '@/components/ui/skeleton';
import { TableCell, TableRow } from '@/components/ui/table';

const ProductsSkeleton = ({ count }: { count: number }) => {
	return (
		<>
			{Array.from({ length: count }).map((_, index) => (
				<TableRow key={index}>
					<TableCell className="hidden sm:table-cell">
						<Skeleton className="bg-slate-300 h-16 w-16 rounded-full" />
					</TableCell>
					<TableCell className="font-medium">
						<Skeleton className="bg-slate-300 h-6 w-32 rounded-full" />
					</TableCell>
					<TableCell>
						<Skeleton className="bg-slate-300 h-6 w-10 rounded-full" />
					</TableCell>
					<TableCell className="hidden md:table-cell">
						<Skeleton className="bg-slate-300 h-6 w-32 rounded-full" />
					</TableCell>
					<TableCell className="hidden md:table-cell">
						<Skeleton className="bg-slate-300 h-6 w-32 rounded-full" />
					</TableCell>
					<TableCell className="hidden md:table-cell">
						<Skeleton className="bg-slate-300 h-6 w-32 rounded-full" />
					</TableCell>
					<TableCell className="hidden md:table-cell">
						<Skeleton className="bg-slate-300 h-6 w-32 rounded-full" />
					</TableCell>
					<TableCell></TableCell>
				</TableRow>
			))}
		</>
	);
};

export default ProductsSkeleton;
