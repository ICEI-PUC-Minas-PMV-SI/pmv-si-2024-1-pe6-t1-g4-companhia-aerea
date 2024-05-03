import { Box, Button, Card, CardHeader } from "@mui/material";
import AsyncComboBox from "../components/AsyncComboBox";
import { DatePicker } from "@mui/x-date-pickers";
import CheckIcon from '@mui/icons-material/Check';

function FormTravel() {
    return (
        <Card sx={{ minWidth: 800, padding: 3 }}>
            <CardHeader title="Ola, vamos voar?" />
            <Box sx={{ display: "flex" }}>
                <AsyncComboBox label="Origem" />
                <AsyncComboBox label="Destino" />
                <DatePicker sx={{ marginRight: "1rem" }} label="Ida" />
                <DatePicker sx={{ marginRight: "1rem" }} label="Volta" />
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