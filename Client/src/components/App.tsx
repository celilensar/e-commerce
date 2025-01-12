import Header from "./Header";
import { Container, CssBaseline } from "@mui/material";
import { Outlet } from "react-router";

function App() {
  return (
    <>
      <CssBaseline />
      <Header />
      <Container>
        {/* <ProductList products={products} addProduct={addProduct} /> */}
        <Outlet />
      </Container>
    </>
  );
}

export default App;
