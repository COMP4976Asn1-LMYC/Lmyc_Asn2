import { Component } from '@angular/core';
import { BoatService } from "./boat.service"
import { BoatComponent } from "./boat/boat.component";
import { ReservationService } from "./reservation.service";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  //providers: [BoatService],
  providers: [ReservationService]
})
export class AppComponent {
  title = 'Angular part!';
}