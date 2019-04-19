import React from 'react'

function Contact() {
    const hstyle = {
        textalign: 'center',
        paddingTop: 70
    }
    return (
        <div id="contact">
            <h3>Subscribe to our mailbox</h3>

            <div className="contact-input">
                <input type="email" placeholder="example@gmail.com"/>
                <a href="#">Contact</a>
            </div>
            <h4 style={hstyle}>2021 &copy; Temari Teaching</h4>
        </div>
    )
}
export default Contact
