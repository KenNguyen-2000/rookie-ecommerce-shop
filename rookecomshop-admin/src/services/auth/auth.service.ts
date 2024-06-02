import { useAppDispatch } from '@/redux/reduxHooks';
import { storeUser } from '@/redux/slices/auth.slice';
import {
	Log,
	SignoutResponse,
	User,
	UserManager,
	UserManagerSettings,
	WebStorageStateStore,
} from 'oidc-client';

const oidcConfig: UserManagerSettings = {
	authority: import.meta.env.VITE_AUTHORITY,
	client_id: import.meta.env.VITE_CLIENT_ID,
	redirect_uri: import.meta.env.VITE_IDENTITY_REDIRECT_URI,
	scope: import.meta.env.VITE_SCOPE,
	response_type: import.meta.env.VITE_RESPONSE_TYPE,
	post_logout_redirect_uri: import.meta.env.VITE_POST_LOGOUT_REDIRECT_URI,
	automaticSilentRenew: true,
	includeIdTokenInSilentRenew: true,
};
export const userManager = new UserManager(oidcConfig);

class AuthService extends UserManager {
	UserManager;

	constructor() {
		super(oidcConfig);
		this.UserManager = new UserManager({
			...oidcConfig,
			userStore: new WebStorageStateStore({ store: window.sessionStorage }),
		});
		// Logger
		Log.logger = console;
		Log.level = Log.DEBUG;
		this.UserManager.events.addUserLoaded((user) => {
			if (window.location.href.indexOf('signin-oidc') !== -1) {
				this.navigateToScreen();
			}
		});
		this.UserManager.events.addSilentRenewError((e) => {
			console.log('silent renew error', e.message);
		});

		this.UserManager.events.addAccessTokenExpired(() => {
			console.log('token expired');
			this.renewToken();
		});
	}
	navigateToScreen = () => {
		window.location.replace('/en/dashboard');
	};

	getUser = async (): Promise<User | null> => {
		const user = await userManager.getUser();
		if (!user) {
			return await this.UserManager.signinRedirectCallback();
		}

		if (user.profile && user.profile.role && user.profile.role !== 'Admin') {
			await this.logout();
		}
		return user;
	};

	completedLogin(url?: string | undefined): Promise<User> {
		return this.UserManager.signinRedirectCallback(url);
	}

	login = () => {
		// localStorage.setItem("redirectUri", window.location.pathname);
		this.UserManager.signinRedirect({});
	};

	renewToken = async () => {
		return this.UserManager.signinSilent();
	};

	logout = async () => {
		this.UserManager.signoutRedirect();
		this.UserManager.clearStaleState();
	};

	completeLogoutAsync = async (redirectUrl: string): Promise<void> => {
		this.UserManager.signoutRedirectCallback(redirectUrl);

		this.UserManager.clearStaleState();
	};

	isAuthenticated = () => {
		const oidcStorage = JSON.parse(
			sessionStorage.getItem(
				`oidc.user:${import.meta.env.VITE_AUTHORITY}:${import.meta.env.VITE_CLIENT_ID}`,
			)!,
		);

		return !!oidcStorage && !!oidcStorage.access_token;
	};
}

const authService = new AuthService();

export default authService;
