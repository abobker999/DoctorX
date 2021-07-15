using DoctorX.Models;
using DoctorX.Models.Schedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorX.Repository.IRepository
{
	public interface IDoctorOprations
	{
		List<Patient> get(string period);
	}
}
