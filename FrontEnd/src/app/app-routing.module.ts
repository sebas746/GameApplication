import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PlayerSetupComponent } from './Game/player-setup/player-setup.component';
import { GameTableComponent } from './Game/game-table/game-table.component';
import { StatisticsComponent } from './Game/statistics/statistics.component';
import { RankingPlayersComponent } from './Game/ranking-players/ranking-players.component';


const routes: Routes = [
  { path: "", component: PlayerSetupComponent },
  { path: "*", component: PlayerSetupComponent },
  { path: "setupPlayer", component: PlayerSetupComponent },
  { path: "gameBoard", component: GameTableComponent },
  { path: "statistics", component: StatisticsComponent },
  { path: "ranking", component: RankingPlayersComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
