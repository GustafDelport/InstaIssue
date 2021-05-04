import React, { Component } from "react";
import {Button, ButtonToolbar, Col, Container, Content, FlexboxGrid, Header} from "rsuite";

// Components
import NavbarComponent from "../../partials/navbar.component";
import FooterComponent from "../../partials/footer.component";
import {Helmet} from "react-helmet";

export default class NotfoundComponent extends Component {
    constructor(props) {
        super(props);

        this.state = {
            user: undefined
        }
    }

    render() {
        return (
            <Container>
                <Helmet>
                    <title>InstaIssue | 404 Page not found</title>
                </Helmet>
                <NavbarComponent />

                <Container className="container-content">
                    <Header>

                    </Header>
                    <Content>
                        <div className="content-inner">
                            <FlexboxGrid justify="center">
                                <FlexboxGrid.Item componentClass={Col} colspan={24} sm={18} md={12} lg={8} order={1} style={{textAlign: "center"}} className="not-found-content">
                                    <div>
                                        <h1>404</h1>
                                        <h4>Page not found</h4>
                                        <ButtonToolbar>
                                            <Button appearance="primary" href="/">Return Home</Button>
                                        </ButtonToolbar>
                                    </div>
                                </FlexboxGrid.Item>
                            </FlexboxGrid>
                        </div>
                    </Content>
                    <FooterComponent />
                </Container>
            </Container>
        )
    }
}