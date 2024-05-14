import { Box, Button, Card, CardHeader } from "@mui/material";
import AsyncComboBox from "../components/AsyncComboBox";
import { DatePicker} from "@mui/x-date-pickers";
import CheckIcon from '@mui/icons-material/Check';
import { useState, useEffect } from "react";
import dayjs from "dayjs";
import { Link, useNavigate } from "react-router-dom";

function FormTravel() {
    const [departureDate, setDepartureDate] = useState();
    const [returnDate, setReturnDate] = useState();
    const [flightSearch, setFlightSearch] = useState({
        from: '',
        to: '',
        departure: '',
        return: ''
    });
    const [isInvalid, setIsInvalid] = useState(true);
    const navigate = useNavigate();

    const identifierToKeyMap = {
        from: 'from',
        to: 'to',
        departure: 'departure',
        return: 'return'
    };

    function handleOptionSelected(option, identifier) {
        const key = identifierToKeyMap[identifier];
        setFlightSearch(prevState => ({
            ...prevState,
            [key]: option.title
        }));
    }

    function handleDate(identifier, value) {
        const key = identifierToKeyMap[identifier];
        const formattedDate = dayjs(value).format();
        setFlightSearch(prevState => ({
            ...prevState,
            [key]: formattedDate
        }));
    }

    // Check if all fields in flightSearch are populated
    useEffect(() => {
        const { from, to, departure, return: returndate } = flightSearch;
        if (from && to && departure && returndate) {
            setIsInvalid(false);
        } else {
            setIsInvalid(true);
        }
    }, [flightSearch]);

    function handleClick() {
        navigate('selecao-voo', {state: {...flightSearch}})
        console.log('confirm clicked', JSON.stringify(flightSearch))
    }

    return (
        <Card sx={{ minWidth: 800, padding: 3 }}>
            <CardHeader title="Olá, vamos voar?" />
            <Box sx={{ display: "flex" }}>
                <AsyncComboBox label="Origem" onOptionSelected={(option, identifier) => handleOptionSelected(option, identifier)} identifier="from"  />
                <AsyncComboBox label="Destino" onOptionSelected={(option, identifier) => handleOptionSelected(option, identifier)} identifier="to" />
                <DatePicker sx={{ marginRight: "1rem" }} label="Ida" value={departureDate} onChange={(value) => handleDate('departure', value)} />
                <DatePicker sx={{ marginRight: "1rem" }} label="Volta" value={returnDate} onChange={(value) => handleDate('return', value)}  />
            </Box>
            <Box sx={{ mt: "1rem", mr: "1rem", display: "flex", flexDirection: "row-reverse" }}>
                    <Button variant="contained" endIcon={<CheckIcon />} disabled={isInvalid} onClick={handleClick}>
                        Confirmar
                    </Button>
            </Box>
            </Card>
    )
}

export default FormTravel