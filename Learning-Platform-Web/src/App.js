import React from 'react';
import {BrowserRouter as Router, Route, Switch} from 'react-router-dom';
import Navbar from './Components/Navbar'
import Header from './Components/Header';
import About from './Components/About';
import aboutimage from './images/Frame 19.png';
import question from './images/question.png';
import Contact from './Components/Contact';
import Learning from './Components/Learning';
function App() { 
  return (
    <Router>
      <div className="App">
        <Navbar />

        <Switch>

          <Route exact path="/">
            <Header />
            {/* <Feature /> */}
            <About id="about-us" title="Who we are" image={question} button="Meet The Team" />
            <About id="download" title="Download our Mobile App" image={aboutimage} button="Get The App" />
            <Contact />
          </Route>

          <Route path="/Learning">
            <Learning />
          </Route>
          // app.js info
          </Switch>
      </div>
    </Router>
  );
}

export default App;
