import { SelectionModel } from '@angular/cdk/collections';
import { Component, NgModule, OnInit } from '@angular/core';
import { Actions } from '../../httpservices/Actions.enum';
import { HttpService } from '../../httpservices/httpservice.service';

@Component({
  selector: 'app-country',
  templateUrl: './country.component.html',
  styleUrls: ['./country.component.scss']
})

export class CountryComponent implements OnInit {

  public displayedColumns = ['userId', 'userName'];
  selection = new SelectionModel<string>(true, []);
  dataSource: null;
  actions = Actions;

  constructor(private httpservice: HttpService) { }

  ngOnInit() {
  }

  GetCountries() {
    this.httpservice.GetAll(this.actions.CountryAction).subscribe((res) => {
      console.log(res);
      return res;
    })
  }

}
