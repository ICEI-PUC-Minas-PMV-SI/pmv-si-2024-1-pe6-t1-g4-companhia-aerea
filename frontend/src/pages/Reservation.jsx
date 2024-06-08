import React, { useState } from "react";
import {
  Box,
  Container,
  Typography,
  TextField,
  MenuItem,
  Button,
  Dialog,
  DialogTitle,
  DialogContent,
  DialogContentText,
  DialogActions,
} from "@mui/material";
import reservationsData from "../data/reservations.json";

const cities = [
  "São Paulo",
  "Rio de Janeiro",
  "Salvador",
  "Brasí­lia",
  "Fortaleza",
  "Belo Horizonte",
  "Manaus",
  "Curitiba",
  "Recife",
  "Goiânia",
];

function ReservationPage() {
  const [searchType, setSearchType] = useState("");
  const [reservationNumber, setReservationNumber] = useState("");
  const [origin, setOrigin] = useState("");
  const [searchResult, setSearchResult] = useState(null);
  const [searchError, setSearchError] = useState(false);
  const [openModal, setOpenModal] = useState(false);

  const handleSearchTypeChange = (event) => {
    setSearchType(event.target.value);
    setSearchError(false);
  };

  const handleReservationNumberChange = (event) => {
    setReservationNumber(event.target.value);
    setSearchError(false);
  };

  const handleOriginChange = (event) => {
    setOrigin(event.target.value);
    setSearchError(false); // Reset error state
  };

  const handleSearch = (event) => {
    event.preventDefault();
    let result = null;

    if (searchType === "numero") {
      result = reservationsData.find(
        (reservation) => reservation.numero === reservationNumber
      );
    } else if (searchType === "numeroOrigem") {
      result = reservationsData.find(
        (reservation) =>
          reservation.numero === reservationNumber &&
          reservation.origem === origin
      );
    }

    if (result) {
      setSearchResult(result);
      setSearchError(false);
      setOpenModal(true);
    } else {
      setSearchResult(null);
      setSearchError(true);
    }
  };

  const handleCloseModal = () => {
    setOpenModal(false);
  };

  return (
    <Box
      id="reservas"
      sx={(theme) => ({
        width: "100%",
        backgroundImage:
          theme.palette.mode === "light"
            ? "linear-gradient(180deg, #CEE5FD, #FFF)"
            : `linear-gradient(#02294F, ${alpha("#090E10", 0.0)})`,
        backgroundSize: "100% 20%",
        backgroundRepeat: "no-repeat",
      })}
    >
      <Container
        sx={{
          display: "flex",
          flexDirection: "column",
          alignItems: "center",
          pt: { xs: 14, sm: 20 },
          pb: { xs: 8, sm: 12 },
        }}
      >
        <Typography variant="h1" sx={{ mb: 4 }}>
          Reservas
        </Typography>

        <form onSubmit={handleSearch}>
          <TextField
            select
            label="Buscar reserva por"
            value={searchType}
            onChange={handleSearchTypeChange}
            fullWidth
            sx={{ mb: 2 }}
          >
            <MenuItem value="numero">Número de reserva</MenuItem>
            <MenuItem value="numeroOrigem">Número de reserva + Origem</MenuItem>
          </TextField>

          {searchType === "numero" && (
            <TextField
              label="Número da reserva"
              value={reservationNumber}
              onChange={handleReservationNumberChange}
              fullWidth
              required
              sx={{ mb: 2 }}
            />
          )}

          {searchType === "numeroOrigem" && (
            <>
              <TextField
                label="Número da reserva"
                value={reservationNumber}
                onChange={handleReservationNumberChange}
                fullWidth
                required
                sx={{ mb: 2 }}
              />
              <TextField
                select
                label="Origem"
                value={origin}
                onChange={handleOriginChange}
                fullWidth
                required
                sx={{ mb: 2 }}
              >
                {cities.map((city) => (
                  <MenuItem key={city} value={city}>
                    {city}
                  </MenuItem>
                ))}
              </TextField>
            </>
          )}

          <Button type="submit" variant="contained" color="primary">
            Buscar
          </Button>
        </form>

        {searchError && (
          <Typography variant="body1" color="error" sx={{ mt: 2 }}>
            Reserva não encontrada no sistema.
          </Typography>
        )}

        <Dialog open={openModal} onClose={handleCloseModal}>
          <DialogTitle>Detalhes da Reserva</DialogTitle>
          <DialogContent>
            <DialogContentText>
              Número: {searchResult?.numero} <br />
              Origem: {searchResult?.origem} <br />
              Nome: {searchResult?.nome} <br />
              Data: {searchResult?.data}
            </DialogContentText>
          </DialogContent>
          <DialogActions>
            <Button onClick={handleCloseModal} color="primary">
              Fechar
            </Button>
          </DialogActions>
        </Dialog>
      </Container>
    </Box>
  );
}

export default ReservationPage;
