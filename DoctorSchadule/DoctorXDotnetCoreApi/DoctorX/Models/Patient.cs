using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorX.Models
{
	public class Patient
	{
		[Key]
		public Guid PatientId { get; set; }
		[Required]
		public string PatientName { get; set; }
		public string sessionName { get; set; }
		[Required]
		public DateTime SessionStart { get; set; }
		public DateTime SessionEnd => SessionStart.AddMinutes(30);
		//public TimeSpan SessionTime { get; set; }
		[Required]
		public string  Period { get; set; }
		
		public Doctor Doctor { get; set; }
	}
}
