import React, { useState, useEffect } from "react";
import { Modal, Box, TextField, Button, Typography } from "@mui/material";
import { DatePicker } from "@mui/x-date-pickers";
import CheckCircleOutlineIcon from '@mui/icons-material/CheckCircleOutline';
import ErrorOutlineOutlinedIcon from '@mui/icons-material/ErrorOutlineOutlined';
import dayjs from "dayjs";
import api from "../axios/axiosConfig";

const style = {
  position: "absolute",
  top: "50%",
  left: "50%",
  transform: "translate(-50%, -50%)",
  width: "25%",
  bgcolor: "background.paper",
  boxShadow: 24,
  p: 4,
  borderRadius: 2,
};

const RegisterModal = ({ open, onClose }) => {
  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");
  const [email, setEmail] = useState("");
  const [cpf, setCpf] = useState("");
  const [dateBirth, setDateBirth] = useState(null);
  const [password, setPassword] = useState("");
  const [confirmPassword, setConfirmPassword] = useState("");
  const [error, setError] = useState("");
  const [isLoading, setLoading] = useState(false);
  const [showToast, setShowToast] = useState(false);
  const [typeToast, setTypeToast] = useState('success');

  useEffect(() => {
    let timer;
    if (showToast) {
      timer = setTimeout(() => {
        handleClose();
      }, 2000);
    }
    return () => clearTimeout(timer);
  }, [showToast]);

  useEffect(() => {
    if (open) {
      // Limpar campos do modal
      setDateBirth(null)
      setFirstName("");
      setLastName("");
      setEmail("");
      setCpf("");
      setPassword("");
      setConfirmPassword("");
      setError("");
      setTypeToast('success')
      setShowToast(false);
    }
  }, [open]);


  const handleRegister = async () => {
    // Validar campos obrigatórios
    if (
      !firstName ||
      !lastName ||
      !email ||
      !cpf ||
      !password ||
      !confirmPassword ||
      !dateBirth
    ) {
      setError("Todos os campos são obrigatórios");
      return;
    }

    // Validar CPF
    const normalizedCpf = cpf.replace(/\D/g, "");
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

    // Limpar a mensagem de erro
    setError("");

    // // Verificar se as senhas coincidem
    if (password !== confirmPassword) {
      setError("As senhas não coincidem");
      return;
    }

    setLoading(true)

    // Adicionar novo usuário ao JSON de loginData
    const newUser = {
      firstName,
      lastName,
      email,
      //cpf: normalizedCpf,
      password,
      dateBirth
    };

    try {
      // Fazer a solicitação POST com Axios
      const response = await api.post('/api/Users', newUser);
      setTypeToast('success')
      setShowToast(true)

    } catch (error) {
      setTypeToast('error')
      setShowToast(true)
    } finally {
      setLoading(false)
    }

  };

  const handleClose = () => {
    setError("");
    setTypeToast('success')
    setShowToast(false);
    onClose();
  };

  return (
    <Modal open={open} onClose={handleClose}>
      <Box sx={{ ...style }}>
        {showToast ? (
          <Box sx={{ textAlign: "center" }}>
            {typeToast == 'success' ?
              <CheckCircleOutlineIcon color="success" sx={{ fontSize: 40 }} />
              : <ErrorOutlineOutlinedIcon color="error" sx={{ fontSize: 40 }} />}
            <Typography variant="h6">
              {typeToast == 'success' ? 'Usuário Cadastrado com sucesso'
                : 'Falha ao cadastrar Usuário'}
            </Typography>
          </Box>
        ) : (
          <Box>
            <Typography variant="h6" gutterBottom>
              Cadastro
            </Typography>
            <TextField
              label="Nome"
              value={firstName}
              onChange={(e) => setFirstName(e.target.value)}
              fullWidth
              margin="normal"
            />
            <TextField
              label="Sobrenome"
              value={lastName}
              onChange={(e) => setLastName(e.target.value)}
              fullWidth
              margin="normal"
            />

            <DatePicker
              label="Data de Nascimento"
              value={dateBirth ? dayjs(dateBirth) : null}
              fullWidth
              sx={{ width: '100%', margin: "10px 0" }}
              onChange={(newValue) => {
                setDateBirth(newValue ? newValue.toISOString() : null);
              }}
              renderInput={(params) => <TextField {...params} />}
              disableFuture
              minDate={dayjs('1920-01-01')}
            />
            <TextField
              label="Email"
              type="email"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
              fullWidth
              margin="normal"
            />
            <TextField
              label="CPF"
              value={cpf}
              onChange={(e) => setCpf(e.target.value)}
              fullWidth
              margin="normal"
            />
            <TextField
              label="Senha"
              type="password"
              value={password}
              onChange={(e) => {
                setPassword(e.target.value);
                setError(""); // Limpar o erro ao editar a senha
              }}
              fullWidth
              margin="normal"
            />
            <TextField
              label="Confirme a senha"
              type="password"
              value={confirmPassword}
              onChange={(e) => {
                setConfirmPassword(e.target.value);
                setError(""); // Limpar o erro ao editar a senha
              }}
              fullWidth
              margin="normal"
            />
            {error && <Typography color="error">{error}</Typography>}
            <Button
              variant="contained"
              color="primary"
              onClick={handleRegister}
              fullWidth
              sx={{ mt: 2 }}
            >
              {isLoading ? 'Carregando...' : 'Cadastrar'}
            </Button>
          </Box>

        )}
      </Box>



    </Modal>
  );
};

export default RegisterModal;
