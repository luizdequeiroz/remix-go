import React from 'react';
import { useApply, useSagas } from 'react-resaga';
import { useForm } from 'react-hook-form';
import Input from '../divers/input';
import { Modal } from 'react-bootstrap';
import { FaCog, FaDiceD6, FaDiceD20 } from "react-icons/fa";
import DicesDivider from './dices-divider';

function Login() {
    const apply = useApply();
    const { login } = useSagas();
    const { register, handleSubmit, errors } = useForm({ mode: 'onChange' });

    const onSubmit = values => {

        apply('status', {
            icon: <FaCog className="fa-2x fa-spin fa-fw" />,
            message: 'Enviando solicitação...',
            showModal: true
        });

        login(values);
    };

    return (
        <Modal show centered>
            <Modal.Body>
                <div className="text-center">
                    <h2 className="page-section-heading text-center text-uppercase text-secondary mb-0">
                        Remix Go &nbsp;&nbsp;&nbsp;&nbsp;<FaDiceD20 className="fa-3x" />
                    </h2>
                    <DicesDivider />
                </div>
                <form onSubmit={handleSubmit(onSubmit)} className="control-group">
                    <hr />
                    <div className="form-group">
                        <Input
                            register={register({ required: true })}
                            name="username"
                            type="text"
                            placeholder="Nome de acesso"
                            small="Informe o nome de usuário de acesso."
                            errorMessage="Nome de acesso obrigatório!"
                            error={errors['username']}
                            popoverPosition="right"
                        />
                    </div>
                    <div className="form-group">
                        <Input register={register({ required: true })} name="password" type="password" placeholder="Senha de acesso" small="Informe a senha de usuário de acesso." errorMessage="Senha de acesso obrigatória" error={errors['password']} popoverPosition="right" />
                    </div>
                    <hr />
                    <input type="submit" value="Entrar" className="btn btn-success btn-lg btn-block" />
                </form>
            </Modal.Body>
        </Modal>
    )
}

export default Login;