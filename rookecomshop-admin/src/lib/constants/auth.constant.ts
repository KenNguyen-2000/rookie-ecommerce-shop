export const IDENTITY_CONFIG = {
	authority: import.meta.env.VITE_AUTHORITY, //(string): The URL of the OIDC provider.
	client_id: import.meta.env.VITE_CLIENT_ID, //(string): Your client application's identifier as registered with the OIDC provider.
	redirect_uri: import.meta.env.VITE_IDENTITY_REDIRECT_URI, //The URI of your client application to receive a response from the OIDC provider.
	login: process.env.REACT_APP_AUTH_URL + '/login',
	automaticSilentRenew: true, //(boolean, default: false): Flag to indicate if there should be an automatic attempt to renew the access token prior to its expiration.
	loadUserInfo: false, //(boolean, default: true): Flag to control if additional identity data is loaded from the user info endpoint in order to populate the user's profile.
	silent_redirect_uri: process.env.REACT_APP_SILENT_REDIRECT_URL, //(string): The URL for the page containing the code handling the silent renew.
	post_logout_redirect_uri: import.meta.env.VITE_POST_LOGOUT_REDIRECT_URI, // (string): The OIDC post-logout redirect URI.
	audience: 'https://example.com', //is there a way to specific the audience when making the jwt
	response_type: import.meta.env.VITE_RESPONSE_TYPE, //(string, default: 'id_token'): The type of response desired from the OIDC provider.
	grantType: 'password',
	scope: import.meta.env.VITE_SCOPE, //(string, default: 'openid'): The scope being requested from the OIDC provider.
	webAuthResponseType: 'id_token token',
	includeIdTokenInSilentRenew: true,
};

export const METADATA_OIDC = {
	issuer: 'https://identityserver',
	jwks_uri: process.env.REACT_APP_AUTH_URL + '/.well-known/openid-configuration/jwks',
	authorization_endpoint: process.env.REACT_APP_AUTH_URL + '/connect/authorize',
	token_endpoint: process.env.REACT_APP_AUTH_URL + '/connect/token',
	userinfo_endpoint: process.env.REACT_APP_AUTH_URL + '/connect/userinfo',
	end_session_endpoint: process.env.REACT_APP_AUTH_URL + '/connect/endsession',
	check_session_iframe: process.env.REACT_APP_AUTH_URL + '/connect/checksession',
	revocation_endpoint: process.env.REACT_APP_AUTH_URL + '/connect/revocation',
	introspection_endpoint: process.env.REACT_APP_AUTH_URL + '/connect/introspect',
};
