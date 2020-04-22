import React from 'react';
import { Link } from "react-router-dom";

import routes from "../routes";

function MenuItem({ name, path, image, imageWidth, key }) {
    return <div className="col-md-6 col-lg-4" key={key}>
        <div className="portfolio-item mx-auto" data-toggle="modal" data-target="#portfolioModal1">
            <Link key={key} to={path}>
                <div className="portfolio-item-caption d-flex align-items-center justify-content-center h-100 w-100">
                    <div className="portfolio-item-caption-content text-center text-white">
                        <h1>{name}</h1>
                    </div>
                </div>
            </Link>
            <img className="img-fluid" src={image} alt={name} width={imageWidth} />
        </div>
    </div>;
}

function MenuSection() {    

    return <>
        <div className="row">
            {routes.filter(route => route.isMenuItem).map((route, index) => <MenuItem {...route} key={index} />)}
        </div>
        {/* <nav className="navbar fixed-bottom" style={{ padding: 0 }}>
            <iframe title="zoldamaps" src="http://zoldamaps.azurewebsites.net/" frameBorder={0} style={{ width: '100%', height: 422, bottom: 0 }}></iframe>
        </nav> */}
    </>;
}

export default MenuSection;