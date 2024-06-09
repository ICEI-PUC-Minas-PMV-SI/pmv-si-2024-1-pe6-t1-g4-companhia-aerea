/* eslint-disable react/prop-types */
import TextField from "@mui/material/TextField";
import Autocomplete from "@mui/material/Autocomplete";
import CircularProgress from "@mui/material/CircularProgress";
import { useEffect, useState } from "react";
import api from "../axios/axiosConfig"

function sleep(duration) {
  return new Promise((resolve) => {
    setTimeout(() => {
      resolve();
    }, duration);
  });
}

export default function AsyncComboBox({ label, onOptionSelected, identifier }) {
  const [open, setOpen] = useState(false);
  const [options, setOptions] = useState([]);
  const [selectedOption, setSelectedOption] = useState(null);
  const loading = open && options.length === 0;
  const [brazilianCities, setBrazilianCities] = useState([]);

  useEffect(() => {
    let active = true;
    api.get('/api/v1/Flight/search/iata') 
    .then(response => {
      console.log('Resposta da API:', response.data);
      const iatas = response.data.map(iata => ({
        city: `${iata.location} - ${iata.airport}`,
        iata: iata.iataCode
      }));
      setBrazilianCities(iatas);

    })
    .catch(error => {
      console.error('Erro ao buscar dados:', error);
      setErro(error);
      setCarregando(false);
    });


    //let active = true;

    if (!loading) {
      return undefined;
    }

    (async () => {
      await sleep(1e3); // For demo purposes.

      if (active) {
        setOptions([...brazilianCities]);
      }
    })();

    return () => {
      active = false;
    };
  }, [loading]);

  useEffect(() => {
    if (!open) {
      setOptions([]);
    }
  }, [open]);

  return (
    <Autocomplete
      id="asynchronous-demo"
      sx={{ width: 300, marginRight: "1rem" }}
      open={open}
      onOpen={() => {
        setOpen(true);
      }}
      onClose={() => {
        setOpen(false);
      }}
      onChange={(event, newValue) => {
        setSelectedOption(newValue);
        if (onOptionSelected) {
          onOptionSelected(newValue, identifier); // Pass the identifier to the callback function
        }
      }}
      isOptionEqualToValue={(option, value) => option.city === value.city}
      getOptionLabel={(option) => option.city}
      options={options}
      loading={loading}
      loadingText="Carregando..."
      renderInput={(params) => (
        <TextField
          {...params}
          label={label}
          InputProps={{
            ...params.InputProps,
            endAdornment: (
              <>
                {loading ? (
                  <CircularProgress color="inherit" size={20} />
                ) : null}
                {params.InputProps.endAdornment}
              </>
            ),
          }}
        />
      )}
    />
  );
}

// Top films as rated by IMDb users. http://www.imdb.com/chart/top
// const brazilianCities = [
//   { city: "São Paulo", iata: "GRU" },
//   { city: "Rio de Janeiro", iata: "GIG" },
//   { city: "Brasília", iata: "BSB" },
//   { city: "Salvador", iata: "SSA" },
//   { city: "Fortaleza", iata: "FOR" },
//   { city: "Belo Horizonte", iata: "CNF" },
//   { city: "Manaus", iata: "MAO" },
//   { city: "Curitiba", iata: "CWB" },
//   { city: "Recife", iata: "REC" },
//   { city: "Porto Alegre", iata: "POA" },
//   { city: "Belém", iata: "BEL" },
//   { city: "Goiânia", iata: "GYN" },
//   { city: "Florianópolis", iata: "FLN" },
//   { city: "Vitória", iata: "VIX" },
//   { city: "Natal", iata: "NAT" },
//   { city: "Maceió", iata: "MCZ" },
//   { city: "Campo Grande", iata: "CGR" },
//   { city: "João Pessoa", iata: "JPA" },
//   { city: "São Luís", iata: "SLZ" },
//   { city: "Aracaju", iata: "AJU" }
// ];
