import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Me from './Me';
/*import Projects from './Projects';
import Work from './Work';
import Education from './Education';
*/
const Pages = ({ user }) => {
    return (
        <Router>
            <Routes>
                <Route exact path="/" element={<Me user={user} />} />
            </Routes>
        </Router>
    );
};

export default Pages;