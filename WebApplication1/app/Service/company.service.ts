import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';

@Injectable()
export class CompanyService {
    constructor(private _http: Http) { }

    get(url: string, companyNumber: string): Observable<any> {
        if (companyNumber) {
            return this._http.get(url + '?number=' + companyNumber)
                .map((response: Response) => <any>response.json())
                //.do(data => console.log("All: " + JSON.stringify(data)))
                .catch(this.handleError);
        } else {
            return Observable.of([]);
        }     
    }

    private handleError(error: Response) {
        console.error(error);
        return Observable.throw(error.json().error || 'Server error');
    }
}