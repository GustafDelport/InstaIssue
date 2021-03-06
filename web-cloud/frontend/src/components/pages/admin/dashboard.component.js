import React, { Component } from "react";
import {
    Container,
    Content, Divider,
    Header, Rate
} from "rsuite";
import { Helmet } from "react-helmet";

// Components
import NavbarComponent from "../../partials/navbar.component";
import FooterComponent from "../../partials/footer.component";
import SidebarComponent from "../../partials/sidebar.component";
import ReviewedJobsComponent from "./jobs/reviewedjobs.component";
import ListClientsComponent from "./clients/components/listClients.component";

export default class DashboardComponent extends Component {
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
                        <title>InstaIssue | Dashboard</title>
                    </Helmet>
                    <NavbarComponent />
                    <SidebarComponent />

                    <Container className="container-content">
                        <Header>
                            <h2>Dashboard</h2>
                            <Divider />
                        </Header>
                        <Content>
                            <div className="content-inner">
                                <h4>Average rating:</h4>
                                <Rate defaultValue={4.5} size="xs" allowHalf readOnly />
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
                        <title>InstaIssue | Dashboard</title>
                    </Helmet>
                    <SidebarComponent />

                    <Container className="container-content">
                        <Header>
                            <h2>Dashboard</h2>
                            <Divider />
                        </Header>
                        <Content>
                            <div className="content-inner">
                                <h3>Reviewed Jobs:</h3>
                                <Divider />
                                <ReviewedJobsComponent />
                                <h3>Clients:</h3>
                                <Divider />
                                <ListClientsComponent />
                            </div>
                        </Content>
                        <FooterComponent />
                    </Container>
                </Container>

            )
        }
    }

}