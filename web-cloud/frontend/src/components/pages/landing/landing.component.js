import React, { Component } from "react";
import {
    Container,
    Content,
    Footer,
    Header
} from "rsuite";
import { Helmet } from "react-helmet";

// Components
import NavbarComponent from "../../partials/navbar.component";
import FooterComponent from "../../partials/footer.component";

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
                                <p>User</p>
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
                                <p>No user</p>
                            </div>
                        </Content>
                        <FooterComponent />
                    </Container>
                </Container>

            )
        }
    }

}