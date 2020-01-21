import React, { useRef, useEffect } from 'react';
import { Popover } from 'reactstrap';

export default ({ input = {}, type, placeholder, small, meta: { touched, error, warning } = {}, list, popoverPosition, children, onKeyUp, min, max, autoFocus, inputRef }) => {
    const inputProps = { type, placeholder, list, onKeyUp, min, max, autoFocus };

    if (inputRef) {
        const ref = useRef(null);
        inputProps.ref = ref;

        useEffect(() => {
            inputRef(ref);
        }, [inputRef]);
    }

    input.id = input.name;

    const theInput =
        type === "textarea" ? <textarea className="form-control no-radius" {...input} {...inputProps}></textarea>
            : (type === "select" ? <select className="form-control no-radius" {...input} {...inputProps}>
                <option value="">-- {placeholder} --</option>
                {children}
            </select> : <input className="form-control no-radius" {...input} {...inputProps} />);

    return (
        <div className={type === "textarea" ? 'container-fluid' : 'form-group'}>
            {theInput}
            {small && <small className="form-text text-muted">{small}</small>}
            {<Popover placement={popoverPosition || 'right'} target={input.id} isOpen={touched && error} >
                <div style={{ padding: 10, backgroundColor: '#dc3545', color: 'white' }}>
                    <span><strong>{error || warning}</strong></span>
                </div>
            </Popover>}
        </div>
    );
};