import { useAppSelector } from "@/redux/reduxHooks";
import { useEffect } from "react";
import { Outlet, useNavigate } from "react-router-dom";

const PrivateRoute = () => {
  const navigate = useNavigate();
  const { isAuthenticated } = useAppSelector((state) => state.auth);
  useEffect(() => {
    // if(!isAuthenticated)
    //   {
    //     navigate('/authentication/login')
    //   }
  }, [navigate, isAuthenticated]);
  return isAuthenticated ? <Outlet /> : null;
};

export default PrivateRoute;
