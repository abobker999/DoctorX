using DoctorX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorX.Repository.IRepository
{
	public interface IPatientOprations
	{
		string Create(Patient patient);
		//bool Check(Patient patient);
	}
}
