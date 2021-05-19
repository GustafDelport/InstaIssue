import React, { Component } from "react";
import {
    Alert, Col,
    Container,
    Content, Divider, Grid,
    Header, Row
} from "rsuite";
import { Helmet } from "react-helmet";

// Data
import JobsService from '../../../../services/jobs/jobs.service';
import ClientService from '../../../../services/client/client.service';

// Components
import FooterComponent from "../../../partials/footer.component";
import SidebarComponent from "../../../partials/sidebar.component";

export default class FeedbackComponent extends Component {
    constructor(props) {
        super(props);

        this.state = {
            user: undefined,
            isStaff: true,
            jobID: props.match.params.id,
            job: undefined,
            clientID: undefined,
            client: undefined
        }
    }

    componentDidMount() {
        // Get job
        console.log(this.state.jobID);
        JobsService.get(this.state.jobID)
            .then(res => {
                this.setState({
                    clientID: res.data[0].clientID,
                    job: res.data[0]
                });
                // Get client
                ClientService.get(res.data[0].clientID)
                    .then(res => {
                        this.setState({
                            client: res.data
                        })
                        console.log(res.data);
                    })
                    .catch(err => {
                        const resMessage =
                            (err.response &&
                                err.response.data &&
                                err.response.data.message) ||
                            err.message ||
                            err.toString();

                        Alert.error(resMessage);
                    })
            })
            .catch(err => {
                const resMessage =
                    (err.response &&
                        err.response.data &&
                        err.response.data.message) ||
                    err.message ||
                    err.toString();

                Alert.error(resMessage);
            })
    }

    render() {
        return (
            <Container>
                <Helmet>
                    <title>InstaIssue | Feedback job id here</title>
                </Helmet>
                <SidebarComponent />

                <Container className="container-content">
                    <Header>
                        <h2>Feedback</h2>
                        <Divider />
                    </Header>
                    <Content>
                        <div className="content-inner">
                            {this.state.client ? (
                                <div>
                                    <Row>
                                        <Col md={6}>
                                            <h4>Client Name:</h4>
                                            <Divider />
                                            <p style={{fontSize: 18}}><strong>{this.state.client[0].name}</strong></p>
                                        </Col>
                                        <Col md={6}>
                                            <h4>Client Surname:</h4>
                                            <Divider />
                                            <p style={{fontSize: 18}}><strong>{this.state.client[0].surname}</strong></p>
                                        </Col>
                                        <Col md={6}>
                                            <h4>Client NationalID:</h4>
                                            <Divider />
                                            <p style={{fontSize: 18}}><strong>{this.state.client[0].nationalID}</strong></p>
                                        </Col>
                                        <Col md={6}>
                                            <h4>Client PhoneNumber:</h4>
                                            <Divider />
                                            <p style={{fontSize: 18}}><strong>{this.state.client[0].phoneNumber}</strong></p>
                                        </Col>
                                    </Row>
                                    <Row style={{marginTop: 60}}>
                                        <Col md={12}>
                                            <h4>Client Address:</h4>
                                            <Divider />
                                            <p style={{fontSize: 18}}><strong>{this.state.client[0].address}</strong></p>
                                        </Col>
                                        <Col md={12}>
                                            <h4>Client Email:</h4>
                                            <Divider />
                                            <p style={{fontSize: 18}}><strong>{this.state.client[0].email}</strong></p>
                                        </Col>
                                    </Row>
                                    <Divider style={{marginTop: 60}} />
                                    <Row style={{marginTop: 60}}>
                                        <Col md={12}>
                                            <h4>JobID:</h4>
                                            <Divider />
                                            <p style={{fontSize: 18}}><strong>{this.state.job.jobID}</strong></p>
                                        </Col>
                                        <Col md={12}>
                                            <h4>Job Service:</h4>
                                            <Divider />
                                            <p style={{fontSize: 18}}><strong>{this.state.job.service}</strong></p>
                                        </Col>
                                    </Row>
                                </div>
                            ) : null}

                        </div>
                    </Content>
                    <FooterComponent />
                </Container>
            </Container>

        )
    }

}