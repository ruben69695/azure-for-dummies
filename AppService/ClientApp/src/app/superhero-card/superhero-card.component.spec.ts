import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SuperheroCardComponent } from './superhero-card.component';

describe('SuperheroCardComponent', () => {
  let component: SuperheroCardComponent;
  let fixture: ComponentFixture<SuperheroCardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SuperheroCardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SuperheroCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
