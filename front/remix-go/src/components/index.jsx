import React from "react";
import { Link } from "react-router-dom";

import routes from "./routes";

function Template({ children }) {
  return (
    <>
      <div className="w3_navigation">
        <div className="container">
          <nav className="navbar navbar-default">
            <div className="navbar-header navbar-left">
              <button type="button" className="navbar-toggle collapsed" data-toggle="collapse" data-target="#menu-collapse">
                <span className="sr-only">Toggle navigation</span>
                <span className="icon-bar"></span>
                <span className="icon-bar"></span>
                <span className="icon-bar"></span>
              </button>
              <div className="w3_navigation_pos">
                <h1><Link to="/" title="Remix Go">Remix Go</Link></h1>
              </div>
            </div>
            <div className="collapse navbar-collapse navbar-right" id="menu-collapse">
              <nav className="cl-effect-5" id="cl-effect-5">
                <ul className="nav navbar-nav">
                  {routes.filter(route => route.isMenuItem).map((route, index) => (
                    <li>
                      <Link key={index} className={index === 0 ? "active" : "scroll"} to={route.path}>
                        <span data-hover={route.name}>{route.icon} {route.name}</span>
                      </Link>
                    </li>
                  ))}
                </ul>
              </nav>
            </div>
          </nav>
        </div>
      </div>
      {children}
    </>
  );
}

export default Template;
