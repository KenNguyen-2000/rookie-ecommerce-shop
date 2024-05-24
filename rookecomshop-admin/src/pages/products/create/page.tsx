/* eslint-disable @typescript-eslint/no-unused-vars */
import { ContentSidebarLayout } from '@/components/layouts';
import { Badge } from '@/components/ui/badge';
import { Button } from '@/components/ui/button';
import {
    Card,
    CardContent,
    CardDescription,
    CardHeader,
    CardTitle,
} from '@/components/ui/card';
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
import {
    Select,
    SelectContent,
    SelectItem,
    SelectTrigger,
    SelectValue,
} from '@/components/ui/select';
import { Textarea } from '@/components/ui/textarea';
import { useAppDispatch, useAppSelector } from '@/redux/reduxHooks';
import { setSelectedTopCategory } from '@/redux/slices/categories.slice';
import { getCategoriesAsync } from '@/redux/thunks/categories.thunk';
import { createProductAsync } from '@/redux/thunks/products.thunk';
import { CreateProductInputs } from '@/services/products/products.type';
import { ChevronLeft } from 'lucide-react';
import { useEffect, useState } from 'react';
import { SubmitHandler, useForm } from 'react-hook-form';
import { zodResolver } from '@hookform/resolvers/zod';
import { useToast } from '@/components/ui/use-toast';
import { useNavigate } from 'react-router-dom';
import { CreateProductScheme } from '@/services/products/products.scheme';

const CreateProductPage = () => {
    const { toast } = useToast();
    const navigate = useNavigate();
    const form = useForm<CreateProductInputs>({
        resolver: zodResolver(CreateProductScheme),
        defaultValues: {
            name: '',
            price: 0,
            stock: 0,
            description: '',
            categoryName: '',
        },
    });
    const dispatch = useAppDispatch();
    const { categories, isLoading, selectedTopCategory } = useAppSelector(
        (state) => state.categories,
    );

    const [createProductLoading, setCreateProductLoading] = useState(false);

    const onSubmit: SubmitHandler<CreateProductInputs> = async (
        data: CreateProductInputs,
    ) => {
        setCreateProductLoading(true);
        await dispatch(createProductAsync(data));
        setCreateProductLoading(false);
        toast({
            title: 'Create Product Succeeded',
            description: (
                <pre className="mt-2 w-[340px] rounded-md bg-slate-950 p-4">
                    <code className="text-white">
                        {JSON.stringify(data, null, 2)}
                    </code>
                </pre>
            ),
        });
    };

    useEffect(() => {
        dispatch(getCategoriesAsync());
    }, [dispatch]);

    return (
        <ContentSidebarLayout>
            <Form {...form}>
                <form
                    onSubmit={form.handleSubmit(onSubmit)}
                    className="grid gap-4"
                >
                    <div className="mx-auto grid max-w-[59rem] flex-1 auto-rows-max gap-4">
                        <div className="flex items-center gap-4">
                            <Button
                                variant="outline"
                                size="icon"
                                className="h-7 w-7"
                                onClick={() => navigate(-1)}
                            >
                                <ChevronLeft className="h-4 w-4" />
                                <span className="sr-only">Back</span>
                            </Button>
                            <h1 className="flex-1 shrink-0 whitespace-nowrap text-xl font-semibold tracking-tight sm:grow-0">
                                Add New Product
                            </h1>
                            <Badge
                                variant="outline"
                                className="ml-auto sm:ml-0"
                            >
                                In stock
                            </Badge>
                            <div className="hidden items-center gap-2 md:ml-auto md:flex">
                                <Button variant="outline" size="sm">
                                    Discard
                                </Button>
                                <Button size="sm" type="submit">
                                    Save Product
                                </Button>
                            </div>
                        </div>
                        <div className="grid gap-4 md:grid-cols-[1fr_250px] lg:grid-cols-3 lg:gap-8">
                            <div className="grid auto-rows-max items-start gap-4 col-span-full lg:gap-8">
                                <Card x-chunk="dashboard-07-chunk-0">
                                    <CardHeader>
                                        <CardTitle>Product Details</CardTitle>
                                        <CardDescription>
                                            Lipsum dolor sit amet, consectetur
                                            adipiscing elit
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
                                                            <FormLabel>
                                                                Name
                                                            </FormLabel>
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
                                                                <FormLabel>
                                                                    Price
                                                                </FormLabel>
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
                                                        name="stock"
                                                        render={({ field }) => (
                                                            <FormItem>
                                                                <FormLabel>
                                                                    Stock
                                                                </FormLabel>
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
                                            </div>
                                            <div className="grid gap-3">
                                                <FormField
                                                    control={form.control}
                                                    name="description"
                                                    render={({ field }) => (
                                                        <FormItem>
                                                            <FormLabel>
                                                                Description
                                                            </FormLabel>
                                                            <FormControl>
                                                                <Textarea
                                                                    placeholder="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam auctor, nisl nec ultricies ultricies, nunc nisl ultricies nunc, nec ultricies nunc nisl nec nunc."
                                                                    className="min-h-32"
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
                                                    name="images"
                                                    render={({
                                                        field: {
                                                            value,
                                                            onChange,
                                                            ...fieldProps
                                                        },
                                                    }) => (
                                                        <FormItem>
                                                            <FormLabel>
                                                                Picture
                                                            </FormLabel>
                                                            <FormControl>
                                                                <Input
                                                                    {...fieldProps}
                                                                    className="w-full"
                                                                    type="file"
                                                                    accept="image/*, application/pdf"
                                                                    multiple
                                                                    placeholder="Picture"
                                                                    onChange={(
                                                                        e,
                                                                    ) => {
                                                                        onChange(
                                                                            e
                                                                                .target
                                                                                .files &&
                                                                                e
                                                                                    .target
                                                                                    .files[0],
                                                                        );
                                                                    }}
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
                                                            <FormLabel htmlFor="category">
                                                                Category
                                                            </FormLabel>
                                                            <Select
                                                                onValueChange={(
                                                                    value,
                                                                ) => {
                                                                    const getCategory =
                                                                        categories.find(
                                                                            (
                                                                                category,
                                                                            ) =>
                                                                                category.name ===
                                                                                value,
                                                                        );
                                                                    dispatch(
                                                                        setSelectedTopCategory(
                                                                            getCategory,
                                                                        ),
                                                                    );
                                                                    field.onChange(
                                                                        value,
                                                                    );
                                                                }}
                                                                defaultValue={
                                                                    categories[0]
                                                                        ?.id
                                                                }
                                                            >
                                                                <FormControl>
                                                                    <SelectTrigger>
                                                                        <SelectValue placeholder="Select category" />
                                                                    </SelectTrigger>
                                                                </FormControl>
                                                                <SelectContent>
                                                                    {!isLoading
                                                                        ? categories.map(
                                                                              (
                                                                                  category,
                                                                              ) => (
                                                                                  <SelectItem
                                                                                      key={
                                                                                          category.id
                                                                                      }
                                                                                      value={
                                                                                          category.name
                                                                                      }
                                                                                  >
                                                                                      {
                                                                                          category.name
                                                                                      }
                                                                                  </SelectItem>
                                                                              ),
                                                                          )
                                                                        : null}
                                                                </SelectContent>
                                                            </Select>
                                                            <FormMessage />
                                                        </FormItem>
                                                    )}
                                                />
                                            </div>
                                            <div className="grid gap-3">
                                                <Label htmlFor="subcategory">
                                                    Subcategory (optional)
                                                </Label>
                                                <Select>
                                                    <SelectTrigger
                                                        id="subcategory"
                                                        aria-label="Select subcategory"
                                                    >
                                                        <SelectValue placeholder="Select subcategory" />
                                                    </SelectTrigger>
                                                    <SelectContent>
                                                        {selectedTopCategory &&
                                                            selectedTopCategory.subCategories.map(
                                                                (category) => (
                                                                    <SelectItem
                                                                        key={
                                                                            category.id
                                                                        }
                                                                        value={
                                                                            category.id
                                                                        }
                                                                    >
                                                                        {
                                                                            category.name
                                                                        }
                                                                    </SelectItem>
                                                                ),
                                                            )}
                                                    </SelectContent>
                                                </Select>
                                            </div>
                                        </div>
                                    </CardContent>
                                </Card>
                            </div>
                            {/* <div className="grid auto-rows-max items-start gap-4 lg:gap-8">
            <Card x-chunk="dashboard-07-chunk-3">
              <CardHeader>
                <CardTitle>Product Status</CardTitle>
              </CardHeader>
              <CardContent>
                <div className="grid gap-6">
                  <div className="grid gap-3">
                    <Label htmlFor="status">Status</Label>
                    <Select>
                      <SelectTrigger id="status" aria-label="Select status">
                        <SelectValue placeholder="Select status" />
                      </SelectTrigger>
                      <SelectContent>
                        <SelectItem value="draft">Draft</SelectItem>
                        <SelectItem value="published">Active</SelectItem>
                        <SelectItem value="archived">Archived</SelectItem>
                      </SelectContent>
                    </Select>
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
            </Card>
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
          </div> */}
                        </div>
                    </div>
                </form>
            </Form>
        </ContentSidebarLayout>
    );
};

export default CreateProductPage;
