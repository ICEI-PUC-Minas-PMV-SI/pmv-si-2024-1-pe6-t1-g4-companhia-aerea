import Header from "./Header";

/* eslint-disable react/prop-types */
function Container({ children }) {
  return (
    <>
      <div className="custom-backrgound">
        <Header />
        <div className="d-flex justify-center">
          <div className="vh-6">{children}</div>
        </div>
      </div>
    </>
  );
}

export default Container;
