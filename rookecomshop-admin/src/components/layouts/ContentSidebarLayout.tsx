import React, { FormEvent, useState } from 'react';
import Sidebar from '../page/Sidebar';
import { Sheet, SheetContent, SheetTrigger } from '../ui/sheet';
import { Button } from '../ui/button';
import {
	Home,
	LineChart,
	Package,
	Package2,
	PanelLeft,
	Search,
	ShoppingCart,
	Users2,
} from 'lucide-react';
import {
	Breadcrumb,
	BreadcrumbItem,
	BreadcrumbLink,
	BreadcrumbList,
	BreadcrumbPage,
	BreadcrumbSeparator,
} from '../ui/breadcrumb';
import {
	DropdownMenu,
	DropdownMenuContent,
	DropdownMenuItem,
	DropdownMenuLabel,
	DropdownMenuSeparator,
	DropdownMenuTrigger,
} from '../ui/dropdown-menu';
import { Input } from '../ui/input';
import { Link, useLocation, useNavigate, useParams, useSearchParams } from 'react-router-dom';
import { NAV_LINKS } from '@/lib/constants/nav-links.constant';
import { cn } from '@/lib/utils';
import { useAppSelector } from '@/redux/reduxHooks';

const ACTIVE_CLASSNAME =
	'group flex h-10 w-10 shrink-0 items-center justify-center gap-2 rounded-full bg-primary text-lg font-semibold text-primary-foreground md:text-base';
const INACTIVE_CLASSNAME =
	'flex items-center gap-4 px-2.5 text-muted-foreground hover:text-foreground';

type ContentSidebarLayoutProps = {
	children: React.ReactNode;
};

const ContentSidebarLayout: React.FC<ContentSidebarLayoutProps> = ({ children }) => {
	const { pathname } = useLocation();
	const { user } = useAppSelector((state) => state.auth);
	const { productId, categoryId } = useParams();
	const navigate = useNavigate();
	const [searchParams, setSearchParams] = useSearchParams();
	const [searchTerm, setSearchTerm] = useState('');

	const handleLogout = () => {
		navigate('/authentication/logout');
	};

	const handleSearch = (e: FormEvent) => {
		e.preventDefault();
		const newParams = new URLSearchParams(searchParams);
		newParams.set('searchTerm', searchTerm);
		setSearchParams(newParams);
	};

	return (
		<div className="flex min-h-screen w-full flex-col bg-muted/40">
			<Sidebar />
			<div className="flex flex-col sm:gap-4 sm:py-4 sm:pl-14">
				<header className="sticky top-0 z-30 flex h-14 items-center gap-4 border-b bg-background px-4 sm:static sm:h-auto sm:border-0 sm:bg-transparent sm:px-6">
					<Sheet>
						<SheetTrigger asChild>
							<Button size="icon" variant="outline" className="sm:hidden">
								<PanelLeft className="h-5 w-5" />
								<span className="sr-only">Toggle Menu</span>
							</Button>
						</SheetTrigger>
						<SheetContent side="left" className="sm:max-w-xs">
							<nav className="grid gap-6 text-lg font-medium">
								{NAV_LINKS.map((link) => (
									<Link
										key={link.route}
										to={`/${link.route}`}
										className={cn({
											[ACTIVE_CLASSNAME]: pathname.includes(`/${link.route}`),
											[INACTIVE_CLASSNAME]: !pathname.includes(
												`/${link.route}`,
											),
										})}
									>
										{link.icon}
										<span className="sr-only">{link.name}</span>
									</Link>
								))}

								<a
									href="#"
									className="flex items-center gap-4 px-2.5 text-muted-foreground hover:text-foreground"
								>
									<LineChart className="h-5 w-5" />
									Settings
								</a>
							</nav>
						</SheetContent>
					</Sheet>
					<Breadcrumb className="hidden md:flex">
						<BreadcrumbList>
							{pathname.split('/').map((path, index) => {
								let capitalizeName =
									path.charAt(0).toUpperCase() + path.substring(1);

								const isLast = index === pathname.split('/').length - 1;
								const isHome = index === 0;

								if (isLast && productId) capitalizeName = 'Product Detail';
								if (isLast && categoryId) capitalizeName = 'Category Detail';

								if (isLast)
									return (
										<BreadcrumbItem key={index}>
											<BreadcrumbPage>{capitalizeName}</BreadcrumbPage>
										</BreadcrumbItem>
									);
								return (
									<React.Fragment key={index}>
										<BreadcrumbItem>
											<BreadcrumbLink asChild>
												<Link to={`/${path}`}>
													{isHome ? 'Dashboard' : capitalizeName}
												</Link>
											</BreadcrumbLink>
										</BreadcrumbItem>
										<BreadcrumbSeparator />
									</React.Fragment>
								);
							})}
						</BreadcrumbList>
					</Breadcrumb>
					<form onSubmit={handleSearch} className="relative ml-auto flex-1 md:grow-0">
						<Search className="absolute left-2.5 top-2.5 h-4 w-4 text-muted-foreground" />
						<Input
							type="search"
							placeholder="Search..."
							className="w-full rounded-lg bg-background pl-8 md:w-[200px] lg:w-[336px]"
							onChange={(e) => setSearchTerm(e.target.value)}
						/>
					</form>
					<DropdownMenu>
						<DropdownMenuTrigger asChild>
							<Button
								variant="outline"
								size="icon"
								className="overflow-hidden rounded-full"
							>
								<img
									src="/placeholder-user.jpg"
									width={36}
									height={36}
									alt="Avatar"
									className="overflow-hidden rounded-full"
								/>
							</Button>
						</DropdownMenuTrigger>
						<DropdownMenuContent align="end">
							<DropdownMenuLabel>{user?.name ?? 'My Account'}</DropdownMenuLabel>
							<DropdownMenuSeparator />
							<DropdownMenuItem>Settings</DropdownMenuItem>
							<DropdownMenuItem>Support</DropdownMenuItem>
							<DropdownMenuSeparator />
							<DropdownMenuItem onClick={handleLogout}>Logout</DropdownMenuItem>
						</DropdownMenuContent>
					</DropdownMenu>
				</header>
				<main className="grid flex-1 items-start gap-4 p-4 sm:px-6 sm:py-0 md:gap-8">
					{children}
				</main>
			</div>
		</div>
	);
};

export default ContentSidebarLayout;
