import React, { useState, useEffect } from "react";
import { Modal, Box, TextField, Button, Typography } from "@mui/material";
import { DatePicker } from "@mui/x-date-pickers";
import dayjs from "dayjs";
import api from "../axios/axiosConfig";
import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';

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

const RegisterModal = ({ open, onClose, onResponse }) => {
  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");
  const [email, setEmail] = useState("");
  const [cpf, setCpf] = useState("");
  const [dateBirth, setDateBirth] = useState(null);
  const [password, setPassword] = useState("");
  const [confirmPassword, setConfirmPassword] = useState("");
  const [error, setError] = useState("");
  const [successMessage, setSuccessMessage] = useState("");
  const [isLoading, setLoading] = useState(false);



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
      setSuccessMessage(""); // Limpar a mensagem de sucesso ao abrir o modal
    }
  }, [open]);

  const addUserToLoginData = (newUser) => {
    // Atualizar o JSON de loginData no localStorage
    const existingData = JSON.parse(localStorage.getItem("loginData")) || [];
    const updatedData = [...existingData, newUser];
    localStorage.setItem("loginData", JSON.stringify(updatedData));

    console.log("Novo usuário adicionado:", newUser);
    setSuccessMessage("Usuário cadastrado com sucesso");

    // Exibir um alerta quando os dados forem salvos com sucesso
    alert("Dados cadastrados com sucesso!");
  };

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
      console.log(dateBirth)
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
      onResponse({ response: 'success' })

      setTimeout(() => {
        onClose();
      }, 2000);
      // Fechar o modal

    } catch (error) {
      onResponse({ response: 'error' })
      //setError("Erro ao fazer Cadastrar");
    } finally {
      setLoading(false)
    }

  };

  const handleClose = () => {
    setError("");
    onClose();
  };

  function handleDate(value) {
    //const formattedDate = value ? dayjs(value).format() : "";
    //setDateBirth(formattedDate)
  }

  return (
    <Modal open={open} onClose={handleClose}>
      <Box sx={{ ...style }}>
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
        {/* Exibir a mensagem de sucesso se estiver definida */}
        {successMessage && (
          <Typography color="success">
            "Usuário cadastrado com sucesso"
          </Typography>
        )}
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
        <ToastContainer />
      </Box>

    </Modal>
  );
};

export default RegisterModal;
