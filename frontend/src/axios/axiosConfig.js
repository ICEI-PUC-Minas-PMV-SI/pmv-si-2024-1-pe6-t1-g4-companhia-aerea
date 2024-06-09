import axios from 'axios';

const baseurl = 'https://localhost:7280'

const api = axios.create({
    baseURL: baseurl, // Substitua pela URL base da sua API
});

export default api;