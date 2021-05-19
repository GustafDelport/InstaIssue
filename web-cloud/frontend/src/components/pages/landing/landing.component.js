import React, { Component } from "react";
import {
    Button,
    ButtonToolbar,
    Container,
    Content, Divider,
    Header
} from "rsuite";
import { Helmet } from "react-helmet";

// Data
import AuthService from '../../../services/authentication/auth.service';

// Utils
import RoleLib from '../../../lib/role.lib';

// Components
import NavbarComponent from "../../partials/navbar.component";
import FooterComponent from "../../partials/footer.component";
import JobsComponent from "./jobs/jobs.component";

export default class LandingComponent extends Component {
    constructor(props) {
        super(props);

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

    render() {
        if (this.state.user) {
            if (this.state.isStaff) {
                return (
                    <Container>
                        <Helmet>
                            <title>InstaIssue | Homepage</title>
                        </Helmet>
                        <NavbarComponent />

                        <Container className="container-content">
                            <Header>

                            </Header>
                            <Content>
                                <div className="content-inner">
                                    <h2>Finished Jobs</h2>
                                    <Divider />
                                    <p>Staff members can't review jobs.</p>
                                    <p><strong>Go to the admin panel</strong></p>
                                    <ButtonToolbar>
                                        <Button appearance="primary" href="/admin">Admin Panel</Button>
                                    </ButtonToolbar>
                                </div>
                            </Content>
                            <FooterComponent />
                        </Container>
                    </Container>
                )
            } else {
                return (
                    <Container>
                        <Helmet>
                            <title>InstaIssue | Homepage</title>
                        </Helmet>
                        <NavbarComponent />

                        <Container className="container-content">
                            <Header>

                            </Header>
                            <Content>
                                <div className="content-inner">
                                    <h2>Finished Jobs</h2>
                                    <Divider />
                                    <JobsComponent/>
                                </div>
                            </Content>
                            <FooterComponent />
                        </Container>
                    </Container>
                )
            }
        } else {
                return (
                    <Container>
                        <Helmet>
                            <title>InstaIssue | Homepage</title>
                        </Helmet>
                        <NavbarComponent />

                        <Container className="container-content">
                            <Header>

                            </Header>
                            <Content>
                                <div className="content-inner">
                                    <h2>Not logged in!</h2>
                                    <ButtonToolbar>
                                        <Button appearance="primary" href="/login">Login</Button>
                                    </ButtonToolbar>
                                </div>
                            </Content>
                            <FooterComponent />
                        </Container>
                    </Container>
                )
            }
        }
    }