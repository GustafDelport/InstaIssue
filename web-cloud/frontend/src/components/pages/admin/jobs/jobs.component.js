import React, { Component } from "react";
import {
    Container,
    Content, Divider,
    Header
} from "rsuite";
import { Helmet } from "react-helmet";

// Components
import NavbarComponent from "../../../partials/navbar.component";
import FooterComponent from "../../../partials/footer.component";
import SidebarComponent from "../../../partials/sidebar.component";
import ReviewedJobsComponent from "./reviewedjobs.component";

export default class JobsComponent extends Component {
    constructor(props) {
        super(props);

        this.state = {
            user: undefined,
            isStaff: false
        }
    }

    render() {
        if (this.state.isStaff) {
            return (
                <Container>
                    <Helmet>
                        <title>InstaIssue | Reviewed Jobs</title>
                    </Helmet>
                    <NavbarComponent />
                    <SidebarComponent />

                    <Container className="container-content">
                        <Header>
                            <h2>Reviewed Jobs</h2>
                            <Divider />
                        </Header>
                        <Content>
                            <div className="content-inner">
                                <ReviewedJobsComponent />
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
                        <title>InstaIssue | Reviewed Jobs</title>
                    </Helmet>
                    <SidebarComponent />

                    <Container className="container-content">
                        <Header>
                            <h2>Reviewed Jobs</h2>
                            <Divider />
                        </Header>
                        <Content>
                            <div className="content-inner">
                                <ReviewedJobsComponent />
                            </div>
                        </Content>
                        <FooterComponent />
                    </Container>
                </Container>

            )
        }
    }

}