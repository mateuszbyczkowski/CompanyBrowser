"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var company_service_1 = require("../Service/company.service");
var forms_1 = require("@angular/forms");
var global_1 = require("../Shared/global");
var CompanyComponent = /** @class */ (function () {
    function CompanyComponent(fb, _companyService) {
        this.fb = fb;
        this._companyService = _companyService;
        this.companyFrm = this.fb.group({
            companyNumber: [''],
        });
    }
    CompanyComponent.prototype.onSubmit = function (companyFrm) {
        var _this = this;
        this.msg = "";
        this.companyNumber = this.companyFrm.value.companyNumber;
        if (this.companyNumber) {
            this._companyService.get(global_1.Global.BASE_USER_ENDPOINT, this.companyNumber).subscribe(function (data) {
                if (data)
                    if (data.CompanyId !== 0) {
                        _this.company = data;
                    }
                    else {
                        for (var key in _this.company) {
                            _this.company[key] = null;
                        }
                        _this.msg = "Please type correct number";
                    }
            }, function (error) {
                _this.msg = error;
            });
        }
        else {
            this.msg = "Please type NIP, KRS or REGON";
        }
    };
    CompanyComponent = __decorate([
        core_1.Component({
            templateUrl: 'app/Components/company.component.html'
        }),
        __metadata("design:paramtypes", [forms_1.FormBuilder, company_service_1.CompanyService])
    ], CompanyComponent);
    return CompanyComponent;
}());
exports.CompanyComponent = CompanyComponent;
//# sourceMappingURL=company.component.js.map