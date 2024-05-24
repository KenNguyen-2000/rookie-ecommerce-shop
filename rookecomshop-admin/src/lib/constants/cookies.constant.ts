import Cookies from "node_modules/@types/js-cookie"

export const COOKIES_CONFIGS : Cookies.CookieAttributes = {
    secure: true,
    sameSite: "none",

}

export const TOKEN_STRING = "ecommerce-token"