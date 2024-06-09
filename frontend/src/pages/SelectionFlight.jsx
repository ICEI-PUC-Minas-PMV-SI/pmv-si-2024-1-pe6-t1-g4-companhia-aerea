import { useEffect, useState } from "react";
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
import api from "../axios/axiosConfig"
import { useNavigate } from "react-router-dom";
import PaidIcon from '@mui/icons-material/Paid';

const steps = [
  "Selecionar voo de ida",
  "Selecionar voo de volta",
  "Dados pessoais",
  "Checkout",
];

const airplaneSeats = [
  { seat: "A1 - Preço R$ 450,00", available: true, price: 450.00 },
  { seat: "A2 - Preço R$ 500,00", available: true, price: 500.00 },
  { seat: "A3 - Preço R$ 550,00", available: true, price: 550.00 },
  { seat: "A4 - Preço R$ 600,00", available: true, price: 600.00 },
  { seat: "A5 - Preço R$ 650,00", available: true, price: 650.00 },
  { seat: "A6 - Preço R$ 700,00", available: true, price: 700.00 },
  { seat: "A7 - Preço R$ 750,00", available: true, price: 750.00 },
  { seat: "A8 - Preço R$ 800,00", available: true, price: 800.00 },
  { seat: "B1 - Preço R$ 450,00", available: true, price: 450.00 },
  { seat: "B2 - Preço R$ 500,00", available: true, price: 500.00 },
  { seat: "B3 - Preço R$ 550,00", available: true, price: 550.00 },
  { seat: "B4 - Preço R$ 600,00", available: true, price: 600.00 },
  { seat: "B5 - Preço R$ 650,00", available: true, price: 650.00 },
  { seat: "B6 - Preço R$ 700,00", available: true, price: 700.00 },
  { seat: "B7 - Preço R$ 750,00", available: true, price: 750.00 },
  { seat: "B8 - Preço R$ 800,00", available: true, price: 800.00 },
  { seat: "C1 - Preço R$ 450,00", available: true, price: 450.00 },
  { seat: "C2 - Preço R$ 500,00", available: true, price: 500.00 },
  { seat: "C3 - Preço R$ 550,00", available: true, price: 550.00 },
  { seat: "C4 - Preço R$ 600,00", available: true, price: 600.00 },
  { seat: "C5 - Preço R$ 650,00", available: true, price: 650.00 },
  { seat: "C6 - Preço R$ 700,00", available: true, price: 700.00 },
  { seat: "C7 - Preço R$ 750,00", available: true, price: 750.00 },
  { seat: "C8 - Preço R$ 800,00", available: true, price: 800.00 },
  { seat: "D1 - Preço R$ 450,00", available: true, price: 450.00 },
  { seat: "D2 - Preço R$ 500,00", available: true, price: 500.00 },
  { seat: "D3 - Preço R$ 550,00", available: true, price: 550.00 },
  { seat: "D4 - Preço R$ 600,00", available: true, price: 600.00 },
  { seat: "D5 - Preço R$ 650,00", available: true, price: 650.00 },
  { seat: "D6 - Preço R$ 700,00", available: true, price: 700.00 },
  { seat: "D7 - Preço R$ 750,00", available: true, price: 750.00 },
  { seat: "D8 - Preço R$ 800,00", available: true, price: 800.00 },
  { seat: "E1 - Preço R$ 450,00", available: true, price: 450.00 },
  { seat: "E2 - Preço R$ 500,00", available: true, price: 500.00 },
  { seat: "E3 - Preço R$ 550,00", available: true, price: 550.00 },
  { seat: "E4 - Preço R$ 600,00", available: true, price: 600.00 },
  { seat: "E5 - Preço R$ 650,00", available: true, price: 650.00 },
  { seat: "E6 - Preço R$ 700,00", available: true, price: 700.00 },
  { seat: "E7 - Preço R$ 750,00", available: true, price: 750.00 },
  { seat: "E8 - Preço R$ 800,00", available: true, price: 800.00 },
  { seat: "F1 - Preço R$ 450,00", available: true, price: 450.00 },
  { seat: "F2 - Preço R$ 500,00", available: true, price: 500.00 },
  { seat: "F3 - Preço R$ 550,00", available: true, price: 550.00 },
  { seat: "F4 - Preço R$ 600,00", available: true, price: 600.00 },
  { seat: "F5 - Preço R$ 650,00", available: true, price: 650.00 },
  { seat: "F6 - Preço R$ 700,00", available: true, price: 700.00 },
  { seat: "F7 - Preço R$ 750,00", available: true, price: 750.00 },
  { seat: "F8 - Preço R$ 800,00", available: true, price: 800.00 },
  { seat: "G1 - Preço R$ 450,00", available: true, price: 450.00 },
  { seat: "G2 - Preço R$ 500,00", available: true, price: 500.00 },
  { seat: "G3 - Preço R$ 550,00", available: true, price: 550.00 },
  { seat: "G4 - Preço R$ 600,00", available: true, price: 600.00 },
  { seat: "G5 - Preço R$ 650,00", available: true, price: 650.00 },
  { seat: "G6 - Preço R$ 700,00", available: true, price: 700.00 },
  { seat: "G7 - Preço R$ 750,00", available: true, price: 750.00 },
  { seat: "G8 - Preço R$ 800,00", available: true, price: 800.00 },
  { seat: "H1 - Preço R$ 450,00", available: true, price: 450.00 },
  { seat: "H2 - Preço R$ 500,00", available: true, price: 500.00 },
  { seat: "H3 - Preço R$ 550,00", available: true, price: 550.00 },
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




function SelectionFlightPage() {
  const navigate = useNavigate();
  const [loadingFlights, setLoadingFlights] = useState(false)
  const [loadingSeats, setLoadingSeats] = useState(false)
  const [flightsDepearture, setFlightsDepearture] = useState([])
  const [flightsReturn, setFlightsReturn] = useState([])



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
      price: 0
    }))
  );
  const [cardData, setCardData] = useState({
    cardNumber: "",
    validDate: "",
    cvv: "",
    CPF: "",
    cardName: "",
  });
  const [dots, setDots] = useState('');
  const [priceAmount, setPriceAmount] = useState(
    travelersData.reduce((total, t) => total + t.price, 0)
  )


  useEffect(() => {
    setLoadingFlights(true)
    api.get(`/api/v1/Flight/search/searchflights?FromIataCode=${flight.fromIataCode.trim()}&ToIataCode=${flight.toIataCode.trim()}&DepeartureDate=${flight.departure}&ReturnDate=${flight.return}`
    )
      .then(response => {
        console.log('Voos', response.data);
        setFlightsDepearture(response.data.departureFlights)
        setFlightsReturn(response.data.returnFlights)
      })
      .catch(error => {
        console.error('Erro ao buscar dados:', error);
      })
      .finally(e => {
        setLoadingFlights(false)
      });
  }, [])

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
    const newPrice = travelersData.reduce((total, t) => total + t.price, 0)
    setPriceAmount(newPrice)
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

  const handleGoHome = () => {
    navigate('/', { replace: true });
  };


  useEffect(() => {
    const interval = setInterval(() => {
      setDots((prevDots) => (prevDots.length < 3 ? prevDots + '.' : ''));
    }, 500);

    return () => clearInterval(interval);
  }, []);

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
              Suas escolhas de busca:
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

      {
        loadingFlights ?
          (<>
            <Typography
              sx={{ fontSize: 24 }}
              color="text.secondary"
              gutterBottom
            >
              Carregando Informações
            </Typography>
            <Typography
              sx={{ fontSize: 36 }}
              color="text.secondary"
              gutterBottom
            >
              .{dots}
            </Typography>

          </>)
          : (<>
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
                    {flightsDepearture.length == 0 ? (
                      <>
                        <Box
                          display="flex"
                          flexDirection="column"
                          alignItems="center"
                          justifyContent="center"
                          margin="5em"
                          //height="100vh"
                          textAlign="center"
                        >
                          <Typography variant="h6" gutterBottom>
                            Nenhum voo foi encontrado para esta data.
                          </Typography>
                          <Button variant="contained" color="primary" onClick={handleGoHome}>
                            Voltar para a Home
                          </Button>
                        </Box>
                      </>
                    ) : (
                      <>
                        <List sx={{ width: "100%", bgcolor: "background.paper" }}>
                          {flightsDepearture.map((flight, index) => (
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
                      </>
                    )}

                  </Box>
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
                    {flightsReturn.length == 0 ? (
                      <>
                        <Box
                          display="flex"
                          flexDirection="column"
                          alignItems="center"
                          justifyContent="center"
                          margin="5em"
                          //height="100vh"
                          textAlign="center"
                        >
                          <Typography variant="h6" gutterBottom>
                            Nenhum voo foi encontrado para esta data.
                          </Typography>
                          <Button variant="contained" color="primary" onClick={handleGoHome}>
                            Voltar para a Home
                          </Button>
                        </Box>
                      </>
                    ) : (
                      <>
                        <List sx={{ width: "100%", bgcolor: "background.paper" }}>
                          {flightsReturn.map((flight, index) => (
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
                      </>
                    )

                    }

                  </Box>
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
                          <Box >
                            <Autocomplete
                              getOptionLabel={(option) => option.seat}
                              options={airplaneSeats}
                              renderInput={(params) => (
                                <TextField {...params} label="Assento" sx={{ width: '15em' }} />
                              )}
                              isOptionEqualToValue={(option, value) =>
                                option.seat ===
                                (value
                                  ? value.seat
                                  : console.log("that is the value: ", value))
                              }
                              onChange={(e, newValue) => {
                                handleInputChange(
                                  index,
                                  "seat",
                                  newValue ? newValue.seat : ""
                                )
                                handleInputChange(
                                  index,
                                  "price",
                                  newValue ? newValue.price : 0
                                )
                              }

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
                              Assento: {traveler.seat.split(" - ")[0]}
                            </Typography>
                            <AirlineSeatReclineExtraIcon color="primary" />
                          </Box>
                          <Box
                            sx={{ flex: 1, display: "flex", alignItems: "center" }}
                          >
                            <Typography paddingRight="5px">
                              Preço: {`R$ ${traveler.price},00`}
                            </Typography>
                            <PaidIcon color="success" />
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
                          label={`R$ ${priceAmount},00`}
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
          </>)
      }


    </Container>
  );
}

export default SelectionFlightPage;
