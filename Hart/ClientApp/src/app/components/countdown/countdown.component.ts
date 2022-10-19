//--------------------------------------------------------------------------
// Imports Section
//--------------------------------------------------------------------------
import { Component }    from '@angular/core';
import { OnInit }       from '@angular/core';
import { Observable }   from 'rxjs';
import { timer }        from 'rxjs';
import { TimerService } from '../../services/timer.service';


//--------------------------------------------------------------------------
// Component Section
//--------------------------------------------------------------------------
@Component({
  selector: 'final-countdown',
  templateUrl: './countdown.component.html'
})
export class CountdownComponent implements OnInit
{
  //------------------------------------------------------------------------
  // Public Fields Section
  //------------------------------------------------------------------------
  public timeLeft: number;
  public timer$: Observable<number>;


  //------------------------------------------------------------------------
  // Private Fields Section
  //------------------------------------------------------------------------
  private source = timer(1000, 2000);
  private timerService: TimerService;


  //------------------------------------------------------------------------
  // Constructor Method Section
  //------------------------------------------------------------------------
  constructor(timerService: TimerService)
  {
    this.timeLeft = 20;
    this.timer$ = new Observable<number>();
    this.timerService = timerService;
  }

  //------------------------------------------------------------------------
  // Lifecycle Eventhandler Methods Section
  //------------------------------------------------------------------------
  ngOnInit()
  {

  }


  //------------------------------------------------------------------------
  // Public Methods Section
  //------------------------------------------------------------------------
  public startTimer()
  {
    const abc = this.source.subscribe(val => {
      console.log(val, '-');

    });
  }
}
