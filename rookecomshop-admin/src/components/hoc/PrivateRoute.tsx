import Cookies from 'js-cookie';
import  { useEffect, useState } from 'react'
import { Outlet, useNavigate } from 'react-router-dom';

const PrivateRoute = () => {
    const [isAuth, setIsAuth] = useState(false)
    const navigate = useNavigate();
    useEffect(() => {
      const token = Cookies.get('rookecomshop-access-token')
  
      if(token)
        {
            setIsAuth(true)
        }else
        {
          navigate('/login')
        }
    },[navigate])
    return isAuth ? (
      <Outlet />
    ) : null
  }

export default PrivateRoute