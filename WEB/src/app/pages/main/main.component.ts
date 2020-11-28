import { ItemService } from './../../services/item.service';
import { Component, OnInit } from '@angular/core';
import { ItemModel } from '../item/models/item-model';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent implements OnInit {

  itens: ItemModel[];

  constructor(private itemService: ItemService) { }

  ngOnInit(): void {

    this.carregarItens();

  }

  carregarItens(): void {

    this.itemService.buscarTodosItens().subscribe(
      (item: ItemModel[]) => {

        this.itens = item;

      }, error => {

        console.log(error);

      }
    );

  }

  buscarItem(): void {

  }

}
