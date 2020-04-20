import React, { useEffect } from 'react';
import { Modal, ModalHeader } from 'reactstrap';
import { useReducers, useApply } from 'react-resaga';

function Status() {
    const { status = false } = useReducers('status');
    const apply = useApply();

    useEffect(() => {
        if (status && status.autohide) {
            window.setTimeout(() => apply('status', { showModal: false }), 3000);
        }
    }, [status]); // eslint-disable-line

    return status && status.showModal && (
        <Modal isOpen={status.showModal}>
            <ModalHeader className="modal-alert">
                <div className={`alert alert-${status.type || 'primary'}`}>
                    {status.icon}
                    <span className="h5">{status.message}</span>
                </div>
            </ModalHeader>
        </Modal>
    );
}

export default Status;