import { SAGA_REQUEST } from 'react-binder-generalizers'; // TODO: lib
import { takeEvery, all } from 'redux-saga/effects';
import { fetchUrl } from '../../utils';

export function* genericSaga({ request: { method, api, endpoint = '', returnReduceKey, param, treatment, callback } }) {
    const url = `${api}/${endpoint}`;
    const body = JSON.stringify(param);
    var params = {
        method,
        headers: {
            "Content-Type": "application/json"
        }
    };
    if (method === 'POST' || method === 'PUT') params = {...params, body };

    yield fetchUrl(url, returnReduceKey, params, treatment, callback);
}

/**
 * Escuta a action SET_MATRICULA e dispara a consulta de informações do usuário
 */
export function* watchGenericSaga() {
    yield takeEvery(SAGA_REQUEST, genericSaga);
}

/**
 * Importa os observadores de actions
 */
export default function* rootSaga() {
    yield all([watchGenericSaga()]);
}