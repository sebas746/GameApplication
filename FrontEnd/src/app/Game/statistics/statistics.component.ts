import { Component, OnInit } from '@angular/core';
import { Statistics } from 'src/app/Models/statistics.model';
import { RestService } from 'src/app/services/RestServices.service';

@Component({
  selector: 'app-statistics',
  templateUrl: './statistics.component.html',
  styleUrls: ['./statistics.component.css']
})
export class StatisticsComponent implements OnInit {

  constructor(private restService: RestService) { }

  get statistics(): Statistics[] {  return this.restService.statistics; }

  ngOnInit() {
  }
  

}
