import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { HomeTab } from './home-tab.page';

describe('Tab1Page', () => {
  let component: HomeTab;
  let fixture: ComponentFixture<HomeTab>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [HomeTab],
      imports: [IonicModule.forRoot(),
      ]
    }).compileComponents();

    fixture = TestBed.createComponent(HomeTab);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
