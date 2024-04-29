import { useState } from 'react';
import Card from "../components/Card";
import Select from "../components/Select";
import Input from '../components/Input';

function HomePage() {
    const [selectedOrigin, setOrigin] = useState('');

    const options = [
      { value: '1', label: 'Recife' },
      { value: '2', label: 'Rio de Janeiro' },
      { value: '3', label: 'Belo Horizonte' },
    ];
  
    const handleOriginChange = (event) => {
      setOrigin(event.target.value);
    };


    const greeting = 'Olá, vamos voar para onde?'; 

  return (
    <>
      <Card title={greeting}>
        <div className='d-flex'>
            <div className='pl-1 align-self-end'>
                <Select options={options} onChange={handleOriginChange} value={selectedOrigin} placeholder="Selecione uma origem"/>
            </div>
            <div className='pl-1 align-self-end'>
                <Select options={options} onChange={handleOriginChange} value={selectedOrigin} placeholder="Selecione um destino"/>
            </div>
            <div className='pl-1'>
                <Input type='date' label="Data de Ida"/>
            </div>
            <div className='pl-1'>
                <Input type='date' label="Data de Volta"/>
            </div>
        </div>
        <div className='d-flex justify-end'>
            <button className='bg-b f-cb'>Confirmar</button>
        </div>
      </Card>
      <Card title="Ofertas em destaque">
        <div>
            <h2>Imagine um carrosel ou algo do tipo com um monte de ofertas...</h2>
        </div>
      </Card>
    </>
  );
}

export default HomePage;
