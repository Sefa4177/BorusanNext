import React from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Header from './components/Header/Header';
import Homepage from './pages/Homepage/Homepage';
import Login from './pages/Login/Login';
import Details from './pages/Details/Details';

const App = () => {
  return (
    <>
      <BrowserRouter>
        <Header />
        <Routes>
          <Route path="/" element={<Homepage />} />
          <Route path="/login" element={<Login />} />
          <Route path="/details/:id/" element={<Details />} />
        </Routes>
      </BrowserRouter>
    </>
  );
};

export default App;