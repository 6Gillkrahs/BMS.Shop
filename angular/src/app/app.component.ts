import { ContainerComponent } from './layouts/container/container.component';
import { LayoutService } from './layout/service/app.layout.service';
import { Component, OnInit } from '@angular/core';
import { ReplaceableComponentsService } from '@abp/ng.core';
import { eIdentityComponents } from '@abp/ng.identity';
import { eThemeBasicComponents } from '@abp/ng.theme.basic';

@Component({
  selector: 'app-root',
  template: `
    <abp-loader-bar></abp-loader-bar>
    <abp-dynamic-layout></abp-dynamic-layout>
    <abp-internet-status></abp-internet-status>
  `,
})
export class AppComponent implements OnInit{

    ngOnInit(): void {
      
    }

  constructor(
    private replaceableComponents: ReplaceableComponentsService , 
    // private messageService: MessageService,
    // private primengConfig: PrimeNGConfig,
     private layoutService: LayoutService
  ) {
    this.replaceableComponents.add({
      component: ContainerComponent,
      key: eThemeBasicComponents.ApplicationLayout,
    });  
    this.replaceableComponents.add({
      component: ContainerComponent,
      key: eThemeBasicComponents.AccountLayout,
    });
  }
}
