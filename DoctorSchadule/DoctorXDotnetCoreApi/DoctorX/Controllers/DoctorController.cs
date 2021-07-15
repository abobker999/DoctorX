using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoctorX.Models.Schedule;
using DoctorX.OprationArea;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace DoctorX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        public IDoSchadule _doSchadule;
        public DoctorController(IDoSchadule doSchadule)
        {
            _doSchadule = doSchadule;
        }
        //this method used to get dat from data basee
        [Route("get")]
        public ActionResult Get()

        {
            // not that data come crose opration areae to do alot of work on it :);

            List<MorningSchedule> morningSchedules = _doSchadule.schedule("Morning");
            return Ok(morningSchedules);
        }
    }
}