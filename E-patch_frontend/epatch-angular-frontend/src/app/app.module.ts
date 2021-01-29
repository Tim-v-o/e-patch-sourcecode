import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomepageComponent } from './homepage/homepage.component';
import { DailyOverviewComponent } from './daily-overview/daily-overview.component';
import { MonthlyOverviewComponent } from './monthly-overview/monthly-overview.component';
import { ProgressComponent } from './progress/progress.component';
import { InfoComponent } from './info/info.component';
import { LoginComponent } from './login/login.component';

@NgModule({
  declarations: [
    AppComponent,
    HomepageComponent,
    DailyOverviewComponent,
    MonthlyOverviewComponent,
    ProgressComponent,
    InfoComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
