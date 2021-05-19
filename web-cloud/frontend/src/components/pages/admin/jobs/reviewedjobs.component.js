import React, { Component } from "react";
import {Divider, FlexboxGrid, Rate} from "rsuite";

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
                        <Divider />
                        <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s</p>
                    </FlexboxGrid.Item>
                    <FlexboxGrid.Item colspan={4} className="job">
                        <h4>Job</h4>
                        <p>Rating</p>
                        <Rate defaultValue={4.5} size="xs" allowHalf readOnly />
                        <Divider />
                        <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s</p>
                    </FlexboxGrid.Item>
                    <FlexboxGrid.Item colspan={4} className="job">
                        <h4>Job</h4>
                        <p>Rating</p>
                        <Rate defaultValue={4.5} size="xs" allowHalf readOnly />
                        <Divider />
                        <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s</p>
                    </FlexboxGrid.Item>
                    <FlexboxGrid.Item colspan={4} className="job">
                        <h4>Job</h4>
                        <p>Rating</p>
                        <Rate defaultValue={4.5} size="xs" allowHalf readOnly />
                        <Divider />
                        <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s</p>
                    </FlexboxGrid.Item>
                    <FlexboxGrid.Item colspan={4} className="job">
                        <h4>Job</h4>
                        <p>Rating</p>
                        <Rate defaultValue={4.5} size="xs" allowHalf readOnly />
                        <Divider />
                        <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s</p>
                    </FlexboxGrid.Item>
                    <FlexboxGrid.Item colspan={4} className="job">
                        <h4>Job</h4>
                        <p>Rating</p>
                        <Rate defaultValue={4.5} size="xs" allowHalf readOnly />
                        <Divider />
                        <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s</p>
                    </FlexboxGrid.Item>
                    <FlexboxGrid.Item colspan={4} className="job">
                        <h4>Job</h4>
                        <p>Rating</p>
                        <Rate defaultValue={4.5} size="xs" allowHalf readOnly />
                        <Divider />
                        <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s</p>
                    </FlexboxGrid.Item>
                </FlexboxGrid>
            </div>
        )
    }

}