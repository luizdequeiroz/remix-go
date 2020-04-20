import React from 'react';
import { useApply } from 'react-resaga';
import { Link } from "react-router-dom";

function Header() {
    const apply = useApply();

    function logout() {
        sessionStorage.clear();
        apply('session');
    }

    return (
        <nav className="navbar text-uppercase fixed-top" id="mainNav">
            <div className="container">
                <Link className="navbar-brand js-scroll-trigger text-black-50 pointer" to="/">Início</Link>
                <button onClick={logout} className="navbar-toggler navbar-toggler-right text-uppercase font-weight-bold bg-danger text-white">Sair</button>
            </div>
        </nav>
    );
}

export default Header;