import React, { Component } from "react";
import {
    Alert,
    Button,
    ButtonToolbar,
    Container,
    Content, ControlLabel, Divider, Form, FormControl, FormGroup,
    Header, Rate
} from "rsuite";
import { Helmet } from "react-helmet";

// Data
import JobsService from '../../../services/jobs/jobs.service';
import ReviewService from '../../../services/jobs/reviews.service';
import AuthService from '../../../services/authentication/auth.service';

// CSS
import '../../../styles/pages/jobreview.css'

// Components
import NavbarComponent from "../../partials/navbar.component";
import FooterComponent from "../../partials/footer.component";
import RoleLib from "../../../lib/role.lib";

export default class JobReviewComponent extends Component {
    constructor(props) {
        super(props);
        this.setJob = this.setJob.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
        this.submitRating = this.submitRating.bind(this);

        this.initialReview = {
            clientID: undefined,
            Timestamp: new Date(),
            rating: 0.0,
            description: "",
            staffID: undefined,
            jobID: props.match.params.id
        }
        this.review = this.initialReview;

        this.state = {
            user: undefined,
            jobID: props.match.params.id,
            job: undefined,
            formValue: {
                rating: 0.0,
                description: ""
            },
            rating: 0.0,
            submitted: false
        }
    }

    componentDidMount() {
        // Get the user account
        const user = AuthService.getCurrentUser();

        if (user) {
            this.setState({
                user: user,
            })
        }

        // Get job data
        JobsService.get(this.state.jobID)
            .then(res => {
                this.setJob(res.data);
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

    setJob = async data => {
        await this.setState({
            job: data[0]
        });
        console.log(this.state.job)
    }

    handleSubmit = () => {
        const { formValue } = this.state;
        this.review.rating = formValue.rating;
        this.review.description = formValue.description;
        this.submitRating();
    }

    submitRating = () => {
        let review = {
            clientID: this.state.job.clientID,
            Timestamp: new Date(),
            rating: this.review.rating,
            description: this.review.description,
            staffID: this.state.job.staffID,
            jobID: this.state.job.jobID
        }

        ReviewService.create(review)
            .then(res => {
                this.review = res.data;
                this.setState({
                    submitted: true
                });
                console.log(res.data);
            })
            .catch(e => {
                Alert.error(e.toString());
            })
    }

    render() {
        if (this.state.user) {
            const { formValue } = this.state;
            return (
                <Container>
                    <Helmet>
                        <title>InstaIssue | Review {this.state.jobID}</title>
                    </Helmet>
                    <NavbarComponent />

                    <Container className="container-content">
                        <Header>

                        </Header>
                        <Content>
                            <div className="content-inner">
                                {this.state.submitted ? (
                                    <div>
                                        <h2>Submitted</h2>
                                        <Divider />
                                        <p><strong>Thank you for your feedback!</strong></p>
                                        <ButtonToolbar>
                                            <Button appearance="primary" href="/">Return to home</Button>
                                        </ButtonToolbar>
                                    </div>
                                ) : (
                                    <div>
                                        <h2>Review - {this.state.job ? this.state.job.jobID : 'Undefined'}</h2>
                                        <Divider />
                                        <Form fluid ref={ref => (this.form = ref)} onChange={formValue => {this.setState({ formValue });}} formValue={formValue}>
                                            <Rate defaultValue={0} value={this.state.rating} onChange={value => {formValue.rating = value;
                                                console.log(value); this.setState({rating: value})}} allowHalf />
                                            <FormGroup style={{marginTop: '1rem'}}>
                                                <ControlLabel>Anything else?</ControlLabel>
                                                <FormControl rows={5} name="description" componentClass="textarea" />
                                            </FormGroup>
                                            <FormGroup>
                                                <ButtonToolbar>
                                                    <Button appearance="primary" onClick={this.handleSubmit}>Submit</Button>
                                                    <Button appearance="default" href="/">Cancel</Button>
                                                </ButtonToolbar>
                                            </FormGroup>
                                        </Form>
                                    </div>
                                    )}
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
                        <title>InstaIssue | Review {this.state.jobID}</title>
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