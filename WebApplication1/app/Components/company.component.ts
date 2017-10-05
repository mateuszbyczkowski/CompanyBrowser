import { Component } from '@angular/core';
import { CompanyService } from '../Service/company.service';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ICompany } from '../Models/company';

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

    onSubmit(companyFrm: any) {
        this.msg = "";
        this.companyNumber = this.companyFrm.value.companyNumber;
        if (this.companyNumber) {
            this._companyService.getCompany(this.companyNumber).subscribe(
                data => {
                    if (data)
                        if (data.CompanyId !== 0) {
                            this.company = data;
                        } else {
                            for (var key in this.company) {
                                this.company[key] = null;
                            }
                            this.msg = "Please type correct number";
                        }
                },
                error => {
                    this.msg = error;
                }
            );
        } else {
            this.msg = "Please type NIP, KRS or REGON";
        }

    }
}