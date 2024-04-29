import Navigation from "./Navigation";
import Login from "./Login";
import classes from "./Header.module.css";
import Logo from "./Logo";

function Header() {
  return (
    <>
      <div className={classes.headerContainer}></div>
      <header className="main-header">
        <div className={classes.headerContainer}>
          <div className={classes.itemContainer}>
            <Logo />
            <Navigation />
            <Login />
          </div>
        </div>
      </header>
    </>
  );
}

export default Header;
