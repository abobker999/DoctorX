using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorX.Models
{
	public class Doctor
	{
		public Guid DoctorId { get; set; }
		public string DoctorName { get; set; }
		public ICollection<Patient> patients { get; set; }

	}
}
