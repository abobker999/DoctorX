import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { SessionDetals } from '../Components/Patient/patientInterface/sessionDetale'
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ConserviceService {
  url= 'https://localhost:44383/api/patient/get';
  constructor(private httpClint:HttpClient ){
  }
  todoitem:any
  public getSchadule(){
    alert("i am");
    return this.httpClint.get('https://localhost:44383/api/patient/get');
   }
   Booking(session:SessionDetals):Observable<SessionDetals>{
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json'}) };  
    
  //   return this.httpClint.post<SessionDetals>('https://localhost:44383/api/patient/Create', session, httpOptions ).subscribe(data => {
      
  // });
     return this.httpClint.post<SessionDetals>('https://localhost:44383/api/patient/Create', session ,httpOptions);
   }
}
