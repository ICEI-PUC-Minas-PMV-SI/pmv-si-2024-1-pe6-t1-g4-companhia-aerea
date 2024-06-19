import {
  Box,
  Button,
  Card,
  CardHeader,
  IconButton,
  Typography,
  Divider,
} from "@mui/material";
import AsyncComboBox from "../components/AsyncComboBox";
import { DatePicker } from "@mui/x-date-pickers";
import CheckIcon from "@mui/icons-material/Check";
import { useState, useEffect } from "react";
import dayjs from "dayjs";
import { useNavigate } from "react-router-dom";
import AddCircleOutlineOutlinedIcon from "@mui/icons-material/AddCircleOutlineOutlined";
import RemoveCircleOutlineOutlinedIcon from "@mui/icons-material/RemoveCircleOutlineOutlined";

function FormTravel() {
  const [departureDate, setDepartureDate] = useState();
  const [returnDate, setReturnDate] = useState();
  const [flightSearch, setFlightSearch] = useState({
    from: "",
    fromIataCode: "",
    to: "",
    toIataCode: "",
    departure: "",
    return: "",
  });
  const [isInvalid, setIsInvalid] = useState(true);
  const [travelers, setTravelers] = useState({
    adult: 0,
    child: 0,
    baby: 0,
  });
  const navigate = useNavigate();

  const identifierToKeyMap = {
    from: ["from", "fromIataCode"],
    to: ["to", "toIataCode"],
    departure: "departure",
    return: "return",
  };

  function handleOptionSelected(option, identifier) {
    const [cityKey, iataKey] = identifierToKeyMap[identifier];
    setFlightSearch((prevState) => ({
      ...prevState,
      [cityKey]: option ? option.city : "",
      [iataKey]: option ? option.iata : "",
    }));
  }

  function handleDate(identifier, value) {
    const key = identifierToKeyMap[identifier];
    const formattedDate = value ? dayjs(value).format() : "";
    setFlightSearch((prevState) => ({
      ...prevState,
      [key]: formattedDate,
    }));
  }

  // Check if all fields in flightSearch are populated
  useEffect(() => {
    const { from, to, departure, return: returndate } = flightSearch;
    const { adult, child, baby } = travelers;
    setIsInvalid(
      !(
        from &&
        to &&
        departure &&
        returndate &&
        (adult > 0 || child > 0 || baby > 0)
      )
    );
  }, [flightSearch, travelers]);

  function handleClick() {
    navigate("selecao-voo", {
      state: {
        flightSearch: { ...flightSearch },
        travelers: { ...travelers },
      },
    });
  }

  function handleTravelers(operation, travelerType) {
    const updatedTravelers = { ...travelers }; // Create a copy of travelers object

    if (operation === "decrease") {
      if (updatedTravelers[travelerType] > 0) {
        updatedTravelers[travelerType]--;
        setTravelers(updatedTravelers); // Update state with the modified object
      }
    }
    if (operation === "increase") {
      updatedTravelers[travelerType]++;
      setTravelers(updatedTravelers); // Update state with the modified object
    }
  }

  return (
    <Card sx={{ padding: 2, gap: 2, width: { xs: '100%' }, mx: 'auto' }} variant="outlined">
      <CardHeader title="Olá, vamos voar?" />
      <Box sx={{ display: 'flex', flexDirection: { xs: 'column', sm: 'row' }, gap: 2 }}>
        <AsyncComboBox
          label="Origem"
          identifier="from"
          onOptionSelected={(option, identifier) => handleOptionSelected(option, identifier)}
        />
        <AsyncComboBox
          label="Destino"
          identifier="to"
          onOptionSelected={(option, identifier) => handleOptionSelected(option, identifier)}
        />
        <DatePicker
          sx={{ flexGrow: 1 }}
          label="Ida"
          inputFormat="dd/MM/yyyy"
          value={departureDate}
          onChange={(value) => handleDate('departure', value)}
        />
        <DatePicker
          sx={{ flexGrow: 1 }}
          label="Volta"
          value={returnDate}
          onChange={(value) => handleDate('return', value)}
        />
      </Box>
      <Box sx={{ padding: 3 }}>
        <Box>
          <Typography variant="subtitle1">Viajantes</Typography>
        </Box>
        <Box sx={{ display: 'flex', flexDirection: { xs: 'column', sm: 'row' }, gap: 2 }}>
          <Box sx={{ display: 'flex', alignItems: 'center', gap: 1 }}>
            <Typography>Adulto</Typography>
            <IconButton color="primary" disabled={travelers.adult === 0} onClick={() => handleTravelers('decrease', 'adult')}>
              <RemoveCircleOutlineOutlinedIcon />
            </IconButton>
            {travelers.adult}
            <IconButton onClick={() => handleTravelers('increase', 'adult')} color="primary">
              <AddCircleOutlineOutlinedIcon />
            </IconButton>
          </Box>
          <Box sx={{ display: 'flex', alignItems: 'center', gap: 1 }}>
            <Typography>Criança</Typography>
            <IconButton color="primary" disabled={travelers.child === 0} onClick={() => handleTravelers('decrease', 'child')}>
              <RemoveCircleOutlineOutlinedIcon />
            </IconButton>
            {travelers.child}
            <IconButton onClick={() => handleTravelers('increase', 'child')} color="primary">
              <AddCircleOutlineOutlinedIcon />
            </IconButton>
          </Box>
          <Box sx={{ display: 'flex', alignItems: 'center', gap: 1 }}>
            <Typography>Bebê</Typography>
            <IconButton color="primary" disabled={travelers.baby === 0} onClick={() => handleTravelers('decrease', 'baby')}>
              <RemoveCircleOutlineOutlinedIcon />
            </IconButton>
            {travelers.baby}
            <IconButton onClick={() => handleTravelers('increase', 'baby')} color="primary">
              <AddCircleOutlineOutlinedIcon />
            </IconButton>
          </Box>
        </Box>
      </Box>
      <Box sx={{ mt: '1rem', display: 'flex', justifyContent: 'center' }}>
        <Button variant="contained" endIcon={<CheckIcon />} disabled={isInvalid} onClick={handleClick}>
          Confirmar
        </Button>
      </Box>
    </Card>
  );
}

export default FormTravel;
