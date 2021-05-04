import React, { Component } from "react";
import {Sidenav, Nav, Icon } from "rsuite";

export default class AdminNavComponent extends Component {
    constructor(props) {
        super(props);

        this.state = {
            jobs: undefined
        }
    }

    render() {
        return (
            <Sidenav.Body>
                <Nav>
                    <Nav.Item icon={<Icon icon="dashboard" />}>Dashboard</Nav.Item>
                    <Nav.Item icon={<Icon icon="user" />}>Users</Nav.Item>
                    <Nav.Item icon={<Icon icon="suitcase" />}>Jobs</Nav.Item>
                </Nav>
            </Sidenav.Body>
        )
    }

}