import { Component, OnInit } from '@angular/core';
import {Boat} from '../boat';
import {BoatService} from '../boat.service';
@Component({
  selector: 'app-boat',
  templateUrl: './boat.component.html',
  styleUrls: ['./boat.component.css']
})
export class BoatComponent implements OnInit {
  results: Array<Boat>;
  constructor(private boatService: BoatService) { }
  ngOnInit() {
    this.boatService.getAll().subscribe(
      data => { this.results = data; },
      error => console.log(error)
    );
  }
}