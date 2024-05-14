import { useState } from "react";
import { useLocation } from "react-router-dom";
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
  FormControl,
  InputLabel,
  Select,
  MenuItem,
  Autocomplete,
} from "@mui/material";
import FlightTakeoffIcon from "@mui/icons-material/FlightTakeoff";
import ArrowRightAltIcon from "@mui/icons-material/ArrowRightAlt";
import FlightLandIcon from "@mui/icons-material/FlightLand";

const steps = ["Selecionar vôo", "Detalhes do voo", "Create an ad"];

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
    { seat: "P5", available: true }
]

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
  const [skipped, setSkipped] = useState(new Set());
  const [flight, setFlight] = useState({ ...location.state });
  const [selectedFlight, setSelectedFlight] = useState(null); // Added state to track selected flight


  const handleFlightSelect = (flight) => {
    if (selectedFlight === flight) {
      // If the clicked flight is already selected, unselect it
      setSelectedFlight(null);
    } else {
      // Otherwise, select the clicked flight
      setSelectedFlight(flight);
    }
  };

  const isStepOptional = (step) => {
    return;
  };

  const isStepSkipped = (step) => {
    return skipped.has(step);
  };

  const handleNext = () => {
    let newSkipped = skipped;
    if (isStepSkipped(activeStep)) {
      newSkipped = new Set(newSkipped.values());
      newSkipped.delete(activeStep);
    }

    setActiveStep((prevActiveStep) => prevActiveStep + 1);
    setSkipped(newSkipped);
  };

  const handleBack = () => {
    setActiveStep((prevActiveStep) => prevActiveStep - 1);
  };

  const handleSkip = () => {
    if (!isStepOptional(activeStep)) {
      // You probably want to guard against something like this,
      // it should never occur unless someone's actively trying to break something.
      throw new Error("You can't skip a step that isn't optional.");
    }

    setActiveStep((prevActiveStep) => prevActiveStep + 1);
    setSkipped((prevSkipped) => {
      const newSkipped = new Set(prevSkipped.values());
      newSkipped.add(activeStep);
      return newSkipped;
    });
  };

  const handleReset = () => {
    setActiveStep(0);
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
          </CardContent>
        </Card>
      </Box>
      <Box sx={{ width: "100%" }}>
        <Stepper activeStep={activeStep} sx={{ margin: 3 }}>
          {steps.map((label, index) => {
            const stepProps = {};
            const labelProps = {};
            if (isStepOptional(index)) {
              labelProps.optional = (
                <Typography variant="caption">Optional</Typography>
              );
            }
            if (isStepSkipped(index)) {
              stepProps.completed = false;
            }
            return (
              <Step key={label} {...stepProps}>
                <StepLabel {...labelProps}>{label}</StepLabel>
              </Step>
            );
          })}
        </Stepper>
        {activeStep === steps.length ? (
          <>
            <Typography sx={{ mt: 2, mb: 1 }}>
              All steps completed - you&apos;re finished
            </Typography>
            <Box sx={{ display: "flex", flexDirection: "row", pt: 2 }}>
              <Box sx={{ flex: "1 1 auto" }} />
              <Button onClick={handleReset}>Reset</Button>
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
                        ...(selectedFlight === flight && {
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
                            onClick={() => handleFlightSelect(flight)}
                            variant="contained"
                            disabled={
                              selectedFlight && selectedFlight !== flight
                            } // Disable button if another flight is already selected
                            sx={{
                              "&:hover": {
                                border: "1px solid #ccc", // Add border on hover
                                borderRadius: "4px", // Optional: Add border radius
                              },
                            }}
                          >
                            {selectedFlight === flight
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
              {isStepOptional(activeStep) && (
                <Button color="inherit" onClick={handleSkip} sx={{ mr: 1 }}>
                  Skip
                </Button>
              )}

              <Button disabled={!selectedFlight} onClick={handleNext}>
                {activeStep === steps.length - 1 ? "Finish" : "PRÓXIMO"}
              </Button>
            </Box>
          </>
        ) : activeStep === 1 ? (
          //block for the second step
          <>
            <Card sx={{ padding: 3 }}>
              <CardHeader
                title="Nome do Viajante"
                subheader="Viajante 1 de 1"
              />
              <CardContent>
                <Box sx={{ display: 'flex'}}>
                  <Box>
                    <TextField
                      sx={{ mr: 3 }}
                      required
                      id="outlined-required"
                      label="Primeiro Nome"
                      placeholder="Informe o nome"
                    />
                    <TextField
                      sx={{ mr: 3 }}
                      required
                      id="outlined-required"
                      label="Ultimo sobrenome"
                      placeholder="Informe o sobrenome"
                    />
                    <TextField
                      sx={{ mr: 3 }}
                      required
                      id="outlined-required"
                      label="CPF"
                      placeholder="Informe o CPF"
                      onInput={(e) => {
                        e.target.value = e.target.value.replace(/[^\d]/, ""); // Remove non-numeric characters
                      }}
                    />
                  </Box>
                  <Box>
                    <Autocomplete getOptionLabel={(option) => option.seat} options={airplaneSeats} renderInput={(params) => <TextField {...params} label="assento" />} />
                  </Box>
                </Box>
              </CardContent>
            </Card>

            <Box sx={{ display: "flex", flexDirection: "row", pt: 2 }}>
              <Button color="inherit" onClick={handleBack} sx={{ mr: 1 }}>
                ANTERIOR
              </Button>
              <Box sx={{ flex: "1 1 auto" }} />
              {isStepOptional(activeStep) && (
                <Button color="inherit" onClick={handleSkip} sx={{ mr: 1 }}>
                  Skip
                </Button>
              )}

              <Button onClick={handleNext}>
                {activeStep === steps.length - 1 ? "Finish" : "PRÓXIMO"}
              </Button>
            </Box>
          </>
        ) : (
          // This block executes for all other steps
          <>
            <Typography sx={{ mt: 2, mb: 1 }}>Step {activeStep + 1}</Typography>
            <Box sx={{ display: "flex", flexDirection: "row", pt: 2 }}>
              <Button color="inherit" onClick={handleBack} sx={{ mr: 1 }}>
                ANTERIOR
              </Button>
              <Box sx={{ flex: "1 1 auto" }} />
              {isStepOptional(activeStep) && (
                <Button color="inherit" onClick={handleSkip} sx={{ mr: 1 }}>
                  Skip
                </Button>
              )}

              <Button onClick={handleNext}>
                {activeStep === steps.length - 1 ? "Finish" : "PRÓXIMO"}
              </Button>
            </Box>
          </>
        )}
      </Box>
    </Container>
  );
}

export default SelectionFlightPage;
