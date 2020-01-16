import React from 'react';
import { Link } from 'react-router-dom';

// import 'bootstrap/dist/css/bootstrap.min.css';

import routes from './routes';

function Template({ children }){
    return (
        <div className="container-fluid">
            <ul>
                {routes.filter(route => route.isMenuItem).map(route => 
                    <Link className="btn" to={route.path}><i>{route.icon}</i> {route.name}</Link>
                )}
            </ul>
            {children}
        </div>
    );
}

export default Template;