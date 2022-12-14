import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from './auth/auth.guard';
import { CheckoutComponent } from './Components/checkout/checkout.component';
import { HomeComponent } from './Components/home/home.component';
import { LoginComponent } from './Components/login/login.component';
import { ProductinfoComponent } from './Components/productinfo/productinfo.component';
import { RegisterComponent } from './Components/register/register.component';
import { TrackDetailsComponent } from './Components/track-details/track-details.component';
import { WishlistComponent } from './Components/wishlist/wishlist.component';

const routes: Routes = [
  {path:'',component:HomeComponent},
  {path:'productInfo/:productId',component:ProductinfoComponent},
  {path:'wishlist',  component:WishlistComponent,canActivate:[AuthGuard]},
  {path:'checkout',  component:CheckoutComponent,canActivate:[AuthGuard]},
  {path:'trackDetails',  component:TrackDetailsComponent,canActivate:[AuthGuard]},
  {path:'register',  component:RegisterComponent},
  {path:'login',  component:LoginComponent},
  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
 
  exports: [RouterModule]
})
export class AppRoutingModule { }
