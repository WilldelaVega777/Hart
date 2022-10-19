//--------------------------------------------------------------------------
// Imports Section
//--------------------------------------------------------------------------
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IApiTime }   from '../models/ApiTime.model';


//--------------------------------------------------------------------------
// Service Section
//--------------------------------------------------------------------------
@Injectable({
  providedIn: 'root'
})
export class TimerService
{
  //------------------------------------------------------------------------
  // Private Fields Section
  //------------------------------------------------------------------------
  private httpInstance: HttpClient;
  private urlBase: string;


  //------------------------------------------------------------------------
  // Constructor Method Section
  //------------------------------------------------------------------------
  constructor(pHttpClient: HttpClient)
  {
    this.httpInstance = pHttpClient;
    this.urlBase = 'http://localhost:5104/api/';
  }


  //------------------------------------------------------------------------
  // Public Methods Section
  //------------------------------------------------------------------------
  public getTime(): Observable<IApiTime>
  {
    const url: string = `${this.urlBase}time/start`;
    return this.httpInstance.get<IApiTime>(url);
  }
}
