import { Box, Button, Card, CardHeader, Container } from "@mui/material";
import { alpha } from "@mui/material";
import AsyncComboBox from "../components/AsyncComboBox";
import { DatePicker } from "@mui/x-date-pickers";
import CheckIcon from '@mui/icons-material/Check';

function HomePage() {
  return (
    <Box
      id="home"
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
        <Card sx={{ minWidth: 800, padding: 3 }}>
          <CardHeader title="Ola, vamos voar?" />
          <Box sx={{ display: "flex" }}>
            <AsyncComboBox label="Origem" />
            <AsyncComboBox label="Destino" />
            <DatePicker sx={{ marginRight: "1rem" }} label="Ida" />
            <DatePicker sx={{ marginRight: "1rem" }} label="Volta" />
          </Box>
          <Box sx={{ mt: "1rem", mr: "1rem", display: "flex", flexDirection: "row-reverse" }}>
            <Button variant="contained" endIcon={<CheckIcon />}>
                Confirmar
            </Button>
          </Box>
        </Card>
      </Container>
    </Box>
  );
}

export default HomePage;
