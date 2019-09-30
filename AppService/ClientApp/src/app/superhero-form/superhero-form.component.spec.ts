import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SuperheroFormComponent } from './superhero-form.component';

describe('SuperheroFormComponent', () => {
  let component: SuperheroFormComponent;
  let fixture: ComponentFixture<SuperheroFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SuperheroFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SuperheroFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
