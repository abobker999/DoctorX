import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BookingAppointmentComponent } from './Components/Patient/booking-appointment/booking-appointment.component';
import { DoctorSchaduleComponent } from './Components/Doctor/doctor-schadule/doctor-schadule.component';

const routes: Routes = [
  {path:"",component:BookingAppointmentComponent},
  // {path:"Schadule",component:DoctorSchaduleComponent},
 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
