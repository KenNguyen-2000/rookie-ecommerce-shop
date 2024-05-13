import type { Metadata } from "next";
import { Inter as FontSans } from "next/font/google";
import "./globals.scss";

import { cn } from "@/lib/utils";
import ReduxProvider from "@/components/hoc/ReduxProvider";
import { ToastContainer } from "react-toastify";

const fontSans = FontSans({
  subsets: ["latin"],
  variable: "--font-sans",
});

export const metadata: Metadata = {
  title: "Rookie Ecommerce Shop",
  description:
    "Rookie Ecommerce Shop is an online store that sells various products. Rookie Ecommerce Shop is a project for learning purposes.",
};

export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  return (
    <html lang="en" suppressHydrationWarning>
      <body
        className={cn(
          "min-h-screen bg-background font-sans antialiased",
          fontSans.variable,
        )}
      >
        <ReduxProvider>
          <ToastContainer
            position="top-center"
            autoClose={5000}
            hideProgressBar={false}
            newestOnTop={false}
            closeOnClick
            rtl={false}
            pauseOnFocusLoss
            draggable
            pauseOnHover
            theme="light"
          />
          {children}
        </ReduxProvider>
      </body>
    </html>
  );
}
