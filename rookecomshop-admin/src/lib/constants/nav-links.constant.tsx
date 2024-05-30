import { Home, LineChart, Package, Package2, ShoppingCart, Users2 } from 'lucide-react';

export const NAV_LINKS = [
	{
		name: 'Acme Inc',
		icon: <Package2 className="h-5 w-5" />,
		route: 'dashboard',
	},
	{
		name: 'Dashboard',
		icon: <Home className="h-5 w-5" />,
		route: 'dashboard',
	},
	{
		name: 'Products',
		icon: <Package className="h-5 w-5" />,
		route: 'products',
	},
	{
		name: 'Orders',
		icon: <ShoppingCart className="h-5 w-5" />,
		route: 'orders',
	},
	{
		name: 'Customers',
		icon: <Users2 className="h-5 w-5" />,
		route: 'users',
	},
	{
		name: 'Analytics',
		icon: <LineChart className="h-5 w-5" />,
		route: '#',
	},
];
