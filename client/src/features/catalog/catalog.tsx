import { Fragment, useEffect, useState } from "react"
import { Product } from "../../product";
import ProductList from "./ProductList";

export default function Catalog() {

    const [products, setProducts] = useState<Product[]>([]);

    useEffect(() => {
        fetch('http://localhost:5000/api/products')
            .then(response => response.json())
            .then(data => setProducts(data))
    }, [])
    
    return (
        <Fragment>
            <ProductList products={products} />
        </Fragment>
    )

}