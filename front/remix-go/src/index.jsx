import React from "react";
import ReactDOM from "react-dom";
import { Provider } from "react-redux";
import { HashRouter as Router, Route, Switch } from "react-router-dom";

import './assets/style.css';

import store from "./config/store";
import DevTools from "./config/devtools";

import Template from "./components/template";
import routes from "./components/routes";

function App() {
  return (
    <Provider store={store()}>
      <Router>
        <Template>
          <Switch>
            {routes.map((route, index) => (
              <Route {...route} key={index} />
            ))}
          </Switch>
        </Template>
      </Router>
      {process.env.NODE_ENV !== "production" && <DevTools />}
    </Provider>
  );
}

ReactDOM.render(<App />, document.getElementById("app"));
