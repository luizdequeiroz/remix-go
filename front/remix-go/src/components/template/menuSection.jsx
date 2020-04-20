import React from 'react';
import { Link } from "react-router-dom";

import routes from "../routes";
import DicesDivider from './dices-divider';

function MenuItem({ name, path, image, imageWidth, key }) {
    return (
        <div className="col-md-6 col-lg-4" key={key}>
            <Link key={key} to={path} className="without-border">
                <div className="portfolio-item mx-auto" data-toggle="modal" data-target="#portfolioModal1">
                    <div className="portfolio-item-caption d-flex align-items-center justify-content-center h-100 w-100">
                        <div className="portfolio-item-caption-content text-center text-white">
                            <h1>{name}</h1>
                        </div>
                    </div>
                    <img className="img-fluid" src={image} alt={name} width={imageWidth} />
                </div>
            </Link>
        </div>
    );
}

function MenuSection() {
    return <>
        <DicesDivider />
        <div className="row">
            {routes.filter(route => route.isMenuItem).map((route, index) => <MenuItem {...route} key={index} />)}
        </div>
        <nav className="navbar fixed-bottom" style={{ padding: 0 }}>
            <iframe title="zoldamaps" src="http://zoldamaps.azurewebsites.net/" frameBorder={0} style={{ width: '100%', height: 422, bottom: 0 }}></iframe>
        </nav>
    </>;
}

export default MenuSection;