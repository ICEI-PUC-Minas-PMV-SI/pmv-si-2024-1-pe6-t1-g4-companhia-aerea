import * as React from "react";
import PropTypes from "prop-types";
import Box from "@mui/material/Box";
import AppBar from "@mui/material/AppBar";
import Toolbar from "@mui/material/Toolbar";
import Button from "@mui/material/Button";
import Container from "@mui/material/Container";
import Divider from "@mui/material/Divider";
import Typography from "@mui/material/Typography";
import MenuItem from "@mui/material/MenuItem";
import Drawer from "@mui/material/Drawer";
import MenuIcon from "@mui/icons-material/Menu";
import ToggleColorMode from "./ToggleColorMode";
import uaiFly from "../assets/uaifly.svg";
import { useNavigate } from "react-router-dom";
import LoginModal from "../components/LoginModal";
import ForgotPasswordModal from "../components/ForgotPasswordModal";
import RegisterModal from "../components/RegisterModal";
import { AccountCircleRounded as AccountCircleRoundedIcon, Logout as LogoutIcon } from "@mui/icons-material";
import IconButton from "@mui/material/IconButton";
import Menu from "@mui/material/Menu";
import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';

const logoStyle = {
  width: "140px",
  height: "auto",
  cursor: "pointer",
};

function NavAppBar({ mode, toggleColorMode }) {
  const [open, setOpen] = React.useState(false);
  const [loginOpen, setLoginOpen] = React.useState(false);
  const [forgotPasswordOpen, setForgotPasswordOpen] = React.useState(false);
  const [registerOpen, setRegisterOpen] = React.useState(false);
  const [isLoggedIn, setIsLoggedIn] = React.useState(false);
  const navigate = useNavigate();
  const [anchorEl, setAnchorEl] = React.useState(null);

  const toggleDrawer = (newOpen) => () => {
    setOpen(newOpen);
  };

  React.useEffect(() => {
    const user = localStorage.getItem('user');
    if (user) {
      setIsLoggedIn(true);
    }
  }, []);

  const scrollToSection = (sectionId) => {
    const sectionElement = document.getElementById(sectionId);
    const offset = 128;
    if (sectionElement) {
      const targetScroll = sectionElement.offsetTop - offset;
      sectionElement.scrollIntoView({ behavior: "smooth" });
      window.scrollTo({
        top: targetScroll,
        behavior: "smooth",
      });
      setOpen(false);
    }
  };

  const handleLogoClick = () => {
    navigate("/");
  };

  const handleLoginOpen = () => setLoginOpen(true);
  const handleLoginClose = () => setLoginOpen(false);

  const handleForgotPasswordOpen = () => {
    setLoginOpen(false);
    setForgotPasswordOpen(true);
  };
  const handleForgotPasswordClose = () => setForgotPasswordOpen(false);

  const handleRegisterOpen = () => setRegisterOpen(true);
  const handleRegisterClose = () => setRegisterOpen(false);

  const handleLoginSuccess = (user) => {
    setIsLoggedIn(true);
    localStorage.setItem('user', JSON.stringify(user)); // Salva o usuário no localStorage
  };

  const handleResponse = (response) => {
    if (response.response == 'success') {
      toast.success('Usuário cadastrado com sucesso', {
        autoClose: 1500
      });
    }
    if (response.response == 'error') {
      toast.error('Ocorreu um erro!', {
        autoClose: 1500
      });
    }
  };


  const handleLogout = () => {
    setIsLoggedIn(false);
    localStorage.removeItem('user');
    setAnchorEl(null);
  };

  const handleMenuOpen = (event) => {
    setAnchorEl(event.currentTarget);
  };

  const handleMenuClose = () => {
    setAnchorEl(null);
  };

  return (
    <div>
      <AppBar
        position="fixed"
        sx={{
          boxShadow: 0,
          bgcolor: "transparent",
          backgroundImage: "none",
          mt: 2,
        }}
      >
        <Container maxWidth="lg">
          <Toolbar
            variant="regular"
            sx={(theme) => ({
              display: "flex",
              alignItems: "center",
              justifyContent: "space-between",
              flexShrink: 0,
              borderRadius: "999px",
              bgcolor:
                theme.palette.mode === "light"
                  ? "rgba(255, 255, 255, 0.4)"
                  : "rgba(0, 0, 0, 0.4)",
              backdropFilter: "blur(24px)",
              maxHeight: 40,
              border: "1px solid",
              borderColor: "divider",
              boxShadow:
                theme.palette.mode === "light"
                  ? `0 0 1px rgba(85, 166, 246, 0.1), 1px 1.5px 2px -1px rgba(85, 166, 246, 0.15), 4px 4px 12px -2.5px rgba(85, 166, 246, 0.15)`
                  : "0 0 1px rgba(2, 31, 59, 0.7), 1px 1.5px 2px -1px rgba(2, 31, 59, 0.65), 4px 4px 12px -2.5px rgba(2, 31, 59, 0.65)",
            })}
          >
            <Box
              sx={{
                flexGrow: 1,
                display: "flex",
                alignItems: "center",
                ml: "-18px",
                px: 0,
              }}
            >
              <img
                src={uaiFly}
                style={logoStyle}
                alt="logo of sitemark"
                onClick={handleLogoClick}
              />
              <Box sx={{ display: { xs: "none", md: "flex" } }}>
                <MenuItem
                  sx={{ py: "6px", px: "12px" }}
                  onClick={() => {
                    navigate("/comprar");
                  }}
                >
                  <Typography variant="body2" color="text.primary">
                    Comprar
                  </Typography>
                </MenuItem>
                <MenuItem
                  onClick={() => {
                    navigate("/reservas");
                  }}
                >
                  <Typography variant="body2" color="text.primary">
                    Reservas
                  </Typography>
                </MenuItem>
                <MenuItem
                  onClick={() => scrollToSection("highlights")}
                  sx={{ py: "6px", px: "12px" }}
                >
                  <Typography variant="body2" color="text.primary">
                    Check-in
                  </Typography>
                </MenuItem>
                {/* <MenuItem
                  onClick={() => scrollToSection("pricing")}
                  sx={{ py: "6px", px: "12px" }}
                >
                  <Typography variant="body2" color="text.primary">
                    Ofertas
                  </Typography>
                </MenuItem> */}
                <MenuItem
                  onClick={() => {
                    navigate("/faq");
                  }}
                >
                  <Typography variant="body2" color="text.primary">
                    FAQ
                  </Typography>
                </MenuItem>
              </Box>
            </Box>
            <Box
              sx={{
                display: { xs: "none", md: "flex" },
                gap: 0.5,
                alignItems: "center",
              }}
            >
              <ToggleColorMode mode={mode} toggleColorMode={toggleColorMode} />
              {isLoggedIn ? (
                <>
                  <IconButton
                    edge="end"
                    color="inherit"
                    aria-controls="user-menu"
                    aria-haspopup="true"
                    onClick={handleMenuOpen}
                  >
                    <AccountCircleRoundedIcon sx={{ color: "#1976d2" }} />
                  </IconButton>
                  <Menu
                    id="user-menu"
                    anchorEl={anchorEl}
                    open={Boolean(anchorEl)}
                    onClose={handleMenuClose}
                  >
                    <MenuItem onClick={handleLogout}><LogoutIcon sx={{ marginRight: "8px" }} /> Sair</MenuItem>
                  </Menu>
                </>
              ) : (
                <>
                  <Button
                    color="primary"
                    variant="text"
                    size="small"
                    component="a"
                    target="_blank"
                    onClick={handleLoginOpen}
                  >
                    Login
                  </Button>
                  <Button
                    color="primary"
                    variant="contained"
                    size="small"
                    component="a"
                    target="_blank"
                    onClick={handleRegisterOpen}
                  >
                    Cadastre-se
                  </Button>
                </>
              )}
            </Box>
            <Box sx={{ display: { sm: "", md: "none" } }}>
              <Button
                variant="text"
                color="primary"
                aria-label="menu"
                sx={{ minWidth: "30px", p: "4px" }}
              >
                <MenuIcon />
              </Button>
              <Drawer anchor="right" open={open} onClose={toggleDrawer(false)}>
                <Box
                  sx={{
                    minWidth: "60dvw",
                    p: 2,
                    backgroundColor: "background.paper",
                    flexGrow: 1,
                  }}
                >
                  <Box
                    sx={{
                      display: "flex",
                      flexDirection: "column",
                      alignItems: "end",
                      flexGrow: 1,
                    }}
                  >
                    <ToggleColorMode
                      mode={mode}
                      toggleColorMode={toggleColorMode}
                    />
                  </Box>
                  <MenuItem onClick={() => scrollToSection("features")}>
                    Comprar
                  </MenuItem>
                  <MenuItem onClick={() => scrollToSection("testimonials")}>
                    Reservas
                  </MenuItem>
                  <MenuItem onClick={() => scrollToSection("highlights")}>
                    Check-in
                  </MenuItem>
                  <MenuItem onClick={() => scrollToSection("pricing")}>
                    Ofertas
                  </MenuItem>
                  <MenuItem onClick={() => scrollToSection("faq")}>
                    FAQ
                  </MenuItem>
                  <Divider />
                  <MenuItem>
                    <Button
                      color="primary"
                      variant="contained"
                      component="a"
                      target="_blank"
                      sx={{ width: "100%" }}
                      onClick={handleRegisterOpen}
                    >
                      Cadastre-se
                    </Button>
                  </MenuItem>
                  <MenuItem>
                    <Button
                      color="primary"
                      variant="outlined"
                      component="a"
                      target="_blank"
                      sx={{ width: "100%" }}
                      onClick={handleLoginOpen}
                    >
                      Login
                    </Button>
                  </MenuItem>
                </Box>
              </Drawer>
            </Box>
          </Toolbar>
        </Container>
      </AppBar>
      <LoginModal
        open={loginOpen}
        onClose={handleLoginClose}
        onForgotPasswordClick={handleForgotPasswordOpen}
        onLoginSuccess={handleLoginSuccess}
      />
      <ForgotPasswordModal
        open={forgotPasswordOpen}
        onClose={handleForgotPasswordClose}

      />
      <RegisterModal
        open={registerOpen} // Passa o estado de abertura do modal de cadastro
        onClose={handleRegisterClose}
      // Passa o manipulador de eventos para fechar o modal de cadastro
      />
      <ToastContainer />
    </div>
  );
}

NavAppBar.propTypes = {
  mode: PropTypes.oneOf(["dark", "light"]).isRequired,
  toggleColorMode: PropTypes.func.isRequired,
};

export default NavAppBar;
