import { OidcAuthProvider, ReduxProvider } from "@/components/hoc";
import { DashboardPage } from "@/pages/dashboard/page";
import NotFoundPage from "@/pages/errors/NotFoundPage";
import CreateProductPage from "@/pages/products/create/page";
import { ProductPage } from "@/pages/products/page";
import { ProductDetailPage } from "@/pages/products/product-detail/page";
import { TooltipProvider } from "@radix-ui/react-tooltip";
import {
  createBrowserRouter,
  createRoutesFromElements,
  Route,
  RouterProvider,
} from "react-router-dom";

const RookEcomShopRoutes = () => {
  const router = createBrowserRouter(
    createRoutesFromElements(
      <Route>
        <Route path="/authentication/:action" element={<OidcAuthProvider />} />
        <Route path="/">
          <Route index element={<DashboardPage />} />
          <Route path="/products">
            <Route index element={<ProductPage />} />
            <Route path=":id" element={<ProductDetailPage />} />
            <Route path="create" element={<CreateProductPage />} />
          </Route>
        </Route>
        <Route path="*" element={<NotFoundPage />} />
      </Route>,
    ),
  );
  return (
    <TooltipProvider>
      <ReduxProvider>
        <RouterProvider router={router} />
      </ReduxProvider>
    </TooltipProvider>
  );
};

export default RookEcomShopRoutes;
