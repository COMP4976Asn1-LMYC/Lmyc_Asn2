import { Component } from '@angular/core';
import { BoatService } from "./boat.service"
import { BoatComponent } from "./boat/boat.component";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [BoatService]
})
export class AppComponent {
  title = 'Angular part!';
}