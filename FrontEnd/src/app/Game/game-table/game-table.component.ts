import { Component, OnInit } from '@angular/core';
import { Player } from 'src/app/Models/player.model';

@Component({
  selector: 'app-game-table',
  templateUrl: './game-table.component.html',
  styleUrls: ['./game-table.component.css']
})
export class GameTableComponent implements OnInit {
  players: string[] = ['Unknown', 'Unknown'];
  winner: string[] = [];

  constructor() { }

  ngOnInit() {
  }

}
