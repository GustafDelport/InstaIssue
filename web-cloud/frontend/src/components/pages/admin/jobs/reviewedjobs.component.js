import React, { Component } from "react";
import {FlexboxGrid, Rate} from "rsuite";

// CSS
import '../../../../styles/components/jobs.css';

export default class ReviewedJobsComponent extends Component {
    constructor(props) {
        super(props);

        this.state = {
            user: undefined
        }
    }

    render() {
        return (
            <div>
                <FlexboxGrid justify="space-around">
                    <FlexboxGrid.Item colspan={4} className="job">
                        <h4>Job</h4>
                        <p>Rating</p>
                        <Rate defaultValue={4.5} size="xs" allowHalf readOnly />
                    </FlexboxGrid.Item>
                    <FlexboxGrid.Item colspan={4} className="job">
                        <h4>Job</h4>
                        <p>Rating</p>
                        <Rate defaultValue={4.5} size="xs" allowHalf readOnly />
                    </FlexboxGrid.Item>
                    <FlexboxGrid.Item colspan={4} className="job">
                        <h4>Job</h4>
                        <p>Rating</p>
                        <Rate defaultValue={4.5} size="xs" allowHalf readOnly />
                    </FlexboxGrid.Item>
                    <FlexboxGrid.Item colspan={4} className="job">
                        <h4>Job</h4>
                        <p>Rating</p>
                        <Rate defaultValue={4.5} size="xs" allowHalf readOnly />
                    </FlexboxGrid.Item>
                    <FlexboxGrid.Item colspan={4} className="job">
                        <h4>Job</h4>
                        <p>Rating</p>
                        <Rate defaultValue={4.5} size="xs" allowHalf readOnly />
                    </FlexboxGrid.Item>
                    <FlexboxGrid.Item colspan={4} className="job">
                        <h4>Job</h4>
                        <p>Rating</p>
                        <Rate defaultValue={4.5} size="xs" allowHalf readOnly />
                    </FlexboxGrid.Item>
                    <FlexboxGrid.Item colspan={4} className="job">
                        <h4>Job</h4>
                        <p>Rating</p>
                        <Rate defaultValue={4.5} size="xs" allowHalf readOnly />
                    </FlexboxGrid.Item>
                </FlexboxGrid>
            </div>
        )
    }

}