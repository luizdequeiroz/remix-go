import React from 'react';
import { connect } from 'react-redux';
import { bindReduxForm, post, setValue } from 'react-binder-generalizers';
import { Field } from 'redux-form';
import Input from '../divers/input';
import { Modal } from 'react-bootstrap';
import { FaCog, FaDiceD6, FaDiceD20 } from "react-icons/fa";

function goLogin(values) {

    return [
        setValue('status', {
            icon: <FaCog className="fa-2x fa-spin fa-fw" />,
            message: 'Enviando solicitação...',
            showModal: true
        }),
        post(process.env.REACT_APP_API_REMIXGO, 'Users/Login', 'session', { param: values })
    ];
}

function validate(values) {

    const errors = {};

    if (!values.username) {
        errors.username = "Nome de usuário é obrigatório!";
    }

    if (!values.password) {
        errors.password = "Senha é obrigatória!";
    }

    return errors;
}

function Login({ handleSubmit }) {

    return (
        <Modal show centered>
            <Modal.Body>
                <div className="text-center">
                    <FaDiceD6 className="fa-5x" />&nbsp;
                    <FaDiceD20 className="fa-5x" />
                </div>
                <form onSubmit={handleSubmit} className="control-group">
                    <hr />
                    <div className="form-group">
                        <Field component={Input} type="text" name="username" placeholder="Nome de usuário" small="Informe o nome de usuário de acesso." />
                    </div>
                    <div className="form-group">
                        <Field component={Input} type="password" name="password" placeholder="Senha de usuário" small="Informe a senha de usuário de acesso." />
                    </div>
                    <hr />
                    <input type="submit" value="Entrar" className="btn btn-success btn-lg btn-block" />
                </form>
            </Modal.Body>
        </Modal>
    )
}

export default bindReduxForm(connect)()(goLogin)(validate)(Login);