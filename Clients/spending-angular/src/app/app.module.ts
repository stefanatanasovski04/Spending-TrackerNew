import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { CategoriesModule } from './feature/categories/categories.module';
import { StatisticsModule } from './feature/statistics/statistics.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    CategoriesModule,
    StatisticsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
