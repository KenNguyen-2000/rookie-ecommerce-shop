import { useAppDispatch, useAppSelector } from "@/redux/reduxHooks";
import { completedLoginAsync, completedLogoutAsync, loginAsync, logoutAsync } from "@/redux/thunks/auth.thunk";
import { ReactNode, useEffect } from "react";
import { useNavigate, useParams } from "react-router-dom";

const OidcAuthProvider = ({children}: {children?: ReactNode}) => {
    const navigate = useNavigate();
  const dispatch = useAppDispatch();
  const { action } = useParams<{ action: string }>();
  const {isAuthenticated} = useAppSelector((state) => state.auth); 

  useEffect(() => {
    switch (action) {
      case "login":
        dispatch(loginAsync());
        break;
      case "login-callback":
        console.log("Dispatch login")
        dispatch(completedLoginAsync());
        navigate("/");
        break;
      case "logout":
        dispatch(logoutAsync());
        break;
      case "logout-callback":
        dispatch(completedLogoutAsync());
        navigate("/");
        break;
      default:
        break;
    }
  }, [dispatch, navigate, action]);

  if(!isAuthenticated)
    return null;

  return (
    <>
        {children}
    </>
  )
}

export default OidcAuthProvider