import { Component, OnInit } from '@angular/core';
import { Player } from 'src/app/Models/player.model';
import { GameService } from '../game.service';
import { Results } from 'src/app/Models/results.model';

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
  
  constructor(private gameService: GameService) {

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
      this.currentRound = 3;
      console.log('the winner: ' + this.winner);
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
