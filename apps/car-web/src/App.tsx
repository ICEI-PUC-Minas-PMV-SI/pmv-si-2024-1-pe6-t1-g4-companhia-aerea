 import './App.css'
import { BrowserRouter as Router, Navigate, Route, Routes } from 'react-router-dom';
import CarInsuranceRisk from './components/CarInsuranceRisk';


const App = () => {
  return (
      <Router>
        <Routes>
          {/* Redirect from "/" to "/car-insurance-risk" */}
          <Route path="/" element={<Navigate to="/car-insurance-risk" />} />

          {/* Route for "/car-insurance-risk" */}
          <Route path="/car-insurance-risk" element={<CarInsuranceRisk />} />
        </Routes>
      </Router>   
  )
}

export default App
