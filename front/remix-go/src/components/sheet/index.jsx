import React, { useState, useEffect } from 'react';
import { useSagas, useReducers } from 'react-resaga';
import MSCard from './ms-card';
import { getColor } from '../../utils';

function Sheets() {
    const { session } = useReducers('session');
    const { getSheetsByUserId } = useSagas();

    const [sheets, setSheets] = useState(null);

    useEffect(() => {
        getSheetsByUserId(session.content.id, response => setSheets(response.content));
    }, [session]); // eslint-disable-line    

    return <div className="row pl-5">
        {sheets && sheets.map((sheet, index) => 
            <MSCard type={getColor(index)} {...sheet} />
        )}
    </div>;
}

export default Sheets;
