/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { EntregaService } from './entrega.service';

describe('Service: Entrega', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [EntregaService]
    });
  });

  it('should ...', inject([EntregaService], (service: EntregaService) => {
    expect(service).toBeTruthy();
  }));
});
