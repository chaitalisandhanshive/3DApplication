import { TestBed } from '@angular/core/testing';

import { UserdetailsService } from './userdetails.service';

describe('UserserviceService', () => {
  let service: UserdetailsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(UserdetailsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
