import { createBrowserRouter } from "react-router-dom";
import App from "@/App.tsx";
import Login from "@/Pages/Login";
import Signup from "@/Pages/Signup";

export const router = createBrowserRouter([
  {
    path: "/",
    element: <App />,
    children: [
      { path: "login", element: <Login /> },
      { path: "signup", element: <Signup /> },
    ],
  },
]);
