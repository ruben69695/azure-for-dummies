import { Injectable, Inject, Output, EventEmitter } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Superhero } from '../models/superhero.model';
import { CreateSuperhero } from '../models/create-superhero.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SuperheroService {

  @Output() public onHeroCreated: EventEmitter<Superhero> = new EventEmitter();
  public superheroes: Superhero[] = null;

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
  }

  public getHeroes(): Promise<Superhero[]> {
    const url = this.baseUrl + 'api/heroes';
    let promise = new Promise<Superhero[]>((resolve, reject) => {
      this.http
        .get<Superhero[]>(url)
        .toPromise()
        .then(res => {
          this.superheroes = res.map(x => new Superhero(x.id, x.name, x.description, this.baseUrl + x.imageUrl));
          resolve();
        }, error => {
          reject(error);
        })
    });
    return promise;
  }

  public saveHero(hero: CreateSuperhero): Promise<boolean> {
    const createHeroUrl = this.baseUrl + 'api/heroes';
    const newHero = new Superhero(hero.id, hero.name, hero.description, hero.imageUrl);
    let uploadImagePromise: Promise<boolean> = null;
    new Promise<any>((resolve, reject) => {
      this.http
        .post(createHeroUrl, newHero)
        .toPromise()
        .then(res => {
          const uploadHeroImageUrl = 'api/heroes/uploadImage';
          const uploadData = new FormData();
          uploadData.append('file', hero.file, hero.file.name);
          uploadImagePromise = new Promise((resolve, reject) => {
            this.http
              .post(uploadHeroImageUrl, uploadHeroImageUrl)
              .toPromise()
              .then(res => {
                resolve();
                console.log("Imagen subida...");
                this.onHeroCreated.emit(newHero);
                return uploadImagePromise;
              }, error => {
                reject(error);
              })
          })
          resolve();
        }, error => {
          reject(error);
        })
      });
    return uploadImagePromise;
  }
}
