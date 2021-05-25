import { Component, Input } from '@angular/core';

@Component({
  selector: "temperature-converter",
  templateUrl: "./temperatureConverter.component.html",
  styleUrls: ["./temperatureConverter.component.scss"],
})
export class TemperatureConverter  {
  c: any;
  f: any;
  ngOnInit() { }

  changed(value: any, type: any) {
    if (value) {
      if (type === 'c') {
        let feh = (value * 9 / 5) + 32;
        this.f = feh.toFixed(1);
      } else {
        let cel = (value - 32) * (5 / 9);
        this.c = cel.toFixed(1);
      }
    } else {
      this.c = null;
      this.f = null;
    }
  }
}
