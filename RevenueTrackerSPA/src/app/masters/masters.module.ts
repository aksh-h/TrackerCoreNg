import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CountryComponent } from './country/country.component';
import { StateComponent } from './state/state.component';
import { MasterRouteModule } from './masters.routes';
import { CurrencyComponent } from './currency/currency.component';
import { MatInputModule } from '@angular/material/input'
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatCell, MatHeaderCell, MatTable, MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';

@NgModule({
  imports: [
    CommonModule,
    MasterRouteModule,
    MatInputModule,
    MatToolbarModule,
    MatTableModule,
    MatPaginatorModule
  ],
  declarations: [
    CountryComponent,
    StateComponent,
    CurrencyComponent
  ]
})
export class MasterModule { }
