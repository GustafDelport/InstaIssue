import React, { Component } from "react";
import {Button, ButtonToolbar, FlexboxGrid} from "rsuite";

// CSS
import '../../../../styles/components/jobs.css';

export default class JobsComponent extends Component {
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
                        <ButtonToolbar>
                            <Button appearance="ghost" href="/job/demo">Review</Button>
                        </ButtonToolbar>
                    </FlexboxGrid.Item>
                    <FlexboxGrid.Item colspan={4} className="job">
                        <h4>Job</h4>
                        <p>Rating</p>
                        <ButtonToolbar>
                            <Button appearance="ghost" href="/job/demo">Review</Button>
                        </ButtonToolbar>
                    </FlexboxGrid.Item>
                    <FlexboxGrid.Item colspan={4} className="job">
                        <h4>Job</h4>
                        <p>Rating</p>
                        <ButtonToolbar>
                            <Button appearance="ghost" href="/job/demo">Review</Button>
                        </ButtonToolbar>
                    </FlexboxGrid.Item>
                    <FlexboxGrid.Item colspan={4} className="job">
                        <h4>Job</h4>
                        <p>Rating</p>
                        <ButtonToolbar>
                            <Button appearance="ghost" href="/job/demo">Review</Button>
                        </ButtonToolbar>
                    </FlexboxGrid.Item>
                    <FlexboxGrid.Item colspan={4} className="job">
                        <h4>Job</h4>
                        <p>Rating</p>
                        <ButtonToolbar>
                            <Button appearance="ghost" href="/job/demo">Review</Button>
                        </ButtonToolbar>
                    </FlexboxGrid.Item>
                    <FlexboxGrid.Item colspan={4} className="job">
                        <h4>Job</h4>
                        <p>Rating</p>
                        <ButtonToolbar>
                            <Button appearance="ghost" href="/job/demo">Review</Button>
                        </ButtonToolbar>
                    </FlexboxGrid.Item>
                    <FlexboxGrid.Item colspan={4} className="job">
                        <h4>Job</h4>
                        <p>Rating</p>
                        <ButtonToolbar>
                            <Button appearance="ghost" href="/job/demo">Review</Button>
                        </ButtonToolbar>
                    </FlexboxGrid.Item>
                </FlexboxGrid>
            </div>
        )
    }

}