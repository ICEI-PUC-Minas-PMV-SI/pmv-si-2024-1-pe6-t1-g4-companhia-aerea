import { Box, Container } from "@mui/material";
import { alpha } from "@mui/material";
import FormTravel from "../components/FormTravel";
import OfferPage from "./Offer";
import axios from 'axios';
import React, {useEffect,useState} from "react";

function HomePage() {
  const [data, setData] = useState();

  useEffect(() => {
    const fetchData = async () => {
        try {
            const response = await axios.get('http://viacep.com.br/ws/01001000/json/');
            setData(response.data.cep);
            console.log('response',response.data)
            //console.log('data',data)
        } catch (error) {
            console.error('Error fetching data:', error);
        }
    };

    fetchData();
}, []);
useEffect(() => {
  console.log('data state updated:', data);
}, [data]);

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
        <FormTravel />
        <OfferPage offers={travelOffers} />
      </Container>
    </Box>
  );
}

export default HomePage;

const travelOffers = [
  {
    origin: "São Paulo",
    destination: "Rio de Janeiro",
    price: 150,
    discount: 10,
    image: "/static/images/cards/rio.jpg",
    description: "Descubra as belezas do Rio de Janeiro com suas praias icônicas e o Cristo Redentor.",
  },
  {
    origin: "Brasília",
    destination: "Salvador",
    price: 180,
    discount: 15,
    image: "/static/images/cards/salvador.jpg",
    description: "Explore Salvador, com suas vibrantes festas, culinária afro-brasileira e o Pelourinho.",
  },
  {
    origin: "Fortaleza",
    destination: "Recife",
    price: 120,
    discount: 8,
    image: "/static/images/cards/recife.jpg",
    description: "Visite Recife, conhecida por suas pontes, rios e o animado carnaval.",
  },
  {
    origin: "Belo Horizonte",
    destination: "Porto Alegre",
    price: 200,
    discount: 20,
    image: "/static/images/cards/porto-alegre.jpg",
    description: "Descubra Porto Alegre, com seu charme cultural e bela arquitetura.",
  },
  {
    origin: "Curitiba",
    destination: "Manaus",
    price: 250,
    discount: 12,
    image: "/static/images/cards/manaus.jpg",
    description: "Aventure-se em Manaus, a porta de entrada para a Amazônia e suas maravilhas naturais.",
  },
];
