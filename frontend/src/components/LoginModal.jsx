import React, { useState, useEffect } from "react";
import { Modal, Box, TextField, Button, Typography } from "@mui/material";
import CheckCircleOutlineIcon from "@mui/icons-material/CheckCircleOutline";
import PropTypes from "prop-types";
import loginData from "../data/loginData.json";

const style = {
  position: "absolute",
  top: "50%",
  left: "50%",
  transform: "translate(-50%, -50%)",
  width: 400,
  bgcolor: "background.paper",
  border: "2px solid #000",
  boxShadow: 24,
  p: 4,
};

const LoginModal = ({ open, onClose, onForgotPasswordClick }) => {
  const [cpf, setCpf] = useState("");
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [success, setSuccess] = useState(false);
  const [error, setError] = useState("");

  useEffect(() => {
    if (open) {
      // Limpar campos do modal
      setCpf("");
      setEmail("");
      setPassword("");
      setError("");
      setSuccess(false);
    }
  }, [open]);

  useEffect(() => {
    let timer;
    if (success) {
      timer = setTimeout(() => {
        handleClose();
      }, 1000);
    }
    return () => clearTimeout(timer);
  }, [success]);

  const normalizeCPF = (cpf) => {
    return cpf.replace(/\D/g, "");
  };

  const handleLogin = () => {
    const normalizedCpf = normalizeCPF(cpf);

    // Validar CPF
    if (!/^\d{11}$/.test(normalizedCpf)) {
      setError("CPF inválido");
      return;
    }

    // Validar Email
    if (!/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(email)) {
      setError("Email inválido");
      return;
    }

    // Validar Senha
    if (!/^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$/.test(password)) {
      setError("A senha deve conter letras e números");
      return;
    }

    // Verificar credenciais
    const user = loginData.find(
      (user) =>
        normalizeCPF(user.cpf) === normalizedCpf &&
        user.email === email &&
        user.password === password
    );

    if (user) {
      setSuccess(true);
    } else {
      setError("Credenciais inválidas");
    }
  };

  const handleClose = () => {
    setSuccess(false);
    setError("");
    setCpf("");
    setEmail("");
    setPassword("");
    onClose();
  };

  return (
    <Modal open={open} onClose={handleClose}>
      <Box sx={{ ...modalStyle }}>
        {success ? (
          <Box sx={{ textAlign: "center" }}>
            <CheckCircleOutlineIcon color="success" sx={{ fontSize: 40 }} />
            <Typography variant="h6">Login efetuado com sucesso</Typography>
          </Box>
        ) : (
          <Box>
            <Typography variant="h6" gutterBottom>
              Login
            </Typography>
            <TextField
              label="CPF"
              value={cpf}
              onChange={(e) => setCpf(e.target.value)}
              fullWidth
              margin="normal"
            />
            <TextField
              label="Email"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
              fullWidth
              margin="normal"
            />
            <TextField
              label="Senha"
              type="password"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
              fullWidth
              margin="normal"
            />
            {error && <Typography color="error">{error}</Typography>}
            <Button
              variant="contained"
              color="primary"
              onClick={handleLogin}
              fullWidth
              sx={{ mt: 2 }}
            >
              Entrar
            </Button>
            <Typography
              variant="body2"
              sx={{ mt: 2, textDecoration: "underline", cursor: "pointer" }}
              onClick={onForgotPasswordClick}
            >
              Esqueceu sua senha?
            </Typography>
          </Box>
        )}
      </Box>
    </Modal>
  );
};

const modalStyle = {
  position: "absolute",
  top: "50%",
  left: "50%",
  transform: "translate(-50%, -50%)",
  width: 300,
  bgcolor: "background.paper",
  boxShadow: 24,
  p: 4,
  borderRadius: 2,
};
LoginModal.propTypes = {
  open: PropTypes.bool.isRequired,
  onClose: PropTypes.func.isRequired,
  onForgotPasswordClick: PropTypes.func.isRequired,
};

export default LoginModal;
