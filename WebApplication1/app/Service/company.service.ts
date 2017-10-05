import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';
import global = require("../shared/global");
import Global = global.Global;

@Injectable()
export class CompanyService {
    constructor(private _http: Http) { }

    getCompany(companyNumber: string): Observable<any> {
            return this._http.get(Global.BASE_USER_ENDPOINT + '?number=' + companyNumber)
                .map((response: Response) => response.json())
                .catch(this.handleError);   
    }

    private handleError(error: Response) {
        console.error(error);
        return Observable.throw(error.json().error || 'Server error');
    }
}