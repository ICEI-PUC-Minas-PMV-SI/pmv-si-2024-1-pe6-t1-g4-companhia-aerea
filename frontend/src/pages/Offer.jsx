/* eslint-disable react/prop-types */
import { Box, Button, Card, CardActions, CardContent, CardMedia, Typography } from "@mui/material";

function OfferPage({ offers }) {
  return (
    <Box sx={{display: "flex"}}>
      {offers.map((offer, index) => (
        <Card key={index} sx={{minWidth: "100px", margin: 2 }}>
          <CardMedia
            //sx={{ height: 140 }}
            // image={offer.image}
            title={offer.destination}
          />
          <CardContent>
            <Typography gutterBottom variant="h5" component="div">
              {offer.destination} {offer.discount}% OFF!
            </Typography>
            <Typography variant="body2" color="text.secondary">
              {offer.description}
            </Typography>
          </CardContent>
          <CardActions>
            <Button size="small">Comprar!</Button>
          </CardActions>
        </Card>
      ))}
    </Box>
  );
}

export default OfferPage;