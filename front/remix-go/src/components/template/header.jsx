import React from 'react';
import { Link } from "react-router-dom";

function Header() {
    return (
        <nav className="navbar text-uppercase fixed-top" id="mainNav">
            <div className="container">
                <Link className="navbar-brand js-scroll-trigger text-black-50" to="/">Início</Link>
                <button className="navbar-toggler navbar-toggler-right text-uppercase font-weight-bold bg-danger text-white">Sair</button>
            </div>
        </nav>
    );
}

export default Header;