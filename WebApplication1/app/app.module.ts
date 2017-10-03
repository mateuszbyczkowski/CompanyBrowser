import { NgModule } from '@angular/core';
import { APP_BASE_HREF } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { routing } from './app.routing';
import { HomeComponent } from './components/home.component';
import { CompanyComponent } from './components/company.component';
import { CompanyService } from './Service/company.service';



@NgModule({
    imports: [BrowserModule, ReactiveFormsModule, HttpModule, routing],
    declarations: [AppComponent, CompanyComponent, HomeComponent],
    providers: [{ provide: APP_BASE_HREF, useValue: '/' }, CompanyService],
    bootstrap: [AppComponent]
})

export class AppModule { }