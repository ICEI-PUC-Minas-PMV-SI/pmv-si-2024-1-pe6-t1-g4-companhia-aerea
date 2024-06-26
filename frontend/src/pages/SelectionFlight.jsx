import { useState } from "react";
import { Link, useLocation } from "react-router-dom";
import {
  Box,
  Button,
  Step,
  StepLabel,
  Stepper,
  Typography,
  Card,
  Container,
  CardContent,
  List,
  ListItem,
  Divider,
  CardHeader,
  TextField,
  Autocomplete,
  Chip,
} from "@mui/material";
import FlightTakeoffIcon from "@mui/icons-material/FlightTakeoff";
import ArrowRightAltIcon from "@mui/icons-material/ArrowRightAlt";
import FlightLandIcon from "@mui/icons-material/FlightLand";
import AirlineSeatReclineExtraIcon from "@mui/icons-material/AirlineSeatReclineExtra";
import LuggageIcon from "@mui/icons-material/Luggage";
import dayjs from "dayjs";

const steps = [
  "Selecionar voo de ida",
  "Selecionar voo de volta",
  "Dados pessoais",
  "Checkout",
];

const airplaneSeats = [
  { seat: "A1", available: true },
  { seat: "A2", available: true },
  { seat: "A3", available: true },
  { seat: "A4", available: true },
  { seat: "A5", available: true },
  { seat: "A6", available: true },
  { seat: "A7", available: true },
  { seat: "A8", available: true },
  { seat: "B1", available: true },
  { seat: "B2", available: true },
  { seat: "B3", available: true },
  { seat: "B4", available: true },
  { seat: "B5", available: true },
  { seat: "B6", available: true },
  { seat: "B7", available: true },
  { seat: "B8", available: true },
  { seat: "C1", available: true },
  { seat: "C2", available: true },
  { seat: "C3", available: true },
  { seat: "C4", available: true },
  { seat: "C5", available: true },
  { seat: "C6", available: true },
  { seat: "C7", available: true },
  { seat: "C8", available: true },
  { seat: "D1", available: true },
  { seat: "D2", available: true },
  { seat: "D3", available: true },
  { seat: "D4", available: true },
  { seat: "D5", available: true },
  { seat: "D6", available: true },
  { seat: "D7", available: true },
  { seat: "D8", available: true },
  { seat: "E1", available: true },
  { seat: "E2", available: true },
  { seat: "E3", available: true },
  { seat: "E4", available: true },
  { seat: "E5", available: true },
  { seat: "E6", available: true },
  { seat: "E7", available: true },
  { seat: "E8", available: true },
  { seat: "F1", available: true },
  { seat: "F2", available: true },
  { seat: "F3", available: true },
  { seat: "F4", available: true },
  { seat: "F5", available: true },
  { seat: "F6", available: true },
  { seat: "F7", available: true },
  { seat: "F8", available: true },
  { seat: "G1", available: true },
  { seat: "G2", available: true },
  { seat: "G3", available: true },
  { seat: "G4", available: true },
  { seat: "G5", available: true },
  { seat: "G6", available: true },
  { seat: "G7", available: true },
  { seat: "G8", available: true },
  { seat: "H1", available: true },
  { seat: "H2", available: true },
  { seat: "H3", available: true },
  { seat: "H4", available: true },
  { seat: "H5", available: true },
  { seat: "H6", available: true },
  { seat: "H7", available: true },
  { seat: "H8", available: true },
  { seat: "I1", available: true },
  { seat: "I2", available: true },
  { seat: "I3", available: true },
  { seat: "I4", available: true },
  { seat: "I5", available: true },
  { seat: "I6", available: true },
  { seat: "I7", available: true },
  { seat: "I8", available: true },
  { seat: "J1", available: true },
  { seat: "J2", available: true },
  { seat: "J3", available: true },
  { seat: "J4", available: true },
  { seat: "J5", available: true },
  { seat: "J6", available: true },
  { seat: "J7", available: true },
  { seat: "J8", available: true },
  { seat: "K1", available: true },
  { seat: "K2", available: true },
  { seat: "K3", available: true },
  { seat: "K4", available: true },
  { seat: "K5", available: true },
  { seat: "K6", available: true },
  { seat: "K7", available: true },
  { seat: "K8", available: true },
  { seat: "L1", available: true },
  { seat: "L2", available: true },
  { seat: "L3", available: true },
  { seat: "L4", available: true },
  { seat: "L5", available: true },
  { seat: "L6", available: true },
  { seat: "L7", available: true },
  { seat: "L8", available: true },
  { seat: "M1", available: true },
  { seat: "M2", available: true },
  { seat: "M3", available: true },
  { seat: "M4", available: true },
  { seat: "M5", available: true },
  { seat: "M6", available: true },
  { seat: "M7", available: true },
  { seat: "M8", available: true },
  { seat: "N1", available: true },
  { seat: "N2", available: true },
  { seat: "N3", available: true },
  { seat: "N4", available: true },
  { seat: "N5", available: true },
  { seat: "N6", available: true },
  { seat: "N7", available: true },
  { seat: "N8", available: true },
  { seat: "O1", available: true },
  { seat: "O2", available: true },
  { seat: "O3", available: true },
  { seat: "O4", available: true },
  { seat: "O5", available: true },
  { seat: "O6", available: true },
  { seat: "O7", available: true },
  { seat: "O8", available: true },
  { seat: "P1", available: true },
  { seat: "P2", available: true },
  { seat: "P3", available: true },
  { seat: "P4", available: true },
  { seat: "P5", available: true },
];

const flights = [
  {
    departure: "BSB",
    arrival: "CGH",
    departureTime: "05:25",
    arrivalTime: "07:25",
    duration: "1h 35m",
  },
  {
    departure: "GRU",
    arrival: "GIG",
    departureTime: "08:00",
    arrivalTime: "09:30",
    duration: "1h 30m",
  },
  {
    departure: "SDU",
    arrival: "FOR",
    departureTime: "10:30",
    arrivalTime: "13:00",
    duration: "2h 30m",
  },
  {
    departure: "MAO",
    arrival: "REC",
    departureTime: "14:15",
    arrivalTime: "16:45",
    duration: "2h 30m",
  },
  {
    departure: "SSA",
    arrival: "CNF",
    departureTime: "17:45",
    arrivalTime: "19:15",
    duration: "1h 30m",
  },
];

/* eslint-disable react/prop-types */
function SelectionFlightPage() {
  const location = useLocation();
  const [activeStep, setActiveStep] = useState(0);
  const [flight, setFlight] = useState({ ...location.state.flightSearch });
  const [travelers, setTravelers] = useState({ ...location.state.travelers });
  const [selectedDepartureFlight, setSelectedDepartureFlight] = useState(null); // Added state to track selected flight
  const [selectedReturnFlight, setSelectedReturnFlight] = useState(null); // Added state to track selected flight
  const [travelersAmount, setTravelersAmount] = useState(
    travelers.adult + travelers.child + travelers.baby
  );
  const [travelersData, setTravelersData] = useState(
    Array.from({ length: travelersAmount }, () => ({
      firstName: "",
      lastName: "",
      cpf: "",
      seat: null,
    }))
  );
  const [cardData, setCardData] = useState({
    cardNumber: "",
    validDate: "",
    cvv: "",
    CPF: "",
    cardName: "",
  });

  const handleChange = (e) => {
    const { name, value } = e.target;

    if (name === "cardNumber") {
      const formattedCardNumber = value
        .replace(/\D/g, "")
        .replace(/(.{4})/g, "$1 ")
        .trim();
      setCardData((prevData) => ({
        ...prevData,
        [name]: formattedCardNumber,
      }));
    } else if (name === "validDate") {
      const formattedValidDate = value
        .replace(/\D/g, "")
        .replace(/^(\d{2})(\d{0,4})/, "$1/$2");
      setCardData((prevData) => ({
        ...prevData,
        [name]: formattedValidDate,
      }));
    } else if (name === "CPF") {
      const formattedCPF = value
        .replace(/\D/g, "")
        .replace(/(\d{3})(\d)/, "$1.$2")
        .replace(/(\d{3})(\d)/, "$1.$2")
        .replace(/(\d{3})(\d{1,2})/, "$1-$2")
        .slice(0, 14); // Limiting to 14 characters (000.000.000-00)
      setCardData((prevData) => ({
        ...prevData,
        [name]: formattedCPF,
      }));
    } else {
      setCardData((prevData) => ({
        ...prevData,
        [name]: value,
      }));
    }
  };

  const isFinalizeDisabled = () => {
    return (
      !cardData.cardNumber ||
      !cardData.validDate ||
      !cardData.cvv ||
      !cardData.CPF ||
      !cardData.cardName
    );
  };
  console.log(location.state);

  const handleInputChange = (index, field, value) => {
    const newTravelersData = [...travelersData];
    newTravelersData[index][field] = value;
    setTravelersData(newTravelersData);

    console.log(travelersData);
  };

  const handleFlightSelect = (flight, type) => {
    if (type === "departure") {
      if (selectedDepartureFlight === flight) {
        // If the clicked flight is already selected, unselect it
        setSelectedDepartureFlight(null);
      } else {
        // Otherwise, select the clicked flight
        setSelectedDepartureFlight(flight);
      }
    } else if (type === "return") {
      if (selectedDepartureFlight === flight) {
        // If the clicked flight is already selected, unselect it
        setSelectedReturnFlight(null);
      } else {
        // Otherwise, select the clicked flight
        setSelectedReturnFlight(flight);
      }
    }
  };

  const handleNext = () => {
    setActiveStep((prevActiveStep) => prevActiveStep + 1);
  };

  const handleBack = () => {
    setActiveStep((prevActiveStep) => prevActiveStep - 1);
  };

  const isNextDisabled = () => {
    return travelersData.some(
      (traveler) =>
        !traveler.firstName ||
        !traveler.lastName ||
        !traveler.cpf ||
        !traveler.seat
    );
  };

  return (
    <Container
      sx={{
        display: "flex",
        flexDirection: "column",
        alignItems: "center",
        pt: { xs: 12, sm: 16 },
        pb: { xs: 8, sm: 12 },
      }}
    >
      <Box sx={{ pb: { xs: 6, sm: 8 } }}>
        <Card sx={{ minWidth: 800, padding: 3 }}>
          <CardContent>
            <Typography
              sx={{ fontSize: 14 }}
              color="text.secondary"
              gutterBottom
            >
              Suas escolhas de busca
            </Typography>
            <Box sx={{ display: "flex" }}>
              <Typography>{flight.from}</Typography>
              <ArrowRightAltIcon />
              <Typography>{flight.to}</Typography>
            </Box>
            <Box sx={{ display: "flex" }}>
              <Typography>
                Data de ida: {dayjs(flight.departure).format("DD/MM/YYYY")}
              </Typography>
            </Box>
            <Box sx={{ display: "flex" }}>
              <Typography>
                Data de volta: {dayjs(flight.return).format("DD/MM/YYYY")}
              </Typography>
            </Box>
          </CardContent>
        </Card>
      </Box>
      <Box sx={{ width: "100%" }}>
        <Stepper activeStep={activeStep} sx={{ margin: 3 }}>
          {steps.map((label) => {
            const stepProps = {};
            const labelProps = {};
            return (
              <Step key={label} {...stepProps}>
                <StepLabel {...labelProps}>{label}</StepLabel>
              </Step>
            );
          })}
        </Stepper>
        {activeStep === steps.length ? (
          <>
            <Box sx={{ display: "flex", justifyContent: "center" }}>
              <Typography variant="h2" sx={{ mt: 2, mb: 1 }}>
                Boa Viagem!
              </Typography>
            </Box>
            <Box sx={{ display: "flex", flexDirection: "row", pt: 2 }}>
              <Box sx={{ flex: "1 1 auto" }} />
              <Link to="/">
                <Button>Voltar para a home!</Button>
              </Link>
            </Box>
          </>
        ) : activeStep === 0 ? (
          // block for the first step
          <>
            <Box>
              <List sx={{ width: "100%", bgcolor: "background.paper" }}>
                {flights.map((flight, index) => (
                  <>
                    <ListItem
                      alignItems="flex-start"
                      key={index}
                      sx={{
                        "&:hover": {
                          border: "1px solid #ccc", // Add border on hover
                          borderRadius: "4px", // Optional: Add border radius
                        },
                        ...(selectedDepartureFlight === flight && {
                          border: "1px solid #ccc", // Add border for the selected flight
                          borderRadius: "4px", // Optional: Add border radius for the selected flight
                        }),
                      }}
                    >
                      <Box
                        sx={{
                          display: "flex",
                          justifyContent: "space-between",
                          width: "100%",
                        }}
                      >
                        <Box>
                          <Box sx={{ display: "flex" }}>
                            <Box sx={{ pr: "5px" }}>
                              <Typography variant="h6" gutterBottom={false}>
                                {flight.departureTime}
                              </Typography>
                              <Typography
                                variant="subtitle2"
                                color="text.secondary"
                              >
                                {flight.departure}
                              </Typography>
                            </Box>
                            <FlightTakeoffIcon />
                            <Typography
                              variant="caption"
                              sx={{ pr: "5px", pl: "5px" }}
                            >
                              Voo sem parada
                            </Typography>
                            <FlightLandIcon />
                            <Box sx={{ pl: "5px" }}>
                              <Typography variant="h6" gutterBottom={false}>
                                {flight.arrivalTime}
                              </Typography>
                              <Typography
                                variant="subtitle2"
                                color="text.secondary"
                              >
                                {flight.arrival}
                              </Typography>
                            </Box>
                          </Box>
                          <Box>
                            <Typography variant="button" color={"primary"}>
                              Duração de vôo: {flight.duration}
                            </Typography>
                          </Box>
                        </Box>
                        <Box sx={{ alignItems: "center", display: "flex" }}>
                          <Button
                            onClick={() =>
                              handleFlightSelect(flight, "departure")
                            }
                            variant="contained"
                            disabled={
                              selectedDepartureFlight &&
                              selectedDepartureFlight !== flight
                            } // Disable button if another flight is already selected
                            sx={{
                              "&:hover": {
                                border: "1px solid #ccc", // Add border on hover
                                borderRadius: "4px", // Optional: Add border radius
                              },
                            }}
                          >
                            {selectedDepartureFlight === flight
                              ? "Cancelar seleção"
                              : "Selecionar Vôo"}
                          </Button>
                        </Box>
                      </Box>
                    </ListItem>
                    <Divider />
                  </>
                ))}
              </List>
            </Box>

            <Typography sx={{ mt: 2, mb: 1 }}>Step fisrt gere</Typography>

            <Box sx={{ display: "flex", flexDirection: "row", pt: 2 }}>
              <Button
                color="inherit"
                disabled={activeStep === 0}
                onClick={handleBack}
                sx={{ mr: 1 }}
              >
                ANTERIOR
              </Button>
              <Box sx={{ flex: "1 1 auto" }} />

              <Button disabled={!selectedDepartureFlight} onClick={handleNext}>
                {activeStep === steps.length - 1 ? "Finish" : "PRÓXIMO"}
              </Button>
            </Box>
          </>
        ) : activeStep === 1 ? (
          // block for the first step
          <>
            <Box>
              <List sx={{ width: "100%", bgcolor: "background.paper" }}>
                {flights.map((flight, index) => (
                  <>
                    <ListItem
                      alignItems="flex-start"
                      key={index}
                      sx={{
                        "&:hover": {
                          border: "1px solid #ccc", // Add border on hover
                          borderRadius: "4px", // Optional: Add border radius
                        },
                        ...(selectedReturnFlight === flight && {
                          border: "1px solid #ccc", // Add border for the selected flight
                          borderRadius: "4px", // Optional: Add border radius for the selected flight
                        }),
                      }}
                    >
                      <Box
                        sx={{
                          display: "flex",
                          justifyContent: "space-between",
                          width: "100%",
                        }}
                      >
                        <Box>
                          <Box sx={{ display: "flex" }}>
                            <Box sx={{ pr: "5px" }}>
                              <Typography variant="h6" gutterBottom={false}>
                                {flight.departureTime}
                              </Typography>
                              <Typography
                                variant="subtitle2"
                                color="text.secondary"
                              >
                                {flight.departure}
                              </Typography>
                            </Box>
                            <FlightTakeoffIcon />
                            <Typography
                              variant="caption"
                              sx={{ pr: "5px", pl: "5px" }}
                            >
                              Voo sem parada
                            </Typography>
                            <FlightLandIcon />
                            <Box sx={{ pl: "5px" }}>
                              <Typography variant="h6" gutterBottom={false}>
                                {flight.arrivalTime}
                              </Typography>
                              <Typography
                                variant="subtitle2"
                                color="text.secondary"
                              >
                                {flight.arrival}
                              </Typography>
                            </Box>
                          </Box>
                          <Box>
                            <Typography variant="button" color={"primary"}>
                              Duração de vôo: {flight.duration}
                            </Typography>
                          </Box>
                        </Box>
                        <Box sx={{ alignItems: "center", display: "flex" }}>
                          <Button
                            onClick={() => handleFlightSelect(flight, "return")}
                            variant="contained"
                            disabled={
                              selectedReturnFlight &&
                              selectedReturnFlight !== flight
                            } // Disable button if another flight is already selected
                            sx={{
                              "&:hover": {
                                border: "1px solid #ccc", // Add border on hover
                                borderRadius: "4px", // Optional: Add border radius
                              },
                            }}
                          >
                            {selectedReturnFlight === flight
                              ? "Cancelar seleção"
                              : "Selecionar Vôo"}
                          </Button>
                        </Box>
                      </Box>
                    </ListItem>
                    <Divider />
                  </>
                ))}
              </List>
            </Box>

            <Typography sx={{ mt: 2, mb: 1 }}>Step fisrt gere</Typography>

            <Box sx={{ display: "flex", flexDirection: "row", pt: 2 }}>
              <Button
                color="inherit"
                disabled={activeStep === 0}
                onClick={handleBack}
                sx={{ mr: 1 }}
              >
                ANTERIOR
              </Button>
              <Box sx={{ flex: "1 1 auto" }} />
              <Button disabled={!selectedReturnFlight} onClick={handleNext}>
                {activeStep === steps.length - 1 ? "Finish" : "PRÓXIMO"}
              </Button>
            </Box>
          </>
        ) : activeStep === 2 ? (
          //block for the second step

          <>
            {Array.from({ length: travelersAmount }, (_, index) => (
              <Card key={index} sx={{ padding: 3, mb: 3 }}>
                <CardHeader
                  title="Nome do Viajante"
                  subheader={`Viajante ${index + 1} de ${travelersAmount}`}
                />
                <CardContent>
                  <Box sx={{ display: "flex" }}>
                    <Box>
                      <TextField
                        sx={{ mr: 3 }}
                        required
                        id={`first-name-${index}`}
                        label="Primeiro Nome"
                        placeholder="Informe o nome"
                        value={travelersData[index].firstName}
                        onChange={(e) =>
                          handleInputChange(index, "firstName", e.target.value)
                        }
                      />
                      <TextField
                        sx={{ mr: 3 }}
                        required
                        id={`last-name-${index}`}
                        label="Ultimo sobrenome"
                        placeholder="Informe o sobrenome"
                        value={travelersData[index].lastName}
                        onChange={(e) =>
                          handleInputChange(index, "lastName", e.target.value)
                        }
                      />
                      <TextField
                        sx={{ mr: 3 }}
                        required
                        id={`cpf-${index}`}
                        label="CPF"
                        placeholder="Informe o CPF"
                        // onInput={(e) => {
                        //   e.target.value = e.target.value.replace(/[^\d]/g, ""); // Remove non-numeric characters
                        // }}
                        value={travelersData[index].cpf}
                        onChange={(e) =>
                          handleInputChange(
                            index,
                            "cpf",
                            e.target.value.replace(/[^\d]/g, "")
                          )
                        }
                      />
                    </Box>
                    <Box>
                      <Autocomplete
                        getOptionLabel={(option) => option.seat}
                        options={airplaneSeats}
                        renderInput={(params) => (
                          <TextField {...params} label="Assento" />
                        )}
                        isOptionEqualToValue={(option, value) =>
                          option.seat ===
                          (value
                            ? value.seat
                            : console.log("that is the value: ", value))
                        }
                        onChange={(e, newValue) =>
                          handleInputChange(
                            index,
                            "seat",
                            newValue ? newValue.seat : ""
                          )
                        }
                      />
                    </Box>
                  </Box>
                </CardContent>
              </Card>
            ))}
            <Box sx={{ display: "flex", flexDirection: "row", pt: 2 }}>
              <Button color="inherit" onClick={handleBack} sx={{ mr: 1 }}>
                ANTERIOR
              </Button>
              <Box sx={{ flex: "1 1 auto" }} />
              <Button disabled={isNextDisabled()} onClick={handleNext}>
                {activeStep === steps.length - 1 ? "Finish" : "PRÓXIMO"}
              </Button>
            </Box>
          </>
        ) : (
          // This block executes for all other steps
          <>
            <Card variant="outlined">
              <CardHeader title="Resumo da seleção" />
              <Divider />
              <CardContent>
                {travelersData.map((traveler, index) => (
                  <Box
                    key={index}
                    sx={{
                      display: "flex",
                      alignItems: "center",
                      padding: 2,
                      borderBottom: "1px solid #ccc",
                    }}
                  >
                    <Box sx={{ flex: 1 }}>
                      <Typography>
                        {traveler.firstName} {traveler.lastName}
                      </Typography>
                    </Box>
                    <Box sx={{ flex: 1 }}>
                      <Typography>CPF: {traveler.cpf}</Typography>
                    </Box>
                    <Box
                      sx={{ flex: 1, display: "flex", alignItems: "center" }}
                    >
                      <Typography paddingRight="5px">
                        Assento: {traveler.seat}
                      </Typography>
                      <AirlineSeatReclineExtraIcon color="primary" />
                    </Box>
                    <Box sx={{ flex: 1 }}>
                      <Typography paddingRight="5px">
                        Categoria: Business
                      </Typography>
                    </Box>
                    <Box
                      sx={{ flex: 1, display: "flex", alignItems: "center" }}
                    >
                      <Typography paddingRight="5px">Bagagem: sim</Typography>
                      <LuggageIcon color="primary" />
                    </Box>
                  </Box>
                ))}
                <Box
                  sx={{
                    display: "flex",
                    justifyContent: "space-between",
                    pt: 2,
                    pl: 2,
                  }}
                >
                  <Typography>Total de viajantes: {travelersAmount}</Typography>
                  <Chip
                    size="medium"
                    sx={{ fontWeight: "bold" }}
                    label="R$ 15.234,78"
                    color="success"
                  />
                </Box>
              </CardContent>
            </Card>

            <Card variant="outlined" sx={{ mt: 2 }}>
              <CardHeader title="Dados de pagamento" />
              <Divider />
              <CardContent>
                <Box sx={{ display: "flex" }}>
                  <Box
                    sx={{
                      color: "rgb(154, 154, 154)",
                      textTransform: "uppercase",
                      height: "150px",
                      width: "241px",
                    }}
                  >
                    <Box
                      sx={{
                        border: "1px solid rgb(213, 213, 213)",
                        borderRadius: "5px",
                        boxSizing: "border-box",
                        padding: "8px 8px 11px 14px",
                        transition:
                          "0.5s cubic-bezier(0.175, 0.885, 0.32, 1.275)",
                        background: "rgb(235, 235, 235)!important",
                      }}
                    >
                      <Box
                        sx={{
                          height: "40px",
                          width: "40px",
                          borderRadius: "4px",
                          border: " 1px solid rgb(213, 213, 213)",
                        }}
                      ></Box>
                      <Typography fontSize="19px" padding={2}>
                        {cardData.cardNumber || "XXX XXX XXX XXX"}
                      </Typography>
                      <Typography fontSize="12px">
                        VAL. {cardData.validDate || "XX/XX"}
                      </Typography>
                      <Typography fontSize="10px" textTransform="uppercase">
                        {cardData.cvv || "XXX"}
                      </Typography>
                    </Box>
                  </Box>
                  <Box>
                    <Box sx={{ pb: 2 }}>
                      <TextField
                        sx={{ pr: 2, pl: 2, pb: 2 }}
                        placeholder="Número do Cartão"
                        name="cardNumber"
                        value={cardData.cardNumber}
                        onChange={handleChange}
                        inputProps={{ maxLength: 19 }} // Maximum length for "1111 1111 1111 1111"
                      />
                      <TextField
                        sx={{ pr: 2, pb: 2 }}
                        placeholder="Validade"
                        name="validDate"
                        value={cardData.validDate}
                        onChange={handleChange}
                        inputProps={{ maxLength: 7 }} // Maximum length for "MM/YYYY"
                      />
                      <TextField
                        sx={{ pr: 2, pb: 2 }}
                        placeholder="CVV"
                        name="cvv"
                        value={cardData.cvv}
                        onChange={handleChange}
                        inputProps={{ maxLength: 3, inputMode: "numeric" }} // Accepting numeric input only and max length 3
                      />
                      <TextField
                        sx={{ pr: 2, pl: 2, pb: 2 }}
                        placeholder="CPF do titular do cartão"
                        name="CPF"
                        value={cardData.CPF}
                        onChange={handleChange}
                      />
                      <TextField
                        sx={{ pr: 2, pb: 2 }}
                        placeholder="Nome impresso no cartão"
                        name="cardName"
                        value={cardData.cardName}
                        onChange={handleChange}
                      />
                    </Box>
                  </Box>
                </Box>
              </CardContent>
            </Card>
            <Box sx={{ display: "flex", flexDirection: "row", pt: 2 }}>
              <Button color="inherit" onClick={handleBack} sx={{ mr: 1 }}>
                ANTERIOR
              </Button>
              <Box sx={{ flex: "1 1 auto" }} />
              <Button disabled={isFinalizeDisabled()} onClick={handleNext}>
                {activeStep === steps.length - 1 ? "FINALIZAR" : "PRÓXIMO"}
              </Button>
            </Box>
          </>
        )}
      </Box>
    </Container>
  );
}

export default SelectionFlightPage;
