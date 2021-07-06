import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReactiveeditComponent } from './reactiveedit.component';

describe('ReactiveeditComponent', () => {
  let component: ReactiveeditComponent;
  let fixture: ComponentFixture<ReactiveeditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReactiveeditComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ReactiveeditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
