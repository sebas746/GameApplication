import { Injectable } from '@angular/core';
import { PlayerMovement } from '../Util/enumerators';
import { Results } from '../Models/results.model';

@Injectable({
    providedIn: 'root'
})
export class GameService {

    public checkWinner(): boolean {
        if(this.currentScore[0] == 3 || this.currentScore[1] == 3) {
            return true;
        }
        return false;
    }

    public getWinner(): string {
        if(this.currentScore[0] == 3) {
            return this.players[0];
        }

        if(this.currentScore[1] == 3) {
            return this.players[1];
        }

        return undefined;
    }

    public getTurnWinner(player1Move, player2Move) {
        let result: Results = new Results(
            this.results.length + 1, //Round
            'Draw', //Winner 
            '', //Player 1 move 
            '', //Player 2 move           
            this.players[0],  //Player 1
            this.players[1]  //Player 2
        );

        if (player1Move != undefined && player2Move != undefined) {
            switch (player1Move) {
                case PlayerMovement.Rock: {
                    if (player2Move === PlayerMovement.Paper) {
                        result.playerWinner = this.players[1];
                        result.player1Move = PlayerMovement.Rock;
                        result.player2Move = PlayerMovement.Paper;
                        this.currentScore[1] = this.currentScore[1] + 1;
                    }
                    else if (player2Move === PlayerMovement.Scissors) {
                        result.playerWinner = this.players[0];
                        result.player1Move = PlayerMovement.Rock;                        
                        result.player2Move = PlayerMovement.Scissors;
                        this.currentScore[0] = this.currentScore[0] + 1;
                    }
                    break;
                }
                case PlayerMovement.Paper: {
                    if (player2Move === PlayerMovement.Scissors) {
                        result.playerWinner = this.players[1];
                        result.player1Move = PlayerMovement.Paper;
                        result.player2Move = PlayerMovement.Scissors;
                        this.currentScore[1] = this.currentScore[1] + 1;
                    }
                    else if (player2Move === PlayerMovement.Rock) {
                        result.playerWinner = this.players[0];
                        result.player1Move = PlayerMovement.Paper;
                        result.player2Move = PlayerMovement.Rock;
                        this.currentScore[0] = this.currentScore[0] + 1;
                    }
                    break;
                }
                case PlayerMovement.Scissors: {
                    if (player2Move === PlayerMovement.Rock) {
                        result.playerWinner = this.players[1];
                        result.player1Move = PlayerMovement.Scissors;
                        result.player2Move = PlayerMovement.Rock;
                        this.currentScore[1] = this.currentScore[1] + 1;
                    }
                    else if (player2Move === PlayerMovement.Paper) {
                        result.playerWinner = this.players[0];
                        result.player1Move = PlayerMovement.Scissors;
                        result.player2Move = PlayerMovement.Paper;
                        this.currentScore[1] = this.currentScore[1] + 1;
                    }
                    break;
                }
                default: {
                    //statements; 
                    break;
                }
            }
        }

        this.results.push(result);
    }

    public restartValues() {
        this.results = [];
        this.currentScore = [0, 0];
    }

    players: string[] = ['unknonw player 1', 'unkonwn player 2'];
    results: Results[] = [];
    currentScore: number[] = [0, 0];    
}