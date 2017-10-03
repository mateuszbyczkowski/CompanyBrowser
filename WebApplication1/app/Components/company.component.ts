import { Component, OnInit } from '@angular/core';
import { CompanyService } from '../Service/company.service';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ICompany } from '../Models/company';
import { Observable } from 'rxjs/Rx';
import { Global } from '../Shared/global';

@Component({

    templateUrl: 'app/Components/company.component.html'

})

export class CompanyComponent implements OnInit {
     // @ViewChild('modal') modal: ModalComponent;
    company: ICompany;
    msg: string;
    indLoading: boolean = false;
    companyFrm: FormGroup;
    constructor(private fb: FormBuilder, private _companyService: CompanyService) { }

    ngOnInit(): void {

        this.companyFrm = this.fb.group({
            CompanyId: [''],
            Name: [''],
            Street: [''],
            StreetNumber: [''],
            Postcode: [''],
            City: [''],
            Nip: [''],
            Krs: [''],
            Regon: ['']
        });

        this.LoadCompany();

    }

    // LoadCompany(): void {
    //    this.indLoading = true;
    //    var numb: number = 777777777;
    //    this._companyService.get(Global.BASE_USER_ENDPOINT, numb)
    //        .subscribe(company => { this.company = company; this.indLoading = false; },
    //            error => this.msg = <any>error);
    // }

    LoadCompany(): void {
        this.indLoading = true;
        var numb: number = 777777777;
        this._companyService.get(Global.BASE_USER_ENDPOINT, numb)
            .subscribe(company => { this.company = company; this.indLoading = false; },
                error => this.msg = <any>error);
    }

    SetControlsState(isEnable: boolean) {
        isEnable ? this.companyFrm.enable() : this.companyFrm.disable();
    }

    onSubmit(formData: any) {
        this.msg = "";
        var numb: number = 777777777;
        this._companyService.get(Global.BASE_USER_ENDPOINT, numb).subscribe(
            data => {
                if (data === 1) {
                    this.msg = "Data successfully taken.";
                    this.LoadCompany();
                } else {
                     this.msg = "There is some issue in saving records, please contact to system administrator!";
                }
            },
            error => {
                this.msg = error;
            }
        );
    }
}