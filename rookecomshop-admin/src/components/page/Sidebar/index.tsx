import { Package2, Settings } from 'lucide-react';

import { Tooltip, TooltipContent, TooltipTrigger } from '@/components/ui/tooltip';
import { Link, useLocation } from 'react-router-dom';
import { NAV_LINKS } from '@/lib/constants/nav-links.constant';
import { cn } from '@/lib/utils';

const ACTIVE_CLASSNAME =
	'group flex h-9 w-9 shrink-0 items-center justify-center gap-2 rounded-full bg-primary text-lg font-semibold text-primary-foreground md:h-8 md:w-8 md:text-base';
const INACTIVE_CLASSNAME =
	'flex h-9 w-9 items-center justify-center rounded-lg text-muted-foreground transition-colors hover:text-foreground md:h-8 md:w-8';

const Sidebar = () => {
	const { pathname } = useLocation();

	return (
		<aside className="fixed inset-y-0 left-0 z-10 hidden w-14 flex-col border-r bg-background sm:flex">
			<nav className="flex flex-col items-center gap-4 px-2 sm:py-5">
				{NAV_LINKS.map((link) => (
					<Tooltip key={link.name}>
						<TooltipTrigger asChild>
							<Link
								to={`/${link.route}`}
								className={cn({
									[ACTIVE_CLASSNAME]: pathname.includes(`/${link.route}`),
									[INACTIVE_CLASSNAME]: !pathname.includes(`/${link.route}`),
								})}
							>
								{link.icon}
								<span className="sr-only">{link.name}</span>
							</Link>
						</TooltipTrigger>
						<TooltipContent side="right">{link.name}</TooltipContent>
					</Tooltip>
				))}
			</nav>
			<nav className="mt-auto flex flex-col items-center gap-4 px-2 sm:py-5">
				<Tooltip>
					<TooltipTrigger asChild>
						<a
							href="#"
							className="flex h-9 w-9 items-center justify-center rounded-lg text-muted-foreground transition-colors hover:text-foreground md:h-8 md:w-8"
						>
							<Settings className="h-5 w-5" />
							<span className="sr-only">Settings</span>
						</a>
					</TooltipTrigger>
					<TooltipContent side="right">Settings</TooltipContent>
				</Tooltip>
			</nav>
		</aside>
	);
};

export default Sidebar;
