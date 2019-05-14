import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css'],
})
export class ProductsComponent {
  public products: Products[];

  constructor(http: HttpClient, @Inject('BASE_API_URL') baseUrl: string) {
    http.get<Products[]>(baseUrl + 'api/v1/products').subscribe(
      result => {
        this.products = result;
      },
      error => console.error(error),
    );
  }
}

interface Products {
  id: [String, Number];
  name: String;
  price: Number;
  image: [String];
}
