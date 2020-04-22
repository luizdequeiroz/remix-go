import React from 'react';

function MSTest(test) {
    return <div className={`btn btn-${test.type} btn-group p-0`}>
        <button className={`btn btn-${test.type} without-border pr-0`} onClick={() => test.onLabelClick(test.testDiceQuantity, test.testDiceFaceQuantity)}><i className={test.icon} /> {test.label}&nbsp;</button>
        <strong className={`btn btn-${test.type} without-border`} onClick={() => test.onTestClick(test.testDiceQuantity, test.testDiceFaceQuantity)}>{test.testDiceQuantity}d{test.testDiceFaceQuantity}</strong>
    </div>;
}

export default MSTest;