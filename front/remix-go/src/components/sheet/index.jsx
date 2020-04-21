import React, { useState, useEffect } from 'react';
import { useSagas, useReducers } from 'react-resaga';

function SheetItem(sheet) {
    return <h3>{sheet.characterName}</h3>;
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
