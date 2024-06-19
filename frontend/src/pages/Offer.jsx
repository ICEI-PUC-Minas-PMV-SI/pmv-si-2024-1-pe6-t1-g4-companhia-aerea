import React from 'react';
import { Box, Grid, Card, CardMedia, CardContent, Typography, CardActions, Button } from '@mui/material';

function OfferPage({ offers }) {
  return (
    <Box sx={{ width: '100%', py: 4 }}>
      <Grid container spacing={3}>
        {offers.map((offer, index) => (
          <Grid item xs={12} sm={6} md={4} lg={3} key={index}>
            <Card sx={{ maxWidth: '100%', padding: 2, mx: 'auto' }}>
              <CardMedia
                //component="img"
                height="140"
                //image={offer.image}
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
          </Grid>
        ))}
      </Grid>
    </Box>
  );
}

export default OfferPage;
