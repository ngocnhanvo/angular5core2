import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'aduser',
    templateUrl: './aduser.component.html'
})

export class AdUserComponent {
    forecasts?: any;
    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/VNN/AllUser').subscribe(result => {
            this.forecasts = result.json();
        }, error => console.error(error));
    }
}
