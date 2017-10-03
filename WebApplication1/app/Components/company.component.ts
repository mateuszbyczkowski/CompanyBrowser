import { Component, OnInit } from '@angular/core';
import { CompanyService } from '../Service/company.service';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ICompany } from '../Models/company';
import { Observable } from 'rxjs/Rx';
import { Global } from '../Shared/global';

@Component({

    templateUrl: 'app/Components/company.component.html'

})

export class CompanyComponent {
    company: ICompany;
    msg: string;
    companyNumber: string;
    companyFrm: FormGroup;
    constructor(private fb: FormBuilder, private _companyService: CompanyService) {
        this.companyFrm = this.fb.group({
            companyNumber: [''],
        });
    }

    //ngOnInit(): void {

    //    this.companyFrm = this.fb.group({
    //        CompanyId: [''],
    //        Name: [''],
    //        Street: [''],
    //        StreetNumber: [''],
    //        Postcode: [''],
    //        City: [''],
    //        Nip: [''],
    //        Krs: [''],
    //        Regon: ['']
    //    });

    //    this.LoadCompany();

    //}

    // LoadCompany(): void {
    //    this.indLoading = true;
    //    var numb: number = 777777777;
    //    this._companyService.get(Global.BASE_USER_ENDPOINT, numb)
    //        .subscribe(company => { this.company = company; this.indLoading = false; },
    //            error => this.msg = <any>error);
    // }

    //LoadCompany(): void {
    //    this.indLoading = true;
    //    var numb: string = "7777777777";
    //    this._companyService.get(Global.BASE_USER_ENDPOINT, numb)
    //        .subscribe(company => { this.company = company; this.indLoading = false; },
    //            error => this.msg = <any>error);
    //}

    //SetControlsState(isEnable: boolean) {
    //    isEnable ? this.companyFrm.enable() : this.companyFrm.disable();
    //}

    onSubmit(companyFrm: any) {
        this.msg = "";
        this.companyNumber = this.companyFrm.value.companyNumber;
        this._companyService.get(Global.BASE_USER_ENDPOINT, this.companyNumber).subscribe(
            data => {
                if (data) {
                    this.company = data; 
                }
                else {
                     this.msg = "Type correct number";
                }
            },
            error => {
                this.msg = error;
            }
        );
    }
}