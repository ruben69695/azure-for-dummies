import { Component, OnInit, Output, EventEmitter, HostListener } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { CreateSuperhero } from '../models/create-superhero.model';
import { SuperheroService } from '../services/superhero.service';

@Component({
  selector: 'app-superhero-form',
  templateUrl: './superhero-form.component.html',
  styleUrls: ['./superhero-form.component.css']
})
export class SuperheroFormComponent implements OnInit {
  public formGroup: FormGroup;
  private heroImageFile: File;

  @Output() public heroCreated: EventEmitter<CreateSuperhero>;

  constructor(formBuilder: FormBuilder, private heroService: SuperheroService) {
    this.formGroup = formBuilder.group({
      name: ['', Validators.required],
      description: ['', Validators.nullValidator],
      imageUrl: ['', Validators.required]
    });
    this.heroCreated = new EventEmitter<CreateSuperhero>();
  }

  ngOnInit() {
  }

  public onFileChanged(event) {
    this.heroImageFile = event.target.files[0];
  }

  public createHero(name: string, description: string): boolean {
    var newHero = new CreateSuperhero(0, name, description, this.heroImageFile.name, this.heroImageFile)
    if (this.heroService.saveHero(newHero)) {
      this.heroCreated.emit(newHero);
    }
    return false;
  }
}
