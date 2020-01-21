import { put } from 'redux-saga/effects';
import fetch from 'isomorphic-fetch';
import guid from 'guid';
import Swal from 'sweetalert2';

/**
 * Função para transformar um objeto em parâmetros de url (var1=valor1)
 * 
 * @export
 * @param {any} obj
 * @returns
 */
export function serializeObjToUrl(obj) {
    return `?${Object.keys(obj).reduce(
        (a, k) => {
            a.push(`${k}=encodeURIComponent(${obj[k]})`);
            return a;
        }, []).join('&')}`;
}

/**
 * Função para transformar apenas a primeira letra de cada palavra em caixa alta
 * 
 * @export
 * @param {any} str
 * @returns
 */
export function toTitleCase(str) {
    return str.replace(/\w\S*/g,
        (txt) => txt.charAt(0).toUpperCase() + txt.substr(1).toLowerCase()
    );
}

/**
 * Executa uma requisição a uma url usando Fetch.
 * 
 * @export
 * @param {string} url
 * @param {string} returnReduceKey
 * @param {object} [parametros={}]
 * @param {object} dispatch
 * @param {object} callback
 */
export function* fetchUrl(url,
    returnReduceKey,
    parametros = {},
    treatment,
    callback) {

    try {
        const data = yield fetch(url, parametros);
        const jsonData = yield data.json();
        if (data.status < 200 || data.status >= 300) {
            console.log(jsonData);
            if (jsonData !== null && typeof jsonData === 'object' && jsonData.StackTraceString && jsonData.Message && jsonData.Message !== 'Unexpected end of JSON input') {
                let err = jsonData;
                err['funcao'] = url;
                err['parametros'] = parametros;

                yield put({ type: 'set_value', payload: { key: 'central', value: err } });
            }

            if (data.status !== 400) throw new Error(JSON.stringify(jsonData));
        }

        yield put({ type: 'set_value', payload: { key: returnReduceKey, value: jsonData, treatment } });
        yield put({
            type: 'set_value', payload: {
                key: 'status', value: {
                    showModal: false
                }
            }
        });

        if (callback && callback.run) {
            yield put(callback.run(jsonData));
        }
    } catch (error) {
        error['funcao'] = url;
        error['parametros'] = parametros;
        error['StackTraceString'] = error.stack;
        error['Message'] = error.message;
        delete error.message;

        yield put({ type: 'set_value', payload: { key: 'central', value: error, treatment } });

        if (callback && callback.messageForError) {
            Swal.fire({
                title: callback.messageForError,
                type: 'error'
            });
            yield put({
                type: 'set_value', payload: {
                    key: 'status', value: {
                        showModal: false
                    }
                }
            });
        } else {
            Swal.fire({
                title: 'Erro na solicitação.',
                type: 'error'
            });
            yield put({
                type: 'set_value', payload: {
                    key: 'status', value: {
                        showModal: false
                    }
                }
            });
        }
    }
}

/**
 * Retorna uma lista de WorkItems ordenados pela prioridade e pela ordem
 */
export function sortWorkItemsByPriority(workItems, ordemCrescente = true) {
    const workItemsSorted = workItems.sort((a, b) => {
        if (ordemCrescente) {
            return (b.fields.Priority < a.fields.Priority) ? 1 : -1;
        }
        return (a.fields.Priority < b.fields.Priority) ? 1 : -1;
    });

    return workItemsSorted;
}

/**
 * Formatar a data
 */
export function formatDate(dateTime) {
    if (dateTime) {
        const date = new Date(dateTime);
        let day = date.getDate();
        let month = date.getMonth() + 1;
        month = month < 10 ? `0${month}` : month;
        day = day < 10 ? `0${day}` : day;
        return `${day}`.concat('/', month, '/', date.getFullYear());
    }
    return '-';
}

export function formatDateTime(dateTime) {
    if (dateTime) {
        const dateFormatted = formatDate(dateTime);
        const date = new Date(dateTime);

        return `${dateFormatted}`.concat(' ', date.getHours().toString().padStart(2, '0'), ':', date.getMinutes().toString().padStart(2, '0'), ':', date.getSeconds().toString().padStart(2, '0'));
    }
    return '-';
}

/**
 * Verifica se o valor passado é numérico.
 * @param {any} value
 * @returns {boolean}
 */
export function isNumber(value) {
    return !isNaN(parseInt(value, 0)) && isFinite(value);
}

/**
 * Aplica máscara de CPF ao valor parametrizado.
 * @param {string} value 
 */
export const maskCPF = value => value && value
    .replace(/\D/g, '') // substitui qualquer caracter que nao seja numero por nada
    .replace(/(\d{3})(\d)/, '$1.$2') // captura 2 grupos de numero o primeiro de 3 e o segundo de 1, apos capturar o primeiro grupo ele adiciona um ponto antes do segundo grupo de numero
    .replace(/(\d{3})(\d)/, '$1.$2')
    .replace(/(\d{3})(\d{1,2})/, '$1-$2')
    .replace(/(-\d{2})\d+?$/, '$1'); // captura 2 numeros seguidos de um traço e não deixa ser digitado mais nada

/**
 * Aplica fixed sem round de casas decimais.
 * @param {number} number 
 */
export function currency(number) {
    if (number) {
        const regExp = new RegExp(/^-?\d+(?:\.\d{0,2})?/);
        var result = number.toString().match(regExp)[0];
        const decimals = result.split('.')[1];
        if (decimals) {
            if (decimals.length === 1) result = `${result}0`;
        } else result = `${result}.00`;
        return result.toString().replace('.', ',');
    }

    return '-';
}

/**
 * Corrige tamanho do cnpj sem máscara.
 * @param {string} cnpj 
 */
export function fixCNPJ(cnpj) {
    if (cnpj) {
        if (cnpj.length > 14) {
            cnpj = cnpj.substring(1, cnpj.length);
        }

        return cnpj;
    }
}

/**
 * Remove todos os caracteres não numéricos
 * @param {string} value 
 */
export const numberOnly = value => value.replace(/\D/g, '');

/**
 * Gerar guid em propriedade chamada guid para lista passada por parâmetro sem que o guid tenha a possibilidade de repetição na lista.
 * @param {Array} list 
 */
export function generateGuid(list) {
    const _guid = guid.raw();
    return list.find(item => item.guid === _guid) ? generateGuid(list) : _guid;
}

/**
 * Garante que a data inserida não seja uma data no futuro.
 * @param {string} dateTime
 */
export function notAcceptFuture(dateTime) {

    const date = new Date(dateTime);
    date.setDate(date.getDate() + 1);
    const now = new Date();

    if (date.getMonth() > now.getMonth()) {
        date.setMonth(now.getMonth());
        dateTime = date.toISOString().substring(0, 10);
    }

    if (date.getMonth() >= now.getMonth() && date.getDate() > now.getDate()) {
        date.setDate(now.getDate() - 1);
        dateTime = date.toISOString().substring(0, 10);
    }

    return dateTime;
}