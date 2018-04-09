import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import 'rxjs/add/operator/map';
@Injectable()
export class ReservationService {
  constructor(private http: Http) { }
  getAll() {
    return this.http.get('https://lmyc-assign2.azurewebsites.net/api/Reservationapi')
    .map((res: Response) => res.json());
  }

  // create(newReservation: Reservation): Promise<Reservation> {
  //   return this.http
  //     .post(this.BASE_URL, JSON.stringify(newReservation), {headers: this.headers})
  //     .toPromise()
  //     .then(res => res.json().data)
  //     .catch(this.handleError);
  // }
}