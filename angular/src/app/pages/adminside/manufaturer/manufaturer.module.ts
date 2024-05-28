import { CsTieredMenuModule } from './../../../shared/components/cs-tiered-menu/cs-tiered-menu.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ManufaturerRoutingModule } from './manufaturer-routing.module';
import { ManufaturerComponent } from './manufaturer.component';
import { TableModule } from 'primeng/table';
import { TabViewModule } from 'primeng/tabview';
import { SharedModule } from 'primeng/api';
import { ToolbarModule } from 'primeng/toolbar';
import { ButtonModule } from 'primeng/button';
import { BreadcrumbModule } from 'primeng/breadcrumb';
import { DialogModule } from 'primeng/dialog';
import { FloatLabelModule } from 'primeng/floatlabel';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ToastModule } from 'primeng/toast';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { ToggleButtonModule } from 'primeng/togglebutton';


@NgModule({
  declarations: [
    ManufaturerComponent
  ],
  imports: [
    CommonModule,
    ManufaturerRoutingModule,
    TabViewModule,
    TableModule,
    CsTieredMenuModule,
    ToolbarModule,
    ButtonModule,
    BreadcrumbModule,
    DialogModule,
    FormsModule,
    ReactiveFormsModule,
    FloatLabelModule,
    ToastModule,
    ConfirmDialogModule,
    ToggleButtonModule
  ]
})
export class ManufaturerModule { }
