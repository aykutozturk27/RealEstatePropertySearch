import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ProductListDto } from '../models/productListDto';
import { Observable } from 'rxjs/internal/Observable';
import { environment } from 'src/environments/environment';
import { ProductDto } from '../models/productDto';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

constructor(
  private httpClient: HttpClient
) { }

getProducts(): Observable<ProductListDto>{
  let newPath = environment.apiUrl + "products/getall";
  return this.httpClient.get<ProductListDto>(newPath);
}

getProductByTitle(title:string): Observable<ProductDto>{
  let newPath = environment.apiUrl + "products/getByTitle?title=" + title;
  return this.httpClient.get<ProductDto>(newPath);
}
}
