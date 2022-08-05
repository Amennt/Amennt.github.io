import React from 'react';
import './NavbarButton.css';

interface NavbarButtonName {
  buttonName: string;
}

const NavbarButton: React.FC<NavbarButtonName> = (props: NavbarButtonName) => {
  return <button className='navbarButton'>{props.buttonName}</button>;
};

export default NavbarButton;
