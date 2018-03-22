import { Component, Inject } from '@angular/core';
import { Http, Headers } from '@angular/http';

@Component({
    selector: 'aduser_add',
    templateUrl: './aduser_add.component.html'
})

export class AdUser_AddComponent {
    forecasts?: any;
    http?: Http;
    baseUrl?: string;
    code_user: string = "";
    name_user: string = "";
    mess_user: string = "";
    hearders: Headers = new Headers({
        'Content-Type': 'application/json'
    });;
    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        this.http = http;
        this.baseUrl = baseUrl;
    }

    addUser(){
        if(this.http != undefined) {
            var data = { code_user:this.code_user, name_user:this.name_user };
            this.http.post(this.baseUrl + 'api/VNN/addUser',
            data, {headers: this.hearders}).subscribe(result => {
                var result1 = result.json();
                this.mess_user = result1.mess;
            });
        }
    }
}
