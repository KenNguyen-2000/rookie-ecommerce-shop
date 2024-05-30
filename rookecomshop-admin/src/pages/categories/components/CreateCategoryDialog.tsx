import { Button } from '@/components/ui/button';
import {
	Dialog,
	DialogContent,
	DialogDescription,
	DialogFooter,
	DialogHeader,
	DialogTitle,
	DialogTrigger,
} from '@/components/ui/dialog';
import {
	Form,
	FormControl,
	FormField,
	FormItem,
	FormLabel,
	FormMessage,
} from '@/components/ui/form';
import { Input } from '@/components/ui/input';
import { Label } from '@/components/ui/label';
import { ScrollArea } from '@/components/ui/scroll-area';
import { Textarea } from '@/components/ui/textarea';
import { CreateCategoryScheme } from '@/services/categories/categories.scheme';
import { CategoryDto, CreateCategoryDto } from '@/services/categories/categories.type';
import { zodResolver } from '@hookform/resolvers/zod';
import { FC, useEffect } from 'react';
import { SubmitHandler, useForm } from 'react-hook-form';

type CreateCategoryDialogProps = {
	open: boolean;
	closeDialog: () => void;
	categories: CategoryDto[];
	onConfirm: (data: CreateCategoryDto) => void;
	defaultValues?: CreateCategoryDto;
};

const CreateCategoryDialog: FC<CreateCategoryDialogProps> = ({
	open,
	closeDialog,
	onConfirm,
	defaultValues,
}) => {
	const form = useForm<CreateCategoryDto>({
		resolver: zodResolver(CreateCategoryScheme),
	});

	const onSubmit: SubmitHandler<CreateCategoryDto> = (data) => {
		console.log(data);
		onConfirm(data);
	};

	useEffect(() => {
		form.reset(defaultValues);
	}, [defaultValues]);
	return (
		<Dialog open={open}>
			<DialogContent className="sm:max-w-[425px]">
				<DialogHeader>
					<DialogTitle>Create Category</DialogTitle>
					{/* <DialogDescription>
						Make changes to your profile here. Click save when you're done.
					</DialogDescription> */}
				</DialogHeader>
				<Form {...form}>
					<form onSubmit={form.handleSubmit(onSubmit)}>
						<div className="grid gap-4 py-4">
							<div className="grid items-center gap-4">
								<FormField
									control={form.control}
									name="name"
									render={({ field }) => (
										<FormItem>
											<FormLabel className="text-right">Name</FormLabel>
											<FormControl>
												<Input placeholder="Pedro Duarte" {...field} />
											</FormControl>
											<FormMessage />
										</FormItem>
									)}
								/>
							</div>
							<div className="grid items-center gap-4">
								<FormField
									control={form.control}
									name="description"
									render={({ field }) => (
										<FormItem>
											<FormLabel className="text-right">
												Description
											</FormLabel>
											<FormControl>
												<Textarea
													placeholder="Frontend Developer"
													{...field}
												/>
											</FormControl>
											<FormMessage />
										</FormItem>
									)}
								/>
							</div>
						</div>

						<DialogFooter>
							<Button type="button" variant="outline" onClick={closeDialog}>
								Cancel
							</Button>
							<Button type="submit">Save changes</Button>
						</DialogFooter>
					</form>
				</Form>
			</DialogContent>
		</Dialog>
	);
};

export default CreateCategoryDialog;
