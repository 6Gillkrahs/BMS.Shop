import { Component, OnInit } from '@angular/core';
import { ManufacturerDto } from '@proxy/manufacturers/dtos/models';
import { ManufacturerService } from '@proxy/manufacturers';
import { PagedResultRequestDto } from '@abp/ng.core';

@Component({
  selector: 'app-manufaturer',
  templateUrl: './manufaturer.component.html',
  styleUrl: './manufaturer.component.scss'
})
export class ManufaturerComponent implements OnInit {

  manufacturers : ManufacturerDto[] = [];

  isLoading :  boolean = false;

  input : PagedResultRequestDto

  ngOnInit(): void {
    
  }

  constructor(
    private manufacturerService : ManufacturerService

  ) {
    
  }

  getManufacturers(){
    this.isLoading =true;

    this.input = {
      maxResultCount : this.maxResultCount,
      skipCount : this.skipCount
    }

    this.manufacturerService.getList(this.input).subscribe({
      next: (manufacturer) => {
        this.isLoading =false;
        this.manufacturers = manufacturer.items;
        this.totalItems = manufacturer.totalCount
        // console.log(this.manufacturers)
      }
    })
  }

}
