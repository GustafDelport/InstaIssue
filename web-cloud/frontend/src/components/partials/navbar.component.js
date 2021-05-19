import React, { Component } from "react";
import {
    Nav,
    Navbar,
    Icon
} from "rsuite";
import {Link} from "react-router-dom";

export default class NavbarComponent extends Component {
    constructor(props) {
        super(props);

        this.state = {
            user: {},
        }
    }

    render() {
        const { user } = this.state;
        return (
            <Navbar>
                <Navbar.Header>
                    <a className="navbar-brand logo" href="/">Insta-Issue</a>
                </Navbar.Header>
                <Navbar.Body>
                    <Nav>
                        {user && (
                            <Nav.Item icon={<Icon icon="home" />} href="/">Home</Nav.Item>
                        )}
                    </Nav>
                    <Nav pullRight>
                        <Nav.Item href="/admin">Admin</Nav.Item>
                        {user ? (
                            <Nav.Item>Logout</Nav.Item>
                        ) : (
                            <Nav.Item href="/login">Sign-in</Nav.Item>
                        )}
                    </Nav>
                </Navbar.Body>
            </Navbar>
        )
    }

}