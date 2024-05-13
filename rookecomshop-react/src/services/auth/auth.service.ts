import interceptor from "../interceptor";
import { LoginRequestType } from "./auth.type";

const BASE_PATH = "/auth";

const loginService = async (loginRequest: LoginRequestType) => {
  try {
    const res = await interceptor.post(BASE_PATH + `/login`, loginRequest);

    return res.data;
  } catch (error) {
    throw error;
  }
};

const authServices = {
  loginService,
};

export default authServices;
