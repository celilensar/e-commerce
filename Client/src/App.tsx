const products = [
  { name: "Product 1", price: 1000 },
  { name: "Product 2", price: 1000 },
  { name: "Product 3", price: 1000 },
];

function App() {
  return (
    <>
      <Header />
      <ProductList products={products} />
    </>
  );
}

function Header() {
  return <h1>Header</h1>;
}

function ProductList(props: { products: { name: string; price: number }[] }) {
  return (
    <>
      <h2>Product List</h2>
      {props.products.map((product, index) => (
        <Product key={index} product={product} />
      ))}
    </>
  );
}

function Product(props: { product: { name: string; price: number } }) {
  return (
    <h3>
      {props.product.name} - ${props.product.price}
    </h3>
  );
}

export default App;
