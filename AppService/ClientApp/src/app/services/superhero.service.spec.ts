import { TestBed } from '@angular/core/testing';

import { SuperheroService } from './superhero.service';

describe('SuperheroService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: SuperheroService = TestBed.get(SuperheroService);
    expect(service).toBeTruthy();
  });
});
