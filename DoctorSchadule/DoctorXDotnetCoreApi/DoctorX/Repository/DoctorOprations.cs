using DoctorX.Models;
using DoctorX.Models.Schedule;
using DoctorX.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorX.Repository
{
	public class DoctorOprations:IDoctorOprations
	{
		public DoctorXDBContext _context { get; }
		public DoctorOprations(DoctorXDBContext context)
		{
			_context = context;

		}
		// get patient data to represent it in schadule
	public List<Patient> get(string period)
		{

			var dictionary = (from data in _context.patients
				  .Where(w => w.SessionStart.Date.Day >= DateTime.Today.Day && w.Period == period)
							  select data)
				.ToList();
			

			return dictionary;
		}

		

		
	}
}
