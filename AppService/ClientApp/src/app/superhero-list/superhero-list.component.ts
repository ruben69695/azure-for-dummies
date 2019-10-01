import { Component, OnInit, HostBinding } from '@angular/core';
import { SuperheroService } from '../services/superhero.service';
import { Superhero } from '../models/superhero.model';

@Component({
  selector: 'app-superhero-list',
  templateUrl: './superhero-list.component.html',
  styleUrls: ['./superhero-list.component.css']
})
export class SuperheroListComponent implements OnInit {

  constructor(public heroService: SuperheroService) { 
    heroService.onHeroCreated.subscribe(hero => this.onHeroCreated(hero));
    heroService.getHeroes();
  }

  ngOnInit() {
  }

  private onHeroCreated(hero: Superhero): void {
    this.heroService.getHeroes();
  }

}
