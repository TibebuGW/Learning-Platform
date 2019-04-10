import React from 'react';


function Header() {
    const divStyle = {
        color: 'white',
        
      };
    return (
        <div id="main">
             
            <div className="name">
                <h1><span>Learn Difficult Concepts</span> <span style={divStyle}>With</span> Confidenc<span style={divStyle}>e</span></h1>
                <p className="details">Lorem, ipsum dolor sit amet consectetur adipisicing elit. Officiis, nisi.
                </p>
            </div>
        </div>
    )
}

export default Header;
