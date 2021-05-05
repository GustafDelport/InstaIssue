import React, { Component } from "react";
import {
    Button,
    ButtonToolbar,
    Container,
    Content, ControlLabel, Divider, Form, FormControl, FormGroup,
    Header, Rate
} from "rsuite";
import { Helmet } from "react-helmet";

// CSS
import '../../../styles/pages/jobreview.css'

// Components
import NavbarComponent from "../../partials/navbar.component";
import FooterComponent from "../../partials/footer.component";

export default class JobReviewComponent extends Component {
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
                        <title>InstaIssue | Review</title>
                    </Helmet>
                    <NavbarComponent />

                    <Container className="container-content">
                        <Header>

                        </Header>
                        <Content>
                            <div className="content-inner">
                                <h2>Review - Job name here</h2>
                                <Divider />
                                <Form fluid>
                                    <Rate defaultValue={0} allowHalf />
                                    <FormGroup style={{marginTop: '1rem'}}>
                                        <ControlLabel>Anything else?</ControlLabel>
                                        <FormControl rows={5} name="textarea" componentClass="textarea" />
                                    </FormGroup>
                                    <FormGroup>
                                        <ButtonToolbar>
                                            <Button appearance="primary">Submit</Button>
                                            <Button appearance="default">Cancel</Button>
                                        </ButtonToolbar>
                                    </FormGroup>
                                </Form>
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
                        <title>InstaIssue | Review</title>
                    </Helmet>
                    <NavbarComponent />

                    <Container className="container-content">
                        <Header>

                        </Header>
                        <Content>
                            <div className="content-inner">
                                <h2>Review - Job name here</h2>
                                <Divider />
                                <Form fluid>
                                    <Rate defaultValue={0} allowHalf />
                                    <FormGroup style={{marginTop: '1rem'}}>
                                        <ControlLabel>Anything else?</ControlLabel>
                                        <FormControl rows={5} name="textarea" componentClass="textarea" />
                                    </FormGroup>
                                    <FormGroup>
                                        <ButtonToolbar>
                                            <Button appearance="primary">Submit</Button>
                                            <Button appearance="default">Cancel</Button>
                                        </ButtonToolbar>
                                    </FormGroup>
                                </Form>

                            </div>
                        </Content>
                        <FooterComponent />
                    </Container>
                </Container>

            )
        }
    }

}