import { NgModule } from '@angular/core';
import { HttpClientModule } from "@angular/common/http";
import { Routes, RouterModule } from '@angular/router';
import { HomepageComponent } from './homepage/homepage.component';
import { DailyOverviewComponent } from './daily-overview/daily-overview.component';
import { MonthlyOverviewComponent } from './monthly-overview/monthly-overview.component';
import { ProgressComponent } from './progress/progress.component';
import { InfoComponent } from './info/info.component';
import { LoginComponent } from './login/login.component';

const routes: Routes = [
  { path: "", component: HomepageComponent },
  { path: "dagoverzicht", component: DailyOverviewComponent },
  { path: "maandoverzicht", component: MonthlyOverviewComponent },
  { path: "voortgang", component: ProgressComponent },
  { path: "info", component: InfoComponent },
  { path: "login", component: LoginComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule, HttpClientModule],
})
export class AppRoutingModule { }
