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
                    <Nav.Item icon={<Icon icon="dashboard" />} href="/admin">Dashboard</Nav.Item>
                    <Nav.Item icon={<Icon icon="suitcase" />} href="/admin/jobs">Jobs</Nav.Item>
                    <Nav.Item icon={<Icon icon="profile" />} href="/admin/clients">Clients</Nav.Item>
                </Nav>
            </Sidenav.Body>
        )
    }

}