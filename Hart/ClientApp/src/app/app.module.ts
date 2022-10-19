//--------------------------------------------------------------------------
// Imports Section
//--------------------------------------------------------------------------
import { BrowserModule } from '@angular/platform-browser';
import { NgModule }           from '@angular/core';
import { HttpClientModule }   from '@angular/common/http';

import { AppComponent }       from './components/app/app.component';
import { CountdownComponent } from './components/countdown/countdown.component';

//--------------------------------------------------------------------------
// Module Definition Section
//--------------------------------------------------------------------------
@NgModule({
  declarations: [
    AppComponent,
    CountdownComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
//--------------------------------------------------------------------------
// Module Class Section
//--------------------------------------------------------------------------
export class AppModule { }
