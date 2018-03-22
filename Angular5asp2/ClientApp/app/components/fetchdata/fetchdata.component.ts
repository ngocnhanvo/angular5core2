import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {
    forecasts?: AdUser[];
    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/VNN/AllUser').subscribe(result => {
            this.forecasts = result.json() as AdUser[];
        }, error => console.error(error));
    }
}

interface AdUser {
    adUserId: string;
    adRoleId:string;
    usercode:string;
    username:string;
    birthday?:Date;
    gender:string;
    status:string;
    marital:string;
    address:string;
    city:string;
    email:string;
    phone:string;
    avatar:string;
    backgroundLayout:string;
    facebook:string;
    skype:string;
    job:string;
    createby:string;
    updateby:string;
    created?:Date;
    updated?:Date;
    active?:Boolean;
}
