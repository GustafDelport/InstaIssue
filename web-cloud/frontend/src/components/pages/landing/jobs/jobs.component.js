import React, { Component } from "react";
import {Alert, Button, ButtonToolbar, Col, FlexboxGrid} from "rsuite";

// Data
import ClientJobsService from '../../../../services/jobs/clientJobs.service';
import ClientService from '../../../../services/client/client.service';
import AuthService from '../../../../services/authentication/auth.service';
import ReviewService from '../../../../services/jobs/reviews.service';

// CSS
import '../../../../styles/components/jobs.css';

export default class JobsComponent extends Component {
    constructor(props) {
        super(props);
        this.checkReviwed = this.checkReviwed.bind(this);

        this.state = {
            user: undefined,
            client: undefined,
            jobs: undefined
        }
    }

    async componentDidMount() {
        // Get the user account
        const user = AuthService.getCurrentUser();

        if (user) {
            this.setState({
                user: user,
            })
        }

        // Get the client
        let client = undefined;
        await ClientService.getClient(user.id).then(res => {
            client = res.data[0];
        })

        if (client) {
            this.setState({
                client: client
            })
            // Get all jobs for client
            ClientJobsService.get(client.clientID)
                .then(res => {
                    this.setState({
                        jobs: res.data
                    });
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
    }

    checkReviwed(jobID) {
        if (ReviewService.checkReviewed(jobID)){
            return true;
        } else {
            return false;
        }
    }

    render() {
        return (
            <div>
                <FlexboxGrid justify="start">
                    {this.state.jobs && this.state.jobs.map((job, i) => {
                        if (this.checkReviwed(job.jobID)) {
                            return (
                                <FlexboxGrid.Item key={i} componentClass={Col} colspan={4} className="job">
                                    <h4>{job.service}</h4>
                                    <p>JobID: <strong>{job.jobID}</strong></p>
                                    <ButtonToolbar>
                                        <Button appearance="ghost" href={'/job/' + job.jobID}>Review</Button>
                                    </ButtonToolbar>
                                </FlexboxGrid.Item>
                            )
                        } else {
                            return null;
                        }
                    })}
                </FlexboxGrid>
            </div>
        )
    }

}