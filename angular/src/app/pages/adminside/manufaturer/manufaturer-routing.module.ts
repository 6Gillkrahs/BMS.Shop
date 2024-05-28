import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ManufaturerComponent } from './manufaturer.component';

const routes: Routes = [{ path: '', component: ManufaturerComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ManufaturerRoutingModule { }
