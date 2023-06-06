import React from 'react';
import { useAuth } from '../AuthContext';

const Home = () => {

    const { user } = useAuth();

    const onButtonClick = () => {
        window.location.reload();
    }

    return (
        <>
            {user && <h1>Hello {user.firstName} {user.lastName}</h1>}
            <h1>Home Page</h1>
            <button className='btn btn-danger' onClick={onButtonClick}>Refresh</button>
        </>)
}

export default Home;