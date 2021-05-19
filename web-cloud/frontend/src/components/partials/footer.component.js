import React, { Component } from "react";
import {
    Footer
} from "rsuite";

export default class FooterComponent extends Component {

    render() {
        return (
            <Footer style={{textAlign: 'center'}}>Copyright © {new Date().getFullYear()}</Footer>
        )
    }

}