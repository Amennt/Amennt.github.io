import React from 'react';
import './NavbarLogo.css';

interface NavbarLogo {
  logoName: string;
  /* imageName: string;*/
}

const NavbarLogo: React.FC<NavbarLogo> = (props: NavbarLogo) => {
  return (
    <div className='NavbarLogo'>
      <div>{props.logoName}</div>
    </div>
  );
};

export default NavbarLogo;
