import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.css'],
})
export class ProductDetailComponent {
  public product: Product[];

  constructor(
    http: HttpClient,
    @Inject('BASE_API_URL') baseUrl: string,
    private router: ActivatedRoute,
  ) {
    http.get<Product[]>(baseUrl + `api/v1/products/${this.getId()}`).subscribe(
      result => {
        this.product = result;
      },
      error => console.error(error),
    );
  }

  private getId() {
    return this.router.snapshot.paramMap.get('id');
  }
}

interface Product {
  id: [String, Number];
  name: String;
  price: [String, Number];
  image: String;
  description: String;
}
