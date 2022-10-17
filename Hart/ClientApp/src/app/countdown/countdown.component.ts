import { Component } from '@angular/core';

@Component({
  selector: 'app-countdown',
  templateUrl: './countdown.component.html'
})
export class CountdownComponent {
  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }
}
