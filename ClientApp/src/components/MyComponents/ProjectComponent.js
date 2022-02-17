import React, { Component } from 'react'

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
                </div>
            </div>
        )
    }
}

