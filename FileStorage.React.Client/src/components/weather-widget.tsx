import * as React from 'react';
import InputLabel from '@mui/material/InputLabel';
import axios from 'axios'
import { useEffect, useState } from 'react';

export function WeatherWidget() {
    const [folder, setFolder] = useState('');
    useEffect(() => {
        async function getFolder() {
            const response = await axios.get('http://localhost:5003/folder/test');
            console.log(`Response from test folder is: ${response.data}`)
            setFolder(response.data);
        }
        getFolder();
    })
    
    return (<InputLabel>
            {folder}
            </InputLabel>)
}