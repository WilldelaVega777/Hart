
//--------------------------------------------------------------------------
// Imports Section
//--------------------------------------------------------------------------
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


//--------------------------------------------------------------------------
// Service Section
//--------------------------------------------------------------------------
@Injectable({
  providedIn: 'root'
})
export class ProductsService
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
  public getTime()
  {

  }
}
