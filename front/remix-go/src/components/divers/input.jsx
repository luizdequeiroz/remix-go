import React from 'react';
import { Popover } from 'reactstrap';

export default ({ name, type, placeholder, small, error, errorMessage, list, popoverPosition, children, onKeyUp, min, max, autoFocus, register, className, readOnly }) => {
    const inputProps = { name, type, placeholder, list, onKeyUp, min, max, autoFocus, readOnly };

    inputProps.id = name;

    const theInput =
        type === "textarea" ? <textarea ref={register} className={`form-control no-radius ${className}`} {...inputProps}></textarea>
            : (type === "select" ? <select ref={register} className={`form-control no-radius ${className}`} {...inputProps}>
                <option value="">-- {placeholder} --</option>
                {children}
            </select> : <input ref={register} className={`form-control no-radius ${className}`} {...inputProps} />);

    return (
        <div className={type === "textarea" ? 'container-fluid' : 'form-group'}>
            {theInput}
            {small && <small className="form-text text-muted">{small}</small>}
            {<Popover placement={popoverPosition || 'right'} target={inputProps.id} isOpen={error} >
                <div style={{ padding: 10, backgroundColor: '#dc3545', color: 'white' }}>
                    <span><strong>{errorMessage}</strong></span>
                </div>
            </Popover>}
        </div>
    );
};