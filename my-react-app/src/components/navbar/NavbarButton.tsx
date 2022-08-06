import React from 'react';
import './NavbarButton.css';

interface NavbarButtonName {
  buttonName: string;
}

const NavbarButton: React.FC<NavbarButtonName> = (props: NavbarButtonName) => {
  /* let titleName = `#${props.buttonName}`;*/

  return (
    <a href='#' className='navbarButton'>
      {props.buttonName}
    </a>
  );
};

export default NavbarButton;
