import * as React from 'react';
import { CssBaseline } from '@mui/material';
import { ThemeProvider, createTheme } from '@mui/material/styles';
import NavAppBar from '../components/NavAppBar';
import Box from '@mui/material/Box';
import Divider from '@mui/material/Divider';
import Footer from '../components/Footer';
import { Outlet } from 'react-router-dom';


export default function Root() {
  const [mode, setMode] = React.useState('light');

  const defaultTheme = createTheme({palette: {mode} });

  const toggleColorMode = () => {
    setMode((prev) => (prev === 'dark' ? 'light' : 'dark'));
  };

  return (
    <>
    <ThemeProvider theme={defaultTheme}>
      <CssBaseline />
      <NavAppBar mode={mode} toggleColorMode={toggleColorMode} />
      <Box sx={{ bgcolor: 'background.default' }}>
        <Outlet />
        <Divider />
        <Footer />
      </Box>
    </ThemeProvider>
    </>
  );
}
