import { User, UserManager, UserManagerSettings } from "oidc-client";

const oidcConfig : UserManagerSettings = {
    authority: "https://localhost:7280",
    client_id: "rookEcomShop.react",
    redirect_uri: "http://localhost:5173/authentication/login-callback",
    scope: "rookEcomShop.api openid profile",
    response_type: "code",
    post_logout_redirect_uri: "http://localhost:5173/authentication/logout-callback",
    automaticSilentRenew: true,
    includeIdTokenInSilentRenew: true,
}
const userManager = new UserManager(oidcConfig);

const getUserAsync = async () : Promise<User | null> => {
    return await userManager.getUser();
}

const loginAsync = async () : Promise<void> => {
    await userManager.signinRedirect(); 
}

const completeLoginAsync = async (url: string):Promise<User> => {
    return userManager.signinCallback(url);
}

const renewTokenAsync = async () : Promise<User> => {
    return await userManager.signinSilent();
}

const logoutAsync = async () : Promise<void> => {
    await userManager.signoutRedirect();
}

const completeLogoutAsync = async (redirectUrl: string) : Promise<void> => {
    await userManager.signoutCallback(redirectUrl);
}

const authService = {
    getUserAsync,
    loginAsync,
    completeLoginAsync,
    renewTokenAsync,
    logoutAsync,
    completeLogoutAsync
}

export default authService;