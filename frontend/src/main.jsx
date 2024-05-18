import React from "react";
import ReactDOM from "react-dom/client";
import "./index.css";
import { RouterProvider, createBrowserRouter } from "react-router-dom";
import Root from "./routes/root.jsx";
import HomePage from "./pages/Home.jsx";
import { LocalizationProvider } from "@mui/x-date-pickers/LocalizationProvider";
import { AdapterDayjs } from "@mui/x-date-pickers/AdapterDayjs";
import SelectionFlightPage from "./pages/SelectionFlight.jsx";
import ReservationPage from "./pages/Reservation.jsx";
import FAQPage from "./pages/FrequentlyAsked.jsx";

const router = createBrowserRouter([
  {
    path: "/",
    element: <Root />,
    children: [
      {
        index: true,
        element: <HomePage />,
      },
      {
        path: "selecao-voo",
        element: <SelectionFlightPage />,
      },
      {
        path: "selecao-voo/:",
        element: <SelectionFlightPage />,
      },
      {
        path: "reservas",
        element: <ReservationPage />,
      },
      {
        path: "faq",
        element: <FAQPage />,
      },
    ],
  },
]);

ReactDOM.createRoot(document.getElementById("root")).render(
  <React.StrictMode>
    <LocalizationProvider dateAdapter={AdapterDayjs}>
      <RouterProvider router={router} />
    </LocalizationProvider>
  </React.StrictMode>
);
