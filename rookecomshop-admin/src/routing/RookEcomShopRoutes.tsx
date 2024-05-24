import { OidcAuthProvider, PrivateRoute, ReduxProvider, TanstackProvider } from '@/components/hoc';
import { AxiosInterceptor } from '@/components/hoc/AxiosInterceptor';
import { Toaster } from '@/components/ui/toaster';
import NotFoundPage from '@/pages/errors/NotFoundPage';
import { TooltipProvider } from '@radix-ui/react-tooltip';
import { createBrowserRouter, createRoutesFromElements, Route, RouterProvider } from 'react-router-dom';

const RookEcomShopRoutes = () => {
	const router = createBrowserRouter(
		createRoutesFromElements(
			<Route>
				<Route path="/authentication/:action" element={<OidcAuthProvider />} />
				<Route path="/" element={<PrivateRoute />}>
					<Route
						index
						lazy={async () => {
							const { default: DashboardPage } = await import('../pages/dashboard/page');
							return { Component: DashboardPage };
						}}
					/>
					<Route path="/products">
						<Route
							index
							lazy={async () => {
								const { default: ProductPage } = await import('../pages/products/page');
								return { Component: ProductPage };
							}}
						/>
						<Route
							path=":id"
							lazy={async () => {
								const { default: ProductDetailPage } = await import(
									'../pages/products/product-detail/page'
								);
								return { Component: ProductDetailPage };
							}}
						/>
						<Route
							path="create"
							lazy={async () => {
								const { default: CreateProductPage } = await import('../pages/products/create/page');
								return { Component: CreateProductPage };
							}}
						/>
					</Route>
				</Route>
				<Route path="*" element={<NotFoundPage />} />
			</Route>,
		),
	);
	return (
		<TooltipProvider>
			<ReduxProvider>
				<TanstackProvider>
					<AxiosInterceptor>
						<RouterProvider router={router} />
					</AxiosInterceptor>
				</TanstackProvider>
			</ReduxProvider>
			<Toaster />
		</TooltipProvider>
	);
};

export default RookEcomShopRoutes;
