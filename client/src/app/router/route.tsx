import { createBrowserRouter } from "react-router-dom";
import HomePage from "../../features/Home/HomePage";
import Catalog from "../../features/catalog/catalog";
import ProductDetails from "../../features/catalog/ProductDetails";
import AboutPage from "../../features/about/AboutPage";
import ContactPage from "../../features/contact/Contactpage";
import App from "../layouts/App";

export const router = createBrowserRouter([
    {
        path: '/',
        element: <App/>,
        children:[
            {path:'', element: <HomePage/>},
            {path:'catalog', element: <Catalog/>},
            {path:'catalog/:id', element: <ProductDetails/>},
            {path:'about', element: <AboutPage/>},
            {path:'contact', element: <ContactPage/>},
        ]
    }
])