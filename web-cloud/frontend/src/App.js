import React, { Component } from "react";
import { Switch, Route } from 'react-router-dom';

// CSS
import './App.css';
import 'rsuite/dist/styles/rsuite-dark.css'

// Components
import LandingComponent from "./components/pages/landing/landing.component";
import NotfoundComponent from "./components/pages/notfound/notfound.component";
import LoginComponent from "./components/pages/login/login.component";

class App extends Component {
  constructor(props) {
    super(props);

    this.state = {
      user: undefined
    }
  }

  render() {
    return (
        <div id="app">
          <Switch>
            <Route exact path={["/", "/home"]} component={LandingComponent} />
            <Route exact path={["/login", "/signin"]} component={LoginComponent} />
            {/*<Route exact path={["/", "/home"]} component={AdminComponent} />*/}
            <Route component={NotfoundComponent} />
          </Switch>
        </div>
    )
  }
}

export default App;
