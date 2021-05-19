import React, { Component } from "react";
import {
    Nav,
    Navbar,
    Icon
} from "rsuite";

// Data
import AuthService from '../../services/authentication/auth.service';
import RoleLib from "../../lib/role.lib";

export default class NavbarComponent extends Component {
    constructor(props) {
        super(props);
        this.logOut = this.logOut.bind(this);

        this.state = {
            user: undefined,
            isClient: false,
            isStaff: false
        }
    }

    async componentDidMount() {
        // Get the user account
        const user = AuthService.getCurrentUser();

        if (user) {
            const isClient = await RoleLib.isClient(user.id);
            console.log(`Client ${isClient}`);
            const isStaff = await RoleLib.isStaff(user.id);
            console.log(`Staff ${isStaff}`);
            this.setState({
                user: user,
                isClient: isClient,
                isStaff: isStaff
            })
        }
    }

    logOut() {
        AuthService.logout();
        this.setState({
            user: undefined
        })
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
                        {this.state.isStaff ? (
                            <Nav.Item href="/admin">Admin</Nav.Item>
                        ) : null}
                        {user ? (
                            <Nav.Item href="/login" onSelect={this.logOut}>Logout</Nav.Item>
                        ) : (
                            <Nav.Item href="/login">Sign-in</Nav.Item>
                        )}
                    </Nav>
                </Navbar.Body>
            </Navbar>
        )
    }

}