import { DashboardPage } from '@/pages/dashboard/page';
import NotFoundPage from '@/pages/errors/NotFoundPage';
import { ProductPage } from '@/pages/products/page';
import { ProductDetailPage } from '@/pages/products/product-detail/page';
import { TooltipProvider } from '@radix-ui/react-tooltip';
import {
    createBrowserRouter,
    RouterProvider,
  } from "react-router-dom";

const RookEcomShopRoutes = () => {
    const router = createBrowserRouter([
        {
            path: "/products",
            children: [
              {
                index: true,
                element: <ProductPage />,
              },
              {
                path: ":id",
                element: <ProductDetailPage />,
              },
            ]
        },
        {
            path: "/",
            element: <DashboardPage />,
        },
        {
          path: "*",
          element: <NotFoundPage />,
        }
    ])
  return <TooltipProvider>
    <RouterProvider router={router} />
  </TooltipProvider>
}

export default RookEcomShopRoutes