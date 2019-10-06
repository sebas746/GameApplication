import { Component, OnInit } from '@angular/core';
import { RestService } from 'src/app/services/RestServices.service';
import { Ranking } from 'src/app/Models/ranking.model';

@Component({
  selector: 'app-ranking-players',
  templateUrl: './ranking-players.component.html',
  styleUrls: ['./ranking-players.component.css']
})
export class RankingPlayersComponent implements OnInit {

  constructor(private repoService: RestService) { }

  get ranking(): Ranking[] { return this.repoService.ranking; }
  
  ngOnInit() {
  }

}
