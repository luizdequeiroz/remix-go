import React from 'react';
import { useApply } from 'react-resaga';
import { Link, useHistory } from "react-router-dom";
import { FaDice } from 'react-icons/fa';

function Header() {
    const apply = useApply();
    const history = useHistory();

    function logout() {
        sessionStorage.clear();
        apply('session');
        history.push('/');
    }

    return <nav className="navbar bg-beige text-uppercase fixed-top" id="mainNav">
        <div className="container">
            <Link className="navbar-brand js-scroll-trigger text-black-50 pointer" to="/">Início</Link>
            <h1 className="page-section-heading text-center text-uppercase text-secondary mb-0">Remix GO <FaDice /></h1>
            <button onClick={logout} className="navbar-toggler navbar-toggler-right text-uppercase font-weight-bold bg-danger text-white">Sair</button>
        </div>
    </nav>;
}

export default Header;