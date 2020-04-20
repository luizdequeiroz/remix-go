import { get } from './';
import { REACT_APP_API_REMIXGO } from '../utils';

export function* getSheetsByUserId(id) {

    const response = yield get(REACT_APP_API_REMIXGO, `MS/PlayerId/${id}`);

    return response.data;
}