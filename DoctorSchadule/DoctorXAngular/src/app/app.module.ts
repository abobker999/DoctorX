import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms'
import {HttpClientModule} from '@angular/common/http';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BookingAppointmentComponent } from './Components/Patient/booking-appointment/booking-appointment.component';
import { DoctorSchaduleComponent } from './Components/Doctor/doctor-schadule/doctor-schadule.component';
import { ConserviceService } from './services/conservice.service';

@NgModule({
  declarations: [
    AppComponent,
    BookingAppointmentComponent,
    DoctorSchaduleComponent,
    
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule,
    AppRoutingModule
  ],
  providers: [ConserviceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
