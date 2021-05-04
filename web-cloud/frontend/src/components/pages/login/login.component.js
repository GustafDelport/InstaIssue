import React, { Component } from "react";
import {
    Button,
    ButtonToolbar,
    Col,
    Container,
    Content,
    FlexboxGrid, Form,
    FormControl,
    FormGroup,
    Header,
    HelpBlock, Loader,
    Navbar,
    Panel,
    Schema
} from "rsuite";

// Authentication
import AuthService from '../../../services/authentication/auth.service';

// CSS
import '../../../styles/pages/login.css';

// Components
import FooterComponent from "../../partials/footer.component";
import {Helmet} from "react-helmet";

// Schema
const { StringType } = Schema.Types;
const model = Schema.Model({
    username: StringType().isRequired('This field is required.'),
    password: StringType().isRequired('This field is required.')
});

class TextField extends React.PureComponent {
    render() {
        const { name, label, acceptor, ...props } = this.props;
        return (
            <FormGroup>
                {/*<ControlLabel>{label} </ControlLabel>*/}
                <FormControl name={name} accepter={acceptor} {...props} />
                <HelpBlock>Required</HelpBlock>
            </FormGroup>
        );
    }
}

export default class LoginComponent extends Component {
    constructor(props) {
        super(props);
        this.handleSubmit = this.handleSubmit.bind(this);

        this.state = {
            checkTrigger: 'change',
            formValue: {},
            formError: {},
            loading: false
        };
    }

    handleSubmit() {
        const { formValue } = this.state;
        if (!this.form.check()) {
            Notification['error']({
                title: "Invalid Inputs",
                description: <p>Please provide both a username and password.</p>
            })
            return;
        }

        if (this.form.check()) {
            this.setState({
                loading: true
            })
            AuthService.login(formValue.username, formValue.password)
                .then(() => {
                        console.log("Success!")
                        this.props.history.push("/dashboard");
                        window.location.reload();
                    },
                    error => {
                        const resMessage =
                            (error.response &&
                                error.response.data &&
                                error.response.data.message) ||
                            error.message ||
                            error.toString();

                        this.setState({
                            loading: false
                        });

                        Alert.error(resMessage);
                    });
            //console.log(formValue, 'Form Value');
        }
    }

    render() {
        const { formValue } = this.state;
        return (
            <div className="login-page">
                <Helmet>
                    <title>InstaIssue | Login</title>
                </Helmet>
                <Container>
                    <Header>
                        <Navbar appearance='subtle'>
                            <Navbar.Header>
                                <a className="navbar-brand logo" href="/login">Insta-Issue</a>
                            </Navbar.Header>
                        </Navbar>
                    </Header>
                    <Content>
                        <FlexboxGrid justify="center">
                            <FlexboxGrid.Item componentClass={Col} colspan={24} sm={18} md={12} lg={8}>
                                <Panel header={<h3>Login</h3>} bordered>
                                    <Form
                                        fluid
                                        ref={ref => (this.form = ref)}
                                        onChange={formValue => {
                                            this.setState({ formValue });
                                        }}
                                        onCheck={formError => {
                                            this.setState({ formError });
                                        }}
                                        formValue={formValue}
                                        model={model}
                                    >
                                        <TextField name="username" placeholder="Username" />
                                        <TextField name="password" placeholder="Password" type="password" />
                                        <FormGroup>
                                            <ButtonToolbar>
                                                <Button appearance="primary" onClick={this.handleSubmit} disabled={this.state.loading}>
                                                    {this.state.loading ? (
                                                        <Loader content="Logging in..." />
                                                    ) : (
                                                        <span>Log in</span>
                                                    )}
                                                </Button>
                                                <Button appearance="link">Forgot password?</Button>
                                            </ButtonToolbar>
                                        </FormGroup>
                                    </Form>
                                </Panel>
                            </FlexboxGrid.Item>
                        </FlexboxGrid>
                    </Content>
                    <FooterComponent />
                </Container>
            </div>
        )
    }
}