import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PlayerSetupComponent } from './Game/player-setup/player-setup.component';
import { GameTableComponent } from './Game/game-table/game-table.component';
import { StatisticsComponent } from './Game/statistics/statistics.component';


const routes: Routes = [
  { path: "setupPlayer", component: PlayerSetupComponent },
  { path: "gameBoard", component: GameTableComponent },
  { path: "statistics", component: StatisticsComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
