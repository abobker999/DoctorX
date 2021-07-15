import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { ConserviceService } from 'src/app/services/conservice.service';
import { SessionDetals } from '../patientInterface/sessionDetale'
  
@Component({
  selector: 'app-booking-appointment',
  templateUrl: './booking-appointment.component.html',
  styleUrls: ['./booking-appointment.component.css']
})
export class BookingAppointmentComponent implements OnInit {
  // ressult of bookink
  public result:any;
  constructor(private con:ConserviceService, private router:Router) { }
  BookingAppointment(SessionForm: NgForm): void { 
    if(SessionForm.value.Name==""||SessionForm.value.Session==""||SessionForm.value.Date=="") {
      alert("all data required");
       this.router.navigate(['']);
    } 
     const SessionDetals=SessionForm.value   
     this.result=this.Book(SessionDetals);
     alert("your Booikng is "+ this.result);
  }
   Book(SessionDetals:SessionDetals){
    this.con.Booking(SessionDetals)
  }
  ngOnInit(): void {
  
      
    
  }

}
