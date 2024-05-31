import {
	AxiosInterceptor,
	ErrorHandleProvider,
	OidcAuthProvider,
	PrivateRoute,
	ReduxProvider,
	TanstackProvider,
} from '@/components/hoc';
import { Toaster } from '@/components/ui/toaster';
import NotFoundPage from '@/pages/errors/NotFoundPage';
import HomePage from '@/pages/page';
import { TooltipProvider } from '@radix-ui/react-tooltip';
import {
	createBrowserRouter,
	createRoutesFromElements,
	Route,
	RouterProvider,
} from 'react-router-dom';
import 'quill/dist/quill.snow.css';
import { ToastContainer } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';

const RookEcomShopRoutes = () => {
	const router = createBrowserRouter(
		createRoutesFromElements(
			<Route errorElement={<ErrorHandleProvider />}>
				<Route path="/authentication/:action" element={<OidcAuthProvider />} />
				<Route path="/" element={<HomePage />} />
				<Route path="/" element={<PrivateRoute />}>
					<Route
						path="/dashboard"
						lazy={async () => {
							const { default: DashboardPage } = await import(
								'../pages/dashboard/page'
							);
							return { Component: DashboardPage };
						}}
					/>
					<Route
						path="orders"
						lazy={async () => {
							const { default: OrdersPage } = await import('../pages/orders/page');
							return { Component: OrdersPage };
						}}
					/>
					<Route
						path="users"
						lazy={async () => {
							const { default: OrdersPage } = await import('../pages/users/page');
							return { Component: OrdersPage };
						}}
					/>
					<Route path="/products">
						<Route
							index
							lazy={async () => {
								const { default: ProductPage } = await import(
									'../pages/products/page'
								);
								return { Component: ProductPage };
							}}
						/>
						<Route
							path=":productId"
							lazy={async () => {
								const { default: ProductDetailPage } = await import(
									'../pages/products/[productId]/page'
								);
								return { Component: ProductDetailPage };
							}}
						/>
						<Route
							path="create"
							lazy={async () => {
								const { default: CreateProductPage } = await import(
									'../pages/products/create/page'
								);
								return { Component: CreateProductPage };
							}}
						/>
					</Route>
					<Route path="/categories">
						<Route
							index
							lazy={async () => {
								const { default: ProductPage } = await import(
									'../pages/categories/page'
								);
								return { Component: ProductPage };
							}}
						/>
						<Route
							path=":categoryId"
							lazy={async () => {
								const { default: ProductDetailPage } = await import(
									'../pages/categories/[categoryId]/page'
								);
								return { Component: ProductDetailPage };
							}}
						/>
					</Route>
				</Route>
				<Route path="*" element={<NotFoundPage />} />
			</Route>,
		),
	);
	return (
			<>
			<ToastContainer />
			<TooltipProvider>
				<ReduxProvider>
					<TanstackProvider>
						<AxiosInterceptor>
							<RouterProvider router={router} />
						</AxiosInterceptor>
					</TanstackProvider>
				</ReduxProvider>
				<Toaster />
			</TooltipProvider></>
	);
};

export default RookEcomShopRoutes;
