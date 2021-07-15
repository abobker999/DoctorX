using DoctorX.Models;
using DoctorX.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorX.Repository
{
	public class PatientOprations:IPatientOprations
	{
		public DoctorXDBContext _context { get; }
		public PatientOprations(DoctorXDBContext context )
		{
			_context = context;
		}
		
		public string Create(Patient patient)
		{				
			bool result = Check(patient);
			if (!result)
			{
				_context.AddRange(patient);
				_context.SaveChanges();
				return "Succsess";
			}
			else
			{
				return "Failed";
			}			
		}
		public bool Check(Patient patient)
		{
		bool result=_context.patients.Any(check => check.SessionStart == patient.SessionStart);
			return result;
		}
	
 	}
}
