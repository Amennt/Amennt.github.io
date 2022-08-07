import React from 'react';
import NavbarButton from './NavbarButton';
import NavbarLogo from './NavbarLogo';
import './Navbar.css';

const Navbar = () => {
  return (
    <div className='Navbar'>
      <div className='NavbarLogo'>
        <NavbarLogo logoName='<Miłosz Koza />' />
      </div>
      <div className='NavbarButtons'>
        <NavbarButton buttonName='.Home()' />
        <NavbarButton buttonName='.About()' />
        <NavbarButton buttonName='.Skills()' />
        <NavbarButton buttonName='.Contact()' />
      </div>
    </div>
  );
};

export default Navbar;
