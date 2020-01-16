/* eslint-disable global-require */
/* eslint-disable no-underscore-dangle */
import { genericReducer as reducers } from 'react-binder-generalizers'; // TODO: lib
import { createStore, compose, applyMiddleware, combineReducers } from 'redux';
import createSagaMiddleware from 'redux-saga';
import { persistState } from 'redux-devtools';
import { reducer as reduxForm } from 'redux-form';
import multi from 'redux-multi';

import DevTools from '../devtools';

import sagas from '../sagas';

import setPrototypesPlus from 'prototypes-plus';

const sagaMiddleware = createSagaMiddleware();
const enhacer = compose(
    DevTools.instrument(),
    persistState(
        window.location.href.match(
            /[?&]debug_session=([^&#]+)\b/
        )
    )
);

// Inicialização da Store do Redux, Redux-Form, Redux-Multi, e aplicando a instância do DevTools e do Saga
export default function configureStore() {
    const store = applyMiddleware(sagaMiddleware, multi)(createStore)(
        combineReducers({ reducers, form: reduxForm }),
        enhacer
    );

    sagaMiddleware.run(sagas);
    setPrototypesPlus();
    return store;
}