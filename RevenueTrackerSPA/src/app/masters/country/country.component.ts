import { Component, NgModule, OnInit } from '@angular/core';

@Component({
  selector: 'app-country',
  templateUrl: './country.component.html',
  styleUrls: ['./country.component.scss']
})

export class CountryComponent implements OnInit {

  public displayedColumns = ['userId', 'userName', 'progress', 'color'];

  constructor() { }
  
  ngOnInit() {
  }

}
