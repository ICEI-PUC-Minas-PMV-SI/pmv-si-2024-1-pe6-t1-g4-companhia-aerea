import classes from "./Navigation.module.css";
import buy from "../assets/cart.svg";
import reserve from "../assets/reserve.svg";
import check from "../assets/check.svg";
import offer from "../assets/offer.svg";


function Navigation() {
  return (
    <div className={classes.nav}>
      <nav>
        <ul className={classes.navigationItems}>
          <div>
            <li className={classes.navigationItem}>
              <button className={classes.menuItem}>
                <span className={classes.iconContainer}>
                  <img src={buy} />
                </span>
                Comprar
              </button>
            </li>
          </div>
          <div>
            <li className={classes.navigationItem}>
              <button className={classes.menuItem}>
                <span className={classes.iconContainer}>
                  <img src={reserve} />
                </span>
                Reservas
              </button>
            </li>
          </div>
          <div>
            <li className={classes.navigationItem}>
              <button className={classes.menuItem}>
                <span className={classes.iconContainer}>
                  <img src={check} />
                </span>
                Check-in
              </button>
            </li>
          </div>
          <div>
            <li className={classes.navigationItem}>
              <button className={classes.menuItem}>
                <span className={classes.iconContainer}>
                  <img src={offer} />
                </span>
                Ofertas
              </button>
            </li>
          </div>
        </ul>
      </nav>
    </div>
  );
}

export default Navigation;
