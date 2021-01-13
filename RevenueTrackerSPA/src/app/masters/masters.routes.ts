import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { CountryComponent } from "./country/country.component";
import { CurrencyComponent } from "./currency/currency.component";
import { StateComponent } from "./state/state.component";

const masterRoutes: Routes = [
    { path: 'country', component: CountryComponent, data: { animation: 'country' } },
    { path: 'state', component: StateComponent, data: { animation: 'state' }  },
    { path: 'currency', component: CurrencyComponent, data: { animation: 'currency' }  }
]

@NgModule({
    imports: [
        RouterModule.forChild(masterRoutes)
    ],
    exports: [
        RouterModule
    ]
})

export class MasterRouteModule { };