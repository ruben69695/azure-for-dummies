import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: [ './home.component.css' ]
})
export class HomeComponent {
  showImage(): boolean {
    var element: HTMLElement = document.getElementById('partyImage');
    element.hidden = !element.hidden;
    return false;
  }
}
