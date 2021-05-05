import React, { Component } from "react";
import { isMobile } from 'react-device-detect';
import {Button, ButtonToolbar, Icon, Nav, Navbar, Sidebar, Sidenav} from "rsuite";

// Components
import AdminNavComponent from "./adminnav.component";

const NavToggle = ({ expand, onChange }) => {
    return (
        <Navbar appearance="subtle" className="nav-toggle">
            <Navbar.Body>
                <Nav pullRight>
                    <Nav.Item onClick={onChange} style={{ width: 56, textAlign: 'center'}}>
                        <Icon icon={expand ? 'angle-left' : 'angle-right'} />
                    </Nav.Item>
                </Nav>
            </Navbar.Body>
        </Navbar>
    );
};

export default class SidebarComponent extends Component {
    constructor(props) {
        super(props);
        this.handleToggle = this.handleToggle.bind(this);

        this.state = {
            jobs: undefined,
            expand: true
        }
    }

    componentDidMount() {
        if (isMobile) {
            this.setState({
                expand: false
            });
        }
    }

    handleToggle() {
        this.setState({
            expand: !this.state.expand
        });
    }

    render() {
        const { expand } = this.state;
        return (
            <Sidebar
                style={{display: 'flex', flexDirection: 'column', backgroundColor: '#1A1D24'}}
                width={expand ? 260 : 56}
                collapsible
            >
                <Sidenav.Header>
                    <ButtonToolbar>
                        <Button appearance="link" href="/"><Icon icon="arrow-circle-left" /> Return Home</Button>
                    </ButtonToolbar>
                </Sidenav.Header>
                <Sidenav
                    expanded={expand}
                    activeKey="1"
                >
                    <AdminNavComponent />
                </Sidenav>
                <NavToggle expand={expand} onChange={this.handleToggle} />
            </Sidebar>
        )
    }

}