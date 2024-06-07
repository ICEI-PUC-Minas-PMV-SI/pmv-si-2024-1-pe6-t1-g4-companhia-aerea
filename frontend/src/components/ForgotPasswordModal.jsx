import React, { useState, useEffect } from "react";
import { Modal, Box, TextField, Button, Typography } from "@mui/material";
import loginData from "../data/loginData.json";

const ForgotPasswordModal = ({ open, onClose }) => {
  const [email, setEmail] = useState("");
  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");
  const [error, setError] = useState("");
  const [success, setSuccess] = useState(false);

  const handlePasswordRecovery = () => {
    const user = loginData.find((user) => user.email === email);

    if (user) {
      setFirstName(user.firstName);
      setLastName(user.lastName);
      setSuccess(true);
    } else {
      setError("Email não encontrado");
    }
  };

  const handleClose = () => {
    setEmail("");
    setFirstName("");
    setLastName("");
    setError("");
    setSuccess(false);
    onClose();
  };

  useEffect(() => {
    let timer;
    if (success) {
      timer = setTimeout(() => {
        handleClose();
      }, 2000);
    }
    return () => clearTimeout(timer);
  }, [success]);

  return (
    <Modal open={open} onClose={handleClose}>
      <Box sx={{ ...modalStyle }}>
        {firstName ? (
          <Box>
            <Typography variant="h6">Recuperação de Senha para:</Typography>
            <Typography>Primeiro Nome: {firstName}</Typography>
            <Typography>Último Nome: {lastName}</Typography>
            <Typography>
              Um link foi enviado para o seu email, confere lá!
            </Typography>
          </Box>
        ) : (
          <Box>
            <Typography variant="h6" gutterBottom>
              Recuperar Senha
            </Typography>
            <TextField
              label="Email"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
              fullWidth
              margin="normal"
            />
            {error && <Typography color="error">{error}</Typography>}
            <Button
              variant="contained"
              color="primary"
              onClick={handlePasswordRecovery}
              fullWidth
              sx={{ mt: 2 }}
            >
              Recuperar
            </Button>
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

export default ForgotPasswordModal;
