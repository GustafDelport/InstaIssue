import React, { Component } from "react";
import {Alert, Table} from "rsuite";

// Data
import ClientDataService from '../../../../../services/client/client.service';

const { Column, HeaderCell, Cell, Pagination } = Table;

export default class ListClientsComponent extends Component {
    constructor(props) {
        super(props);
        this.setClientData = this.setClientData.bind(this);
        this.handlePageChange = this.handlePageChange.bind(this);
        this.handleLengthChange = this.handleLengthChange.bind(this);
        this.getClients = this.getClients.bind(this);

        this.state = {
            clientData: undefined,
            clientDataFiltered: undefined,
            user: undefined,
            isAdmin: false,
            loading: false,
            displayLength: 10,
            page: 1
        };
    }

    componentWillMount() {
        // Get belt data here
        this.getClients();
    }

    setClientData = async data => {
        const { displayLength, page } = this.state;
        let filteredData = data.filter((v, i) => {
            const start = displayLength * (page - 1);
            const end = start + displayLength;
            return i >= start && i < end;
        });

        await this.setState({
            clientData: data,
            clientDataFiltered: filteredData
        });
    }

    getClients() {
        // Get clients here
        ClientDataService.getAll()
            .then(res => {
                this.setClientData(res.data);
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

    handlePageChange(dataKey) {
        this.setState({
            page: dataKey
        });
        this.getClients();
    }

    handleLengthChange(dataKey) {
        this.setState({
            page: 1,
            displayLength: dataKey
        });
        this.getClients();
    }

    render() {
        const { loading, displayLength, page } = this.state;
        if (this.state.clientData) {
            return (
                <div>
                    <Table height={420} data={this.state.clientDataFiltered} loading={loading}>
                        <Column width={100} align="center">
                            <HeaderCell>clientID</HeaderCell>
                            <Cell dataKey="clientID" />
                        </Column>

                        <Column width={100}>
                            <HeaderCell>userID</HeaderCell>
                            <Cell dataKey="userID" />
                        </Column>

                        <Column width={100}>
                            <HeaderCell>Name</HeaderCell>
                            <Cell dataKey="name" />
                        </Column>

                        <Column width={100}>
                            <HeaderCell>Surname</HeaderCell>
                            <Cell dataKey="surname" />
                        </Column>

                        <Column width={150}>
                            <HeaderCell>NationalID</HeaderCell>
                            <Cell dataKey="nationalID" />
                        </Column>

                        <Column width={150}>
                            <HeaderCell>Phone Number</HeaderCell>
                            <Cell dataKey="phoneNumber" />
                        </Column>

                        <Column width={150}>
                            <HeaderCell>Email</HeaderCell>
                            <Cell dataKey="email" />
                        </Column>

                        <Column width={200}>
                            <HeaderCell>Address</HeaderCell>
                            <Cell dataKey="address" />
                        </Column>
                    </Table>

                    <Pagination
                        lengthMenu={[
                            {
                                value: 10,
                                label: 10
                            },
                            {
                                value: 20,
                                label: 20
                            },
                            {
                                value: 30,
                                label: 30
                            },
                            {
                                value: 40,
                                label: 40
                            },
                            {
                                value: 50,
                                label: 50
                            },
                            {
                                value: 100,
                                label: 100
                            }
                        ]}
                        activePage={page}
                        displayLength={displayLength}
                        total={this.state.clientData.length}
                        onChangePage={this.handlePageChange}
                        onChangeLength={this.handleLengthChange}
                    />
                </div>
            )
        } else {
            return (
                <div>
                    <Table height={420} data={this.state.clientDataFiltered} loading={true}>
                        <Column width={50} align="center">
                            <HeaderCell>clientID</HeaderCell>
                            <Cell dataKey="clientID" />
                        </Column>

                        <Column width={50}>
                            <HeaderCell>userID</HeaderCell>
                            <Cell dataKey="userID" />
                        </Column>

                        <Column width={100}>
                            <HeaderCell>Name</HeaderCell>
                            <Cell dataKey="name" />
                        </Column>

                        <Column width={100}>
                            <HeaderCell>Surname</HeaderCell>
                            <Cell dataKey="surname" />
                        </Column>

                        <Column width={150}>
                            <HeaderCell>NationalID</HeaderCell>
                            <Cell dataKey="nationalID" />
                        </Column>

                        <Column width={150}>
                            <HeaderCell>Phone Number</HeaderCell>
                            <Cell dataKey="phoneNumber" />
                        </Column>

                        <Column width={150}>
                            <HeaderCell>Email</HeaderCell>
                            <Cell dataKey="email" />
                        </Column>

                        <Column width={200}>
                            <HeaderCell>Address</HeaderCell>
                            <Cell dataKey="address" />
                        </Column>
                    </Table>

                    <Pagination
                        lengthMenu={[
                            {
                                value: 10,
                                label: 10
                            },
                            {
                                value: 20,
                                label: 20
                            },
                            {
                                value: 30,
                                label: 30
                            },
                            {
                                value: 40,
                                label: 40
                            },
                            {
                                value: 50,
                                label: 50
                            },
                            {
                                value: 100,
                                label: 100
                            }
                        ]}
                        activePage={page}
                        displayLength={displayLength}
                        onChangePage={this.handlePageChange}
                        onChangeLength={this.handleLengthChange}
                    />
                </div>
            )
        }
    }
}