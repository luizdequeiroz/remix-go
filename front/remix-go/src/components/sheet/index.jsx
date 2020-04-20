import React, { useState, useEffect } from 'react';
import { useSagas, useReducers } from 'react-resaga';

function SheetItem(sheet) {
    return <div className="card">
        <div className="card-header">
            <div className="card-title">
                <div className="text-center pt-2 bg-fff">
                    <h3>{sheet.characterName}</h3>
                </div>
            </div>
        </div>
        <div className="card-body">

        </div>
        <div></div>
    </div>;
}

function Sheets() {
    const { session } = useReducers('session');
    const { getSheetsByUserId } = useSagas();

    const [sheets, setSheets] = useState(null);

    useEffect(() => {
        getSheetsByUserId(session.content.id, response => setSheets(response.content));
    }, [session]); // eslint-disable-line

    return <div className="row">
        {sheets && sheets.map(SheetItem)}
    </div>;
}

export default Sheets;
