import { Button } from '@/components/ui/button';
import {
	Card,
	CardContent,
	CardDescription,
	CardFooter,
	CardHeader,
	CardTitle,
} from '@/components/ui/card';
import { TOKEN_STRING } from '@/lib/constants/cookies.constant';
import { useAppSelector } from '@/redux/reduxHooks';
import Cookies from 'js-cookie';
import { useEffect, useState } from 'react';
import { useNavigate } from 'react-router-dom';

function HomePage() {
	const navigate = useNavigate();
	const { isAuthenticated } = useAppSelector((state) => state.auth);

	const [isLoading, setIsLoading] = useState(true);

	const goToLogin = () => {
		navigate('/authentication/login');
	};

	useEffect(() => {
		if (!isAuthenticated) {
			const token = Cookies.get(TOKEN_STRING);
			if (token) {
				navigate('/dashboard');
			}
		} else navigate('/dashboard');

		setIsLoading(false);
	}, []);

	if (isLoading) return <div>Loading</div>;

	return (
		<div className="min-h-screen w-full flex items-center justify-center">
			<Card className="w-full max-w-sm">
				<CardHeader>
					<CardTitle className="text-2xl">Login</CardTitle>
				</CardHeader>
				<CardFooter>
					<Button className="w-full" onClick={goToLogin}>
						Sign in
					</Button>
				</CardFooter>
			</Card>
		</div>
	);
}

export default HomePage;
