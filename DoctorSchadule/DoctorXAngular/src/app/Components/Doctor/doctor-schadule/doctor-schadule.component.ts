import { Component, OnInit } from '@angular/core';
import { ConserviceService } from 'src/app/services/conservice.service';

interface schadule {
  date:string
  session1:session[]
  session2:session[]
  session3:session[]
  session4:session[]
  session5:session[]
  session6:session[]
  session7:session[]
  session8:session[]
  session9:session[]
  session10:session[]
  session11:session[]
  }

   interface session {
      patientName: string
      sessionName: string
      sessionStart:string
      }
      


@Component({
  selector: 'app-doctor-schadule',
  templateUrl: './doctor-schadule.component.html',
  styleUrls: ['./doctor-schadule.component.css']
})
export class DoctorSchaduleComponent implements OnInit {

  constructor(private con:ConserviceService) { }
  public schadule:any=[];
  ngOnInit(): void {
    this.con.getSchadule().toPromise().then((data) => {      
        this.schadule=(data as schadule)
       console.log(this.schadule);
   });
  }

}
