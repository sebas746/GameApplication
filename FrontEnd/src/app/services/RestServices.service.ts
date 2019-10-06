import { Injectable } from '@angular/core';
import { Statistics } from '../Models/statistics.model';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Ranking } from '../Models/ranking.model';

@Injectable({
    providedIn: 'root'
})
export class RestService {

    constructor(private http: HttpClient) {
        this.getStatistics();
        this.getTopPlayers();
    }
    getStatistics() {
        let url = environment.GetGameStatistics;
        this.http.get<Statistics[]>(url)
            .subscribe(response =>
                this.statistics = response
            );
    }

    getTopPlayers() {
        let url = environment.TopPlayers;
        this.http.get<Ranking[]>(url)
        .subscribe(response =>
            this.ranking = response
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
    ranking: Ranking[] = [];
}