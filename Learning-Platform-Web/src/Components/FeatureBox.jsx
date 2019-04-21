import React from 'react'

function FeatureBox(props) {
    return (
        <div className="a-box">
            <a href="">
                <div className="a-b-img">
                    <img src={`data:image/jpeg;base64,${props.image}`} alt="" />
                </div>
                <div className="s-b-text">
                    <h2>{props.title}</h2>
                </div>
            </a>
        </div>
    )
}

export default FeatureBox
