import { Component, OnInit } from '@angular/core';
import { SignalrService } from 'src/app/services/SignalrService';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Player } from 'src/app/Models/player.model';
import { Router } from '@angular/router';
import { GameService } from '../game.service';

@Component({
  selector: 'app-player-setup',
  templateUrl: './player-setup.component.html',
  styleUrls: ['./player-setup.component.css']
})
export class PlayerSetupComponent implements OnInit {
  formulary: FormGroup;
  isSubmitted: boolean = false;
  player: Player;

  constructor(private formBuilder: FormBuilder, 
    private signalR: SignalrService, 
    private router: Router,
    private gameService: GameService) { 

  }

  ngOnInit() {
    this.signalR.initializeSignalRConnection();
    this.createForm();
  }

  get form() { return this.formulary.controls; }

  createForm() {
    this.formulary = this.formBuilder.group({
      username1: ['', Validators.required],
      username2: ['', Validators.required]
    });
  }

  submit() {
    this.isSubmitted = true;
    if (this.formulary.invalid) {
      return;
    }
    
    this.gameService.players = [this.formulary.get('username1').value,  this.formulary.get('username2').value];    
    // this.signalR.broadcastPlayer(this.player);    
    this.router.navigateByUrl("/gameBoard");
  }
}
