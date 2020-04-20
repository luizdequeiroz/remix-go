import axios from 'axios';
import { apply } from 'react-resaga';
import { login } from './usuario';
import { getSheetsByUserId } from './sheet';
import Swal from 'sweetalert2';

function prepareHeaders() {
    const sessionStringfyed = sessionStorage.getItem('session');
    const session = JSON.parse(sessionStringfyed);

    const headers = {
        "Content-Type": 'application/json'
    };

    if (sessionStringfyed) headers.authorization = `Bearer ${session.content.token}`;

    return headers;
}

function* prepareResponse(response, treatment, callback) {

    yield apply('status', {
        showModal: false
    });
    if (response.isAxiosError) {
        Swal.fire({
            title: 'Erro de conexão!',
            text: response.message,
            icon: 'error'
        });
    } else if (JSON.stringify(response.data.result) === 'true' || JSON.stringify(response.data.result) === 'false') {
        if (!response.data.result) {
            if (response.status === 401) {
                Swal.fire({
                    title: 'Sessão expirou!',
                    text: 'A sessão do usuário expirou, por favor realizar login novamente no sistema',
                    icon: 'info'
                });
                sessionStorage.clear();
                yield apply('session');
            } else if (response.status === 400) {
                Swal.fire({
                    title: response.data.message,
                    text: response.data.validations && response.data.validations.map(validation => validation[0]).join('\n'),
                    icon: 'warning'
                });
            } else throw new Error(JSON.stringify(response.data))
        }
    } else if (response.status < 200 || response.status >= 300) {
        Swal.fire({
            title: 'Erro no serviço!',
            text: `Código de Erro: ${response.status}`,
            icon: 'error'
        });
    }

    const treated = treatment && treatment(response.data);
    if (callback) yield callback(treated || response.data);

    return {
        ...response,
        data: treated || response.data,
    };
}

export function* get(api, endpoint, { params, treatment, callback } = {}) {
    try {
        const headers = prepareHeaders();
        const response = yield axios.get(`${api}/${endpoint}`, { params, headers }).catch(error => error.response || error);

        return yield prepareResponse(response, treatment, callback);
    } catch (error) {
        return error;
    }
}

export function* post(api, endpoint, data, { params, treatment, callback } = {}) {
    try {
        const headers = prepareHeaders();
        const response = yield axios.post(`${api}/${endpoint}`, data, { params, headers }).catch(error => error.response || error);

        return yield prepareResponse(response, treatment, callback);
    } catch (error) {
        return error;
    }
}

export function* put(api, endpoint, data, { params, treatment, callback } = {}) {
    try {
        const headers = prepareHeaders();
        const response = yield axios.put(`${api}/${endpoint}`, data, { params, headers }).catch(error => error.response || error);

        return yield prepareResponse(response, treatment, callback);
    } catch (error) {
        return error;
    }
}

export function* del(api, endpoint, { params, treatment, callback } = {}) {
    try {
        const headers = prepareHeaders();
        const response = yield axios.delete(`${api}/${endpoint}`, { params, headers }).catch(error => error.response || error);

        return yield prepareResponse(response, treatment, callback);
    } catch (error) {
        return error;
    }
}

export function* request({ method, api, endpoint, data, config: { params, treatment, callback } = {} } = {}) {
    switch (method) {
        case 'get': return yield get(api, endpoint, { params, treatment, callback });
        case 'post': return yield post(api, endpoint, data, { params, treatment, callback });
        case 'put': return yield put(api, endpoint, data, { params, treatment, callback });
        case 'del': return yield del(api, endpoint, { params, treatment, callback });
        default: return new Error('Http method is not valid');
    }
}

export default {
    request,
    login,
    getSheetsByUserId
};