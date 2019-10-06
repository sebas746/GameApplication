import { Component, OnInit } from '@angular/core';
import { Player } from 'src/app/Models/player.model';
import { GameService } from '../game.service';
import { Results } from 'src/app/Models/results.model';
import { RestService } from 'src/app/services/RestServices.service';
import { Statistics } from 'src/app/Models/statistics.model';

@Component({
  selector: 'app-game-table',
  templateUrl: './game-table.component.html',
  styleUrls: ['./game-table.component.css']
})
export class GameTableComponent implements OnInit {  
  winner: string = '';
  currentPlayer: string = this.gameService.players[0];
  currentRound: number = 1;
  isRoundCompletted: boolean = false;
  player1Move: string = '';
  player2Move: string = '';
  winnerModalOpen = false;
  
  constructor(private gameService: GameService, private repoService: RestService) {

  }

  get results(): Results[] { return this.gameService.results; }

  get players(): string[] { return this.gameService.players; }

  ngOnInit() {

  }

  changeCurrentPlayer(move:string) {    
    if(this.currentPlayer === this.gameService.players[0]) {
      this.player1Move = move;
      this.currentPlayer = this.gameService.players[1];
      this.isRoundCompletted = false;
    }
    else {
      this.player2Move = move;
      this.currentPlayer = this.gameService.players[0];
      this.isRoundCompletted = true;
      this.currentRound++;
    }
  }

  checkWinner() {
    if(this.gameService.checkWinner()) {
      this.winner = this.gameService.getWinner();
      this.winnerModalOpen = true;
      this.currentRound--;
      let statistic = new Statistics(0, 
        this.gameService.players[0],
        this.gameService.players[1],
        this.winner, 
        Date.now.toString(),
        this.gameService.currentScore[0] + ' - ' + this.gameService.currentScore[1]  
      )
      this.repoService.createStatistic(statistic);
    }
  }

  getMove(move) {   
    this.changeCurrentPlayer(move);

    if(this.isRoundCompletted) {
      this.gameService.getTurnWinner(this.player1Move, this.player2Move);
      this.checkWinner();
    }
  }

  restartService() {
    this.gameService.restartValues();
    this.winnerModalOpen = false;
    this.currentRound = 1;
    this.winner = '';
  }
}
