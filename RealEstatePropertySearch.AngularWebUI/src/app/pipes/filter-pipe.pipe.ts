import { Pipe, PipeTransform } from '@angular/core';
import { Product } from '../models/product';

@Pipe({
  name: 'filterPipe'
})
export class FilterPipePipe implements PipeTransform {

  transform(value: Product[], filterText: string): Product[] {
    //arama ifadeleri genelde küçük harfe çevrilir
    filterText = filterText ? filterText.toLocaleLowerCase() : ""
    return filterText ? value
    .filter((p:Product)=>p.title.toLocaleLowerCase().indexOf(filterText)!== -1):value;
  }
}