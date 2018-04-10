/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { BoatService } from './boat.service';

describe('BoatService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [BoatService]
    });
  });

  it('should ...', inject([BoatService], (service: BoatService) => {
    expect(service).toBeTruthy();
  }));
});
