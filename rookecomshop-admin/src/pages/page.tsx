import { Button } from '@/components/ui/button';
import { Card, CardFooter, CardHeader, CardTitle } from '@/components/ui/card';
import authService from '@/services/auth/auth.service';
import { Navigate, useNavigate } from 'react-router-dom';

function HomePage() {
	const navigate = useNavigate();
	const isAuthenticate = authService.isAuthenticated();

	const goToLogin = () => {
		navigate('/authentication/login');
	};

	if (isAuthenticate) {
		return <Navigate to="/dashboard" />;
	}

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
