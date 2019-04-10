import React from 'react';


function About(props) {
    return (
        <div id="about">
            <div className="about-image">
                <img src={props.image} alt="" />
            </div>
            <div className="about-text">
                <h1>{props.title}</h1>
                <p>
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Id nam obcaecati possimus quod veritatis tenetur magnam alias, aperiam error atque deserunt dolores! Dolore suscipit eaque doloribus dolor dicta, illum impedit!
                </p>
                <button>{props.button}</button>
            </div>
        </div>
    )
}

export default About
