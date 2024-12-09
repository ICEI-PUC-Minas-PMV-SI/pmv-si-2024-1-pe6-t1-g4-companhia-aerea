import React, { useEffect, useState } from 'react';
import { InputNumber } from 'primereact/inputnumber';
import { Button } from 'primereact/button';
import { Dropdown } from 'primereact/dropdown';
import { carMakes } from '../models/carMake';
import { carModels } from '../models/carModels';
import { Card } from 'primereact/card';
import { brazilianCities } from '../models/cities';
import { Calendar } from 'primereact/calendar'; // Import Calendar component
import axios from 'axios';

const CarInsuranceRisk = () => {
  const [models, setModels] = useState<{ name: string; code: string }[]>([]);
  const [riskProbability, setRiskProbability] = useState<number | null>(null);
  const [carDetails, setCarDetails] = useState({
    make: null as string | null,
    model: null as { name: string; code: string } | null,
    ageOfPolicyHolder: null as number | null,
    year: null as number | null,
    city: '',
    sex: null as string | null,
  });

  const [isSubmitted, setIsSubmitted] = useState(false);

  const handleDropdownChange = (e: { value: string }) => {
    setCarDetails((prevDetails) => ({
      ...prevDetails,
      sex: e.value,
    }));
  };

  const handleMakeChange = (e: { value: string }) => {
    const selectedMake = e.value;
    setCarDetails((prevDetails) => ({
      ...prevDetails,
      make: selectedMake,
      model: null, // Reset model when make changes
    }));
  };

  const handleModelChange = (e: { value: { name: string; code: string } }) => {
    setCarDetails((prevDetails) => ({
      ...prevDetails,
      model: e.value,
    }));
  };

  useEffect(() => {
    if (carDetails.make) {
      const fetchedModels = carModels[carDetails.make] || [];
      setModels(fetchedModels);
    } else {
      setModels([]);
    }
  }, [carDetails.make]);

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
  
    // Check if all required fields are filled
    if (!carDetails.make || !carDetails.model || !carDetails.year || !carDetails.ageOfPolicyHolder || !carDetails.city || !carDetails.sex) {
      alert("Por favor, preencha todos os campos obrigatórios.");
      return;
    }
  
    setIsSubmitted(true);
  
    try {
      // Send data to the API using axios
      const response = await axios.post('http://127.0.0.1:5000/predict', carDetails);
  
      // Log the response data from the API
      console.log('API Response:', response.data);
      const prediction = response.data.prediction;
      const probability = response.data.probability;
  
      console.log('Prediction:', prediction);
      console.log('Probability:', probability, probability[0]);
  
      const predictedRisk = prediction[0]; // Get the first prediction value
      const riskProbabilityArray = probability[0]; // Get the first probability array
      console.log('Predicted Risk:', predictedRisk);
      console.log('Risk Probability:', riskProbabilityArray);
  
      // Store the risk probability (assuming it's in the first element of the array)
      setRiskProbability(riskProbabilityArray[1] * 100); // Multiply by 100 to get percentage
  
      // You can display a success message or take other actions based on the response
      alert('Formulário enviado com sucesso!');
    } catch (error) {
      // Handle errors
      console.error('Error submitting form:', error);
      alert('Ocorreu um erro ao enviar os dados. Tente novamente.');
    }
  };

  const handleReset = () => {
    setCarDetails({
      make: null,
      model: null,
      ageOfPolicyHolder: null,
      year: null,
      city: '',
      sex: null,
    });
    setIsSubmitted(false);
  };

  const sexOptions = [
    { label: 'Masculino', value: 'male' },
    { label: 'Feminino', value: 'female' },
  ];

  return (
    <Card title="Risco de Sinistro">
        <div className="car-insurance-form">
        <form onSubmit={handleSubmit}>
            {/* Car Details Section */}
            <div className="field-group">
            <div className="field">
                <label htmlFor="make">Marca do veiculo</label>
                <Dropdown
                id="make"
                name="make"
                value={carDetails.make}
                options={carMakes}
                onChange={handleMakeChange}
                optionLabel="name"
                optionValue="code"
                placeholder="Selecione a marca do veículo"
                className="p-dropdown p-d-block"
                style={{ width: '300px'}}
                required
                />
            </div>

            <div className="field">
                <label htmlFor="model">Modelo</label>
                <Dropdown
                id="model"
                name="model"
                value={carDetails.model}
                options={models}
                onChange={handleModelChange}
                optionLabel="name"
                optionValue="code"
                placeholder="Selecione o modelo do veículo"
                className="p-dropdown p-d-block"
                style={{ width: '300px'}}
                required
                disabled={!carDetails.make}  // Disable the model dropdown if no make is selected
                />
            </div>

            <div className="field">
                <label htmlFor="year">Ano de fabricação</label>
                <Calendar
                id="year"
                name="year"
                value={carDetails.year ? new Date(carDetails.year, 0) : null}
                onChange={(e) => setCarDetails({ ...carDetails, year: e.value?.getFullYear() ?? null })}
                yearRange="1900:2024"
                view="year" // Show only the year picker
                dateFormat="yy"
                required
                style={{ width: '200px' }}
                className="p-calendar p-d-block"
                />
            </div>
            </div>

            {/* Personal Information Section */}
            <div className="field-group">
            <div className="field">
                <label htmlFor="ageOfPolicyHolder">Idade do motorista</label>
                <InputNumber
                id="ageOfPolicyHolder"
                name="ageOfPolicyHolder"
                value={carDetails.ageOfPolicyHolder}
                onValueChange={(e) => setCarDetails({ ...carDetails, ageOfPolicyHolder: e.value ?? null })}
                min={18}
                max={100}
                required
                className="p-inputnumber p-d-block"
                />
            </div>

            <div className="field">
                <label htmlFor="city">Cidade</label>
                <Dropdown
                id="city"
                name="city"
                value={carDetails.city}
                options={brazilianCities}
                onChange={(e) => setCarDetails({ ...carDetails, city: e.value })}
                optionLabel="label"
                optionValue="value"
                placeholder="Selecione a cidade"
                required
                style={{ width: '200px'}}
                className="p-dropdown p-d-block"
                />
            </div>

            <div className="field">
                <label htmlFor="sex">Sexo</label>
                <Dropdown
                id="sex"
                name="sex"
                value={carDetails.sex}
                options={sexOptions}
                onChange={handleDropdownChange}
                optionLabel="label"
                optionValue="value"
                placeholder="Selecione o sexo"
                required
                style={{ width: '200px' }}
                className="p-dropdown p-d-block"
                />
            </div>
            </div>

            <Button label="Simular" type="submit" className="p-button p-button-primary" />
        </form>

        {/* Filler Text Section */}
        {isSubmitted && (
            <div className="filler-text-section" style={{ marginLeft: '20px' }}>
            <h4>Probabilidade de Sinistro: {riskProbability?.toFixed(2)} %</h4> {/* Display the probability */}
            <Button label="Resetar" onClick={handleReset} className="p-button p-button-secondary" />
            </div>
        )}
        </div>
    </Card>
  );
};

export default CarInsuranceRisk;
