import CryptoJS from "crypto-js";
import jwtDecode from "jwt-decode";
import Cookies from "js-cookie";

export const encryptData = (name: string, data: string) => {
  const encrypted = CryptoJS.AES.encrypt(
    data,
    process.env.NEXT_PUBLIC_SECRET_KEY as string,
  ).toString();
  localStorage.setItem(name, encrypted);
};

export const decryptData = (name: string): string | null => {
  if (typeof window !== "undefined") {
    const encrypted = Cookies.get(name);
    if (encrypted) {
      try {
        const decrypted = CryptoJS.AES.decrypt(
          encrypted,
          process.env.NEXT_PUBLIC_SECRET_KEY as string,
        ).toString(CryptoJS.enc.Utf8);

        return decrypted;
      } catch (error) {
        console.error("Decode fail: ", error);
        return null;
      }
    } else return null;
  } else return null;
};

export const encryptStr = (value: string): string => {
  return CryptoJS.AES.encrypt(
    value,
    process.env.NEXT_PUBLIC_SECRET_KEY as string,
  ).toString();
};

export const decryptStr = (encrypted: string): any => {
  return CryptoJS.AES.decrypt(
    encrypted,
    process.env.NEXT_PUBLIC_SECRET_KEY as string,
  ).toString(CryptoJS.enc.Utf8);
};
