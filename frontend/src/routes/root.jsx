import { Outlet } from "react-router-dom";
import Container from "../components/Container";

export default function Root() {
  return (
    <>
      <main>
        <Container>
          <Outlet />
        </Container>
        <h1>Fingindo que aqui tem um footer</h1>
      </main>
    </>
  );
}
