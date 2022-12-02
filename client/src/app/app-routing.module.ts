import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateAddEmployeeComponent } from './create-add-employee/create-add-employee.component';
import { HomeComponent } from './home/home.component';
import { ViewAddEmployeeComponent } from './view-add-employee/view-add-employee.component';

const routes: Routes = [
    { path: '', component: HomeComponent},
    { path: 'EmployeeList/:id', component: ViewAddEmployeeComponent},
    { path: 'create', component: CreateAddEmployeeComponent},
    { path: '**', component: HomeComponent, pathMatch: 'full'}
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})

export class AppRoutingModule { }