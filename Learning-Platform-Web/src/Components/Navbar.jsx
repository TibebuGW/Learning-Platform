import React, {useState} from 'react';
import {Link} from 'react-router-dom';
import logo from '../images/logo.jpg';

function Navbar() {
    const [nav, setnav] = useState(false);
    
    const changeBackground = () => {
        if(window.screenY >= 50){
            setnav(true);
        }
        else    
            setnav(false);
    }

    window.addEventListener('scroll', changeBackground);
    return (
        <nav className={nav ? 'nav active': 'nav'}>
            <a href="#" className="logo">
                <img src={logo} height="100px" width="50px" alt="" />
            </a>
            <input type="checkbox" className='menu-btn' id='menu-btn' />
            <label className="menu-icon" for="menu-btn">
                <span className="nav-icon"></span>
            </label>
            <ul className="menu">
                <li><Link to="/">Home</Link></li>
                <li><Link to="/Learning">Continue Learning</Link></li>
                {/* <li><a href="#about">About</a></li>
                <li><a href="#download">Download</a></li>
                <li><a href="#contact">Contact Us</a></li> */}
            </ul>
        </nav>
    )
}

export default Navbar;
