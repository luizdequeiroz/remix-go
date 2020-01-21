import React, { useEffect } from 'react';
import { connect } from 'react-redux';
import { bindDefault } from 'react-binder-generalizers';
import Toast from 'react-bootstrap/Toast';

function Status({ status = false, setValue }) {

    useEffect(() => {
        if (status && status.autohide) {
            window.setTimeout(() => setValue('status', { showModal: false }), 3000);
        }
    }, [status, setValue]);

    return status && status.showModal && (
        <div className="pull-right">
            <div className="mr-3 mt-3">
                <Toast>
                    <Toast.Body>
                        {status.icon}
                        <p className="h5">{status.message}</p>
                    </Toast.Body>
                </Toast>
            </div>
        </div>
    );
}

export default bindDefault(connect)('status')(Status);