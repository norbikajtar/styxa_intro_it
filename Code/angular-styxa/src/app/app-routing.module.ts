import { AuthGuard } from './guards/auth.guard';
import { LoginComponent } from './components/login/login.component';
import { ParentComponent } from './components/parent/parent.component';
import { MyFirstComponent } from './components/my-first/my-first.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: 'first', component: MyFirstComponent
  },
  {
    path: 'parent', component: ParentComponent, canActivate: [AuthGuard]
  },
  {
    path: 'login', component: LoginComponent
  },
  {
    path: 'city', loadChildren: () => import('./modules/city/city.module').then(m => m.CityModule)
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
