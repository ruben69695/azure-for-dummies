import { Component, OnInit, Input, Output, HostBinding } from '@angular/core';
import { Superhero } from '../models/superhero.model';

@Component({
  selector: 'app-superhero-card',
  templateUrl: './superhero-card.component.html',
  styleUrls: ['./superhero-card.component.css']
})
export class SuperheroCardComponent implements OnInit {
  
  @HostBinding('attr.class') cssClass: string = "d-flex flex-column hero-card card";
  @Input() public superHero: Superhero;
  
  constructor() { }

  ngOnInit() {
  }

}
