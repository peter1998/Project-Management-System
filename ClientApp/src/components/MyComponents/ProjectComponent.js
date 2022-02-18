import React, { Component } from 'react'
import axios from 'axios'

export class ProjectComponent extends Component {
    render() {
        alert("javascript")

        return (
            <div>
                <hr />
                <h2>Projects</h2>
                <br />
                <div className="row">
                    { /* SEARCH PROJECT */}
                    <div className="col-md-4">
                        <div className="card border border-secondary shadow-0">
                            <div className="card-header bg-secondary text-white"><b>Search</b> Project <span className="glyphicon glyphicon-search"></span></div>
                            <div className="card-body">
                                <div className="row">
                                    <div className="col-md-7">
                                        <label className="form-label">Name</label>
                                        <input className="form-control" placeholder="Enter Name" name="name" type="text" />
                                    </div>
                                    <div className="col-md-5">
                                        <label className="form-label">&nbsp;</label>
                                        <div className="btn-toolbar">
                                            <button type="button" className="btn btn-primary form-control">Search</button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    { /* NEW PROJECT */}
                    <div className="col-md-8">
                        <div className="card border border-secondary shadow-0">
                            <div className="card-header bg-secondary text-white"><b>New</b> Project</div>
                            <div className="card-body">
                                <div className="row">
                                    <div className="col-md-3">
                                        <label className="form-label">Name</label>
                                        <input className="form-control" placeholder="Enter Name" name="name" type="text" />
                                    </div>

                                    <div className="col-md-2">
                                        <label className="form-label">&nbsp;</label>
                                        <button type="button" className="btn btn-success form-control">Save</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <br />
                { /* DISPLAY PROJECTS */}
                <div className="card border border-secondary shadow-0">
                    <div className="card-header bg-secondary text-white"><b>Display</b> Projects</div>
                    <div className="card-body">
                        <table className="table table-striped">
                            <thead>
                                <tr>
                                    <th>Name</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td><input className="form-control" type="text" value="Name" /></td>
                                    <div className="btn-toolbar">
                                        <button className="btn btn-info mr-2">Edit</button>
                                        <button className="btn btn-success mr-2">Save</button>
                                        <button className="btn btn-danger mr-2">Delete</button>
                                    </div>
                                
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
            </div>
        )
    }
}

