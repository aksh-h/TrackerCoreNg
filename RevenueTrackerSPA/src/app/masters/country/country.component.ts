import { SelectionModel } from '@angular/cdk/collections';
import { Component, NgModule, OnInit } from '@angular/core';
import { Country } from '../../_models/country';
import { Actions } from '../../_service/Actions.enum';
import { ApiService } from '../../_service/api.service';

@Component({
  selector: 'app-country',
  templateUrl: './country.component.html',
  styleUrls: ['./country.component.scss']
})

export class CountryComponent implements OnInit {

  public displayedColumns = ['id', 'name'];
  selection = new SelectionModel<string>(true, []);
  dataSource: null;
  actions = Actions;
  country: Country[];
  constructor(private service: ApiService) { }

  ngOnInit() {
    this.GetCountries();
  }

  GetCountries() {
    this.service.GetAll(this.actions.CountryAction).subscribe((res : Country[]) => {
      this.country = res;
      console.log(this.country);
    }, error => {
      alert(error);
    });
  }
}
