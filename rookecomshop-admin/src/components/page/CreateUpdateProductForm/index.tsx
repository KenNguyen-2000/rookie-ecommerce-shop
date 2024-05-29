import { ChevronLeft, Upload } from 'lucide-react';

import { Badge } from '@/components/ui/badge';
import { Button } from '@/components/ui/button';
import { Card, CardContent, CardDescription, CardHeader, CardTitle } from '@/components/ui/card';
import { Input } from '@/components/ui/input';
import { Label } from '@/components/ui/label';
import {
	Select,
	SelectContent,
	SelectItem,
	SelectTrigger,
	SelectValue,
} from '@/components/ui/select';
import { Textarea } from '@/components/ui/textarea';
import { SubmitHandler, useForm } from 'react-hook-form';
import { CreateUpdateProductInputs } from '@/services/products/products.type';
import { zodResolver } from '@hookform/resolvers/zod';
import { CreateUpdateProductScheme } from '@/services/products/products.scheme';
import {
	Form,
	FormControl,
	FormField,
	FormItem,
	FormLabel,
	FormMessage,
} from '@/components/ui/form';
import { FC, useEffect } from 'react';
import { useAppDispatch, useAppSelector } from '@/redux/reduxHooks';
import { getCategoriesAsync } from '@/redux/thunks/categories.thunk';
import { setSelectedTopCategory } from '@/redux/slices/categories.slice';
import { ProductStatus } from '@/services/products/products.enum';
import { useNavigate } from 'react-router-dom';
import QuillEditor from '../QuillEditor';

type CreateUpdateProductFormProps = {
	defaultValue?: CreateUpdateProductInputs;
	handleSubmitForm: (args: CreateUpdateProductInputs) => void;
};

const CreateUpdateProductForm: FC<CreateUpdateProductFormProps> = ({
	defaultValue,
	handleSubmitForm,
}) => {
	const dispatch = useAppDispatch();
	const navigate = useNavigate();

	const {
		categories,
		isLoading: categoryLoading,
		selectedTopCategory,
	} = useAppSelector((state) => state.categories);
	const form = useForm<CreateUpdateProductInputs>({
		resolver: zodResolver(CreateUpdateProductScheme),
		defaultValues: defaultValue,
	});

	const onSubmit: SubmitHandler<CreateUpdateProductInputs> = (data) => {
		handleSubmitForm(data);
		form.reset();
	};

	useEffect(() => {
		dispatch(getCategoriesAsync());
		if (defaultValue?.category) {
			dispatch(setSelectedTopCategory(defaultValue.category));
		}
	}, [defaultValue?.categoryName]);

	return (
		<Form {...form}>
			<form onSubmit={form.handleSubmit(onSubmit)}>
				<div className="mx-auto grid max-w-[64rem] flex-1 auto-rows-max gap-4">
					<div className="flex items-center gap-4">
						<Button
							type="button"
							variant="outline"
							size="icon"
							className="h-7 w-7"
							onClick={() => navigate(-1)}
						>
							<ChevronLeft className="h-4 w-4" />
							<span className="sr-only">Back</span>
						</Button>
						<h1 className="flex-1 shrink-0 whitespace-nowrap text-xl font-semibold tracking-tight sm:grow-0">
							Pro Controller
						</h1>
						<Badge variant="outline" className="ml-auto sm:ml-0">
							In stock
						</Badge>
						<div className="hidden items-center gap-2 md:ml-auto md:flex">
							<Button
								type="button"
								variant="outline"
								size="sm"
								onClick={() => form.reset()}
							>
								Discard
							</Button>
							<Button size="sm">Save Product</Button>
						</div>
					</div>
					<div className="grid gap-4 md:grid-cols-[1fr_250px] lg:grid-cols-3 lg:gap-8">
						<div className="grid auto-rows-max items-start gap-4 lg:col-span-2 lg:gap-8">
							<Card x-chunk="dashboard-07-chunk-0">
								<CardHeader>
									<CardTitle>Product Images</CardTitle>
									<CardDescription>
										Lipsum dolor sit amet, consectetur adipiscing elit
									</CardDescription>
								</CardHeader>
								<CardContent>
									<div className="grid gap-6">
										{defaultValue?.imgUrls &&
											defaultValue?.imgUrls?.length > 0 && (
												<div>
													<Label>Images</Label>
													<div className="grid grid-cols-7 gap-3">
														{defaultValue?.imgUrls.map((image) => (
															<div
																key={image}
																className="max-w-20 max-h-20 bg-muted/10 border border-gray-300 rounded-md"
															>
																<img
																	width={80}
																	height={80}
																	loading="lazy"
																	src={`https://localhost:7181/api/v1/upload-image?imageName=${image}`}
																	alt={image}
																	className="aspect-square w-20 rounded-md object-contain"
																/>
															</div>
														))}
													</div>
												</div>
											)}
										<div className="grid gap-3">
											<Label>Uploads</Label>
											<div className="grid grid-cols-7 gap-3">
												{form.watch('images') &&
													[...(form.watch('images') as any)].map(
														(file) => (
															<div
																key={file.name}
																className="max-w-20 max-h-20 bg-muted/10 border border-gray-300 rounded-md"
															>
																<img
																	width={80}
																	height={80}
																	loading="lazy"
																	src={URL.createObjectURL(file)}
																	alt={file.name}
																	className="aspect-square w-20 rounded-md object-contain"
																/>
															</div>
														),
													)}
												<FormField
													control={form.control}
													name="images"
													render={({
														field: { onChange, value, ...restField },
													}) => (
														<FormItem>
															<FormLabel className="flex aspect-square w-20 items-center justify-center rounded-md border border-dashed">
																<Upload className="h-4 w-4 text-muted-foreground" />
																<span className="sr-only">
																	Upload
																</span>
															</FormLabel>
															<FormControl>
																<Input
																	type="file"
																	multiple
																	{...restField}
																	onChange={(e) => {
																		onChange(e.target.files);
																	}}
																	className="hidden"
																/>
															</FormControl>
															<FormMessage />
														</FormItem>
													)}
												/>
											</div>
										</div>
									</div>
								</CardContent>
							</Card>
							<Card x-chunk="dashboard-07-chunk-0">
								<CardHeader>
									<CardTitle>Product Details</CardTitle>
									<CardDescription>
										Lipsum dolor sit amet, consectetur adipiscing elit
									</CardDescription>
								</CardHeader>
								<CardContent>
									<div className="grid gap-6">
										<div className="grid gap-3">
											<FormField
												control={form.control}
												name="name"
												render={({ field }) => (
													<FormItem>
														<FormLabel>Name</FormLabel>
														<FormControl>
															<Input
																className="w-full"
																placeholder="Gamer Gear Pro Controller"
																{...field}
															/>
														</FormControl>
														<FormMessage />
													</FormItem>
												)}
											/>
										</div>
										<div className="grid grid-cols-3 gap-3">
											<div className="grid">
												<FormField
													control={form.control}
													name="price"
													render={({ field }) => (
														<FormItem>
															<FormLabel>Price</FormLabel>
															<FormControl>
																<Input
																	type="number"
																	className="w-full"
																	placeholder="0"
																	{...field}
																/>
															</FormControl>
															<FormMessage />
														</FormItem>
													)}
												/>
											</div>
											<div className="grid">
												<FormField
													control={form.control}
													name="stockQuantity"
													render={({ field }) => (
														<FormItem>
															<FormLabel>Stock</FormLabel>
															<FormControl>
																<Input
																	type="number"
																	className="w-full"
																	placeholder="0"
																	{...field}
																/>
															</FormControl>
															<FormMessage />
														</FormItem>
													)}
												/>
											</div>
											<div className="grid gap-3">
												<FormField
													control={form.control}
													name="status"
													render={({ field }) => (
														<FormItem>
															<FormLabel>Status</FormLabel>
															<Select
																defaultValue={defaultValue?.status?.toString()}
																onValueChange={(value) => {
																	field.onChange(parseInt(value));
																}}
															>
																<FormControl>
																	<SelectTrigger>
																		<SelectValue placeholder="Select status" />
																	</SelectTrigger>
																</FormControl>
																<SelectContent>
																	<SelectItem
																		value={ProductStatus.Active.toString()}
																	>
																		Active
																	</SelectItem>
																	<SelectItem
																		value={ProductStatus.Inactive.toString()}
																	>
																		Inactive
																	</SelectItem>
																</SelectContent>
															</Select>
															<FormMessage />
														</FormItem>
													)}
												/>
											</div>
										</div>
										<div className="grid gap-3">
											<FormField
												control={form.control}
												name="description"
												render={({ field }) => (
													<FormItem>
														<FormLabel>Description</FormLabel>
														<FormControl>
															<QuillEditor
																className="min-h-[150px]"
																onChange={(value) =>
																	field.onChange(value)
																}
																value={field.value}
															/>
														</FormControl>
														<FormMessage />
													</FormItem>
												)}
											/>
										</div>
									</div>
								</CardContent>
							</Card>
							<Card x-chunk="dashboard-07-chunk-2">
								<CardHeader>
									<CardTitle>Product Category</CardTitle>
								</CardHeader>
								<CardContent>
									<div className="grid gap-6 sm:grid-cols-3">
										<div className="grid gap-3">
											<FormField
												control={form.control}
												name="categoryName"
												render={({ field }) => (
													<FormItem>
														<FormLabel>Category</FormLabel>
														<Select
															defaultValue={field.value}
															onValueChange={(value) => {
																const getCategory = categories.find(
																	(category) =>
																		category.name === value,
																);
																dispatch(
																	setSelectedTopCategory(
																		getCategory,
																	),
																);
																field.onChange(value);
															}}
														>
															<FormControl>
																<SelectTrigger>
																	<SelectValue placeholder="Select category" />
																</SelectTrigger>
															</FormControl>
															<SelectContent>
																{categories.map((category) => (
																	<SelectItem
																		key={category.name}
																		value={category.name}
																	>
																		{category.name}
																	</SelectItem>
																))}
															</SelectContent>
														</Select>
														<FormMessage />
													</FormItem>
												)}
											/>
										</div>
										<div className="grid gap-3">
											<FormField
												control={form.control}
												name="subCategoryName"
												render={({ field }) => (
													<FormItem>
														<FormLabel>Sub Category</FormLabel>
														<Select
															defaultValue={selectedTopCategory?.name}
															onValueChange={(value) => {
																field.onChange(value);
															}}
														>
															<FormControl>
																<SelectTrigger>
																	<SelectValue placeholder="Select sub category" />
																</SelectTrigger>
															</FormControl>
															<SelectContent>
																{selectedTopCategory?.subCategories.map(
																	(subCategory) => (
																		<SelectItem
																			key={subCategory.id}
																			value={subCategory.name}
																		>
																			{subCategory.name}
																		</SelectItem>
																	),
																)}
															</SelectContent>
														</Select>
													</FormItem>
												)}
											/>
										</div>
									</div>
								</CardContent>
							</Card>
						</div>
						<div className="grid auto-rows-max items-start gap-4 lg:gap-8">
							{/* <Card x-chunk="dashboard-07-chunk-3">
								<CardHeader>
									<CardTitle>Product Status</CardTitle>
								</CardHeader>
								<CardContent>
									<div className="grid gap-6">
										<div className="grid gap-3">
											<FormField
												control={form.control}
												name="status"
												render={({ field }) => (
													<FormItem>
														<FormLabel>Status</FormLabel>
														<Select
															defaultValue={defaultValue?.status?.toString()}
															onValueChange={(value) => {
																field.onChange(value);
															}}
														>
															<SelectTrigger>
																<SelectValue placeholder="Select status" />
															</SelectTrigger>
															<SelectContent>
																<SelectItem
																	value={ProductStatus.Active.toString()}
																>
																	Active
																</SelectItem>
																<SelectItem
																	value={ProductStatus.Inactive.toString()}
																>
																	Inactive
																</SelectItem>
															</SelectContent>
														</Select>
													</FormItem>
												)}
											/>
										</div>
									</div>
								</CardContent>
							</Card>
							<Card className="overflow-hidden" x-chunk="dashboard-07-chunk-4">
								<CardHeader>
									<CardTitle>Product Images</CardTitle>
									<CardDescription>
										Lipsum dolor sit amet, consectetur adipiscing elit
									</CardDescription>
								</CardHeader>
								<CardContent>
									<div className="grid gap-2">
										<img
											alt="Product image"
											className="aspect-square w-full rounded-md object-cover"
											height="300"
											src="/placeholder.svg"
											width="300"
										/>
										<div className="grid grid-cols-3 gap-2">
											<button>
												<img
													alt="Product image"
													className="aspect-square w-full rounded-md object-cover"
													height="84"
													src="/placeholder.svg"
													width="84"
												/>
											</button>
											<button>
												<img
													alt="Product image"
													className="aspect-square w-full rounded-md object-cover"
													height="84"
													src="/placeholder.svg"
													width="84"
												/>
											</button>
											<button className="flex aspect-square w-full items-center justify-center rounded-md border border-dashed">
												<Upload className="h-4 w-4 text-muted-foreground" />
												<span className="sr-only">Upload</span>
											</button>
										</div>
									</div>
								</CardContent>
							</Card> */}
							<Card x-chunk="dashboard-07-chunk-5">
								<CardHeader>
									<CardTitle>Archive Product</CardTitle>
									<CardDescription>
										Lipsum dolor sit amet, consectetur adipiscing elit.
									</CardDescription>
								</CardHeader>
								<CardContent>
									<div></div>
									<Button size="sm" variant="secondary">
										Archive Product
									</Button>
								</CardContent>
							</Card>
						</div>
					</div>
					<div className="flex items-center justify-center gap-2 md:hidden">
						<Button variant="outline" size="sm">
							Discard
						</Button>
						<Button size="sm">Save Product</Button>
					</div>
				</div>
			</form>
		</Form>
	);
};

export default CreateUpdateProductForm;
