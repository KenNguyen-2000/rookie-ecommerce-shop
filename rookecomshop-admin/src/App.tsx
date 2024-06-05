import { ToastContainer } from 'react-toastify';
import { TooltipProvider } from './components/ui/tooltip';
import { AxiosInterceptor, ReduxProvider, TanstackProvider } from './components/hoc';
import { Toaster } from './components/ui/toaster';
import RookEcomShopRoutes from './routing/RookEcomShopRoutes';

const App = () => {
	return (
		<>
			<ToastContainer position='bottom-right' />
			<TooltipProvider>
				<ReduxProvider>
					<TanstackProvider>
						<AxiosInterceptor>
							<RookEcomShopRoutes />
						</AxiosInterceptor>
					</TanstackProvider>
				</ReduxProvider>
				<Toaster />
			</TooltipProvider>
		</>
	);
};

export default App;
