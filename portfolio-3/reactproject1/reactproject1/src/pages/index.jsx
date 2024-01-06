
import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Me from './Me/Me';
import Projects from './Project/Project';
import Work from './Work/Work';
import Education from './Education/Education';

const Pages = ({ user }) => {
    return (
        <Router>
            <Routes>
                <Route exact path="/" element={<Me user={user} />} />
                <Route path="/projects" element={<Projects user={user} />} />
                <Route path="/work" element={<Work user={user} />} />
                <Route path="/education" element={<Education user={user} />} />
            </Routes>
        </Router>
    );
};

export default Pages;