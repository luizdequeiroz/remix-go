import React from "react";
import { render } from "react-dom";
import { Container } from 'react-resaga';
import { HashRouter, Route, Switch } from "react-router-dom";

import sagas from './sagas';

import './assets/style.css';

import Template from "./components/template";
import routes from "./components/routes";

function App() {
  return <Container devtools sagas={sagas}>
    <HashRouter>
      <Template>
        <Switch>
          {routes.map((route, index) => (
            <Route {...route} key={index} />
          ))}
        </Switch>
      </Template>
    </HashRouter>
  </Container>;
}

render(<App />, document.getElementById("app"));