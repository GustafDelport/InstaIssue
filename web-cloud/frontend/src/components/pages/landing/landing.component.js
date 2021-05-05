import React, { Component } from "react";
import {
    Container,
    Content, Divider,
    Footer,
    Header
} from "rsuite";
import { Helmet } from "react-helmet";

// Components
import NavbarComponent from "../../partials/navbar.component";
import FooterComponent from "../../partials/footer.component";
import JobsComponent from "./jobs/jobs.component";

export default class LandingComponent extends Component {
    constructor(props) {
        super(props);

        this.state = {
            user: undefined
        }
    }

    render() {
        if (this.state.user) {
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
                                <JobsComponent />
                            </div>
                        </Content>
                        <FooterComponent />
                    </Container>
                </Container>

            )
        }
    }

}