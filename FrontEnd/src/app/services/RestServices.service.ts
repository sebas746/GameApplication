import { Injectable } from '@angular/core';
import { Statistics } from '../Models/statistics.model';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';

@Injectable({
    providedIn: 'root'
})
export class RestService {

    constructor(private http: HttpClient) {
       this.getStatistics();
    }
    getStatistics() {
        let url = environment.GetGameStatistics;               
        this.http.get<Statistics[]>(url)
        .subscribe(response => 
            this.statistics = response
        );
    }

    createStatistic(statistic: Statistics) {     
        let url = environment.InsertStatistics;
        this.http.post<number>(url, statistic)
            .subscribe(response => {
                console.log(response);
            });
    }

    statistics: Statistics[] = [];
}