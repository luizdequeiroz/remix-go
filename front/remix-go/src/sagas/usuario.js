import { post } from './';
import { REACT_APP_API_REMIXGO } from '../utils';
import { apply } from 'react-resaga';

export function* login(values) {
    
    const response = yield post(REACT_APP_API_REMIXGO, 'Users/Login', values);

    yield apply('session', response.data);
    yield apply('status');
}