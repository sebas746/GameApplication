import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PlayerSetupComponent } from './Game/player-setup/player-setup.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { GameTableComponent } from './Game/game-table/game-table.component';
import { AngularFontAwesomeModule } from 'angular-font-awesome';
import { HeaderComponent } from './header/header.component';
import { StatisticsComponent } from './Game/statistics/statistics.component';

@NgModule({
  declarations: [
    AppComponent,
    PlayerSetupComponent,
    GameTableComponent,
    HeaderComponent,
    StatisticsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    AngularFontAwesomeModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
