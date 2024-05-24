import { User, UserManager, UserManagerSettings } from 'oidc-client';

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
const userManager = new UserManager(oidcConfig);

const getUserAsync = async (): Promise<User | null> => {
	return await userManager.getUser();
};

const loginAsync = async (): Promise<void> => {
	await userManager.signinRedirect();
};

const completeLoginAsync = async (url: string): Promise<User> => {
	try {
		return await userManager.signinCallback(url);
	} catch (error) {
		console.error(error);
		throw error;
	}
};

const renewTokenAsync = async (): Promise<User> => {
	return await userManager.signinSilent();
};

const logoutAsync = async (): Promise<void> => {
	await userManager.signoutRedirect();
};

const completeLogoutAsync = async (redirectUrl: string): Promise<void> => {
	await userManager.signoutCallback(redirectUrl);
};

const authService = {
	getUserAsync,
	loginAsync,
	completeLoginAsync,
	renewTokenAsync,
	logoutAsync,
	completeLogoutAsync,
};

export default authService;
