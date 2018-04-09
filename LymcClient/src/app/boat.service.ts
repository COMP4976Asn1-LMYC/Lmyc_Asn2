import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class BoatService {

  constructor(private http: Http) { }
  getAll() {
    return this.http.get('https://lmyc-assign2.azurewebsites.net/api/Boatapi')
    .map((res: Response) => res.json());
  }

}
