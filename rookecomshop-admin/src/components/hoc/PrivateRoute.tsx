import { TOKEN_STRING } from "@/lib/constants/cookies.constant";
import { useAppDispatch, useAppSelector } from "@/redux/reduxHooks";
import { getUserAsync } from "@/redux/thunks/auth.thunk";
import Cookies from "js-cookie";
import { useEffect } from "react";
import { Outlet, useNavigate } from "react-router-dom";

const PrivateRoute = () => {
  const navigate = useNavigate();
  const { isAuthenticated } = useAppSelector((state) => state.auth);
  const dispatch = useAppDispatch();
  useEffect(() => {
    if (!isAuthenticated) {
      const token = Cookies.get(TOKEN_STRING);
      if (!token) {
        navigate("/authentication/login");
      } else {
        dispatch(getUserAsync());
      }
    }
  }, [navigate, isAuthenticated, dispatch]);
  return isAuthenticated ? <Outlet /> : null;
};

export default PrivateRoute;
