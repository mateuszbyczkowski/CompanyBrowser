"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var router_1 = require("@angular/router");
var home_component_1 = require("./components/home.component");
var company_component_1 = require("./components/company.component");
var appRoutes = [
    { path: '', redirectTo: 'company', pathMatch: 'full' },
    { path: 'home', component: home_component_1.HomeComponent },
    { path: 'company', component: company_component_1.CompanyComponent }
];
exports.routing = router_1.RouterModule.forRoot(appRoutes);
//# sourceMappingURL=app.routing.js.map