import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent {

  public eventos: any;

  constructor(private Http: HttpClient) {}

  ngOnInit(): void{
    this.getEventos();
  }




  public getEventos(): void {
    this.Http.get('https://localhost:5001/api/evento').subscribe(
      response => this.eventos = response,
      error => console.log(error))


    this.eventos = [

      {
        Tema: 'Angular',
        Local: 'Itaqua'
      },
      {
        Tema: '.NET5',
        Local: 'Itaquaquecetuba'
      },
      {
        Tema: 'Angular 13',
        Local: 'Ubatuba'
      }
    ];
  }

}
