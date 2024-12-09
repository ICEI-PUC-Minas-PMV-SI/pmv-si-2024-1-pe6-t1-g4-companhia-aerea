import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import { PrimeReactProvider } from 'primereact/api';
import 'primereact/resources/themes/md-light-indigo/theme.css'; // Material UI theme
import 'primereact/resources/primereact.min.css';               // PrimeReact core styles
import 'primeicons/primeicons.css';                            // PrimeIcons
import 'primeflex/primeflex.css';       // Core CSS                    // Icons  
import App from './App.tsx'

createRoot(document.getElementById('root')!).render(
  <StrictMode>
    <PrimeReactProvider>
    <App />
    </PrimeReactProvider>
  </StrictMode>,
)
