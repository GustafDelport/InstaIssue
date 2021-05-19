import React, { Component } from "react";
import {Alert, Button, ButtonToolbar, Divider, FlexboxGrid, Rate} from "rsuite";

// Data
import ReviewService from '../../../../services/jobs/reviews.service';

// CSS
import '../../../../styles/components/jobs.css';

export default class ReviewedJobsComponent extends Component {
    constructor(props) {
        super(props);

        this.state = {
            user: undefined,
            reviews: undefined
        }
    }

    componentDidMount() {
        // Get all reviewed jobs
        ReviewService.getAll()
            .then(res => {
                this.setState({
                    reviews: res.data
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

    render() {
        return (
            <div>
                <FlexboxGrid justify="space-around">
                    {this.state.reviews && this.state.reviews.map((review, i) => {
                        return (
                            <FlexboxGrid.Item colspan={4} key={i} className="job">
                                <h4>{review.jobID}</h4>
                                <p>Rating</p>
                                <Rate defaultValue={review.rating} size="xs" allowHalf readOnly />
                                <Divider />
                                <p>{review.description}</p>
                                <ButtonToolbar>
                                    <Button appearance="ghost" href={"/admin/feedback/" + review.jobID}>Feedback</Button>
                                </ButtonToolbar>
                            </FlexboxGrid.Item>
                        )
                    })}
                </FlexboxGrid>
            </div>
        )
    }

}