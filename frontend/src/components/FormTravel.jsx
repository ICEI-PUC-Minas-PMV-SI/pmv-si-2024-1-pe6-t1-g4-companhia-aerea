import { Box, Button, Card, CardHeader } from "@mui/material";
import AsyncComboBox from "../components/AsyncComboBox";
import { DatePicker} from "@mui/x-date-pickers";
import CheckIcon from '@mui/icons-material/Check';
import { useState } from "react";
import dayjs from "dayjs";

function FormTravel() {
    const [departureDate, setDepartureDate] = useState(dayjs());
    const [returnDate, setReturnDate] = useState(dayjs().add(1, 'month'));

    const isInvalid = true;

    function handleDate(identifier, value) {
        switch (identifier) {
            case 'departure':
                setDepartureDate(value)
                console.log(departureDate, value, dayjs(value).format());
                break;
            case 'return':
                setReturnDate(value);
                break;
            default:
                console.log('Default');
        }
    }

    return (
        <Card sx={{ minWidth: 800, padding: 3 }}>
            <CardHeader title="Ola, vamos voar?" />
            <Box sx={{ display: "flex" }}>
                <AsyncComboBox label="Origem" />
                <AsyncComboBox label="Destino" />
                <DatePicker sx={{ marginRight: "1rem" }} label="Ida" value={departureDate} onChange={(value) => handleDate('departure', value)} />
                <DatePicker sx={{ marginRight: "1rem" }} label="Volta" value={returnDate} onChange={(value) => handleDate('return', value)}  />
            </Box>
            <Box sx={{ mt: "1rem", mr: "1rem", display: "flex", flexDirection: "row-reverse" }}>
                <Button variant="contained" endIcon={<CheckIcon />} disabled={isInvalid}>
                    Confirmar
                </Button>
            </Box>
            </Card>
    )
}

export default FormTravel