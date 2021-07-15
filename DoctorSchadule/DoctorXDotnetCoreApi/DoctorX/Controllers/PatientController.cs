using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoctorX.Models;
using DoctorX.Models.Schedule;
using DoctorX.OprationArea;
using DoctorX.Repository;
using DoctorX.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoctorX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        public IPatientOprations _patientOprations;      
        public PatientController(IPatientOprations patientOprations)
        {        
            _patientOprations = patientOprations;          
        }
        //this. method to save used to send data to repository to save it in data base;
        [Route("Create")]
        [HttpPost]
        public bool Create(SessionDetals session)
        {
           
            //not that som bisnis logic missing here  :( contact me 0114404999

            Patient patient = new Patient();
            patient.PatientId = Guid.NewGuid();
            patient.PatientName = session.PatientName;
            patient.sessionName = session.SessionName;           
            patient.Period = "Morning";

            


            _patientOprations.Create(patient);
            return true;
        }
       
    }
}