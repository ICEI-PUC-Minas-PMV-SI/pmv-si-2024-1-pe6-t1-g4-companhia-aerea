import { Box, Container } from "@mui/material";
import { alpha } from "@mui/material";
import FormTravel from "../components/FormTravel";

function AboutUs() {

  return (
    <Box
      id="aboutus"
      sx={(theme) => ({
        width: "90%",
        backgroundImage:
          theme.palette.mode === "light"
            ? "linear-gradient(180deg, #CEE5FD, #FFF)"
            : `linear-gradient(#02294F, ${alpha("#090E10", 0.0)})`,
        backgroundSize: "90% 20%",
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
        <FormTravel />
      </Container>
    </Box>
  );
}

export default AboutUs;


