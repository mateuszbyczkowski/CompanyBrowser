import { Component } from "@angular/core"
@Component({
    selector: "company-app",
    template: `
               <div>
                  <nav class='navbar navbar-inverse'>
                       <div class='container-fluid'>
                         <ul class='nav navbar-nav'>
                           <li><a [routerLink]="['home']">Home</a></li>
                           <li><a [routerLink]="['company']">Company browser</a></li>
                      </ul>
                      </div>
                 </nav>    
              <div class='container'>
                <router-outlet></router-outlet>
              </div>
             </div>
`
})

export class AppComponent {

}