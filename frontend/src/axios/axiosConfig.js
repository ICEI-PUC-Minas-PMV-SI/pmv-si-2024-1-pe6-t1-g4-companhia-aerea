import axios from 'axios';

const baseurl = 'https://uaifly.azurewebsites.net'

const api = axios.create({
    baseURL: baseurl, // Substitua pela URL base da sua API
});

export default api;