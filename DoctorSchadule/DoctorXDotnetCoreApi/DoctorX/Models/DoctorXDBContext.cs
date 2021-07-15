using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorX.Models
{
	public class DoctorXDBContext : DbContext
	{
		public DoctorXDBContext(DbContextOptions<DoctorXDBContext> options) : base(options)
		{

		}
		public DbSet<Doctor> doctors { get; set; }
		public DbSet<Patient> patients { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Doctor>();
				
			modelBuilder.Entity<Patient>()
				.HasOne(one=>one.Doctor)
				.WithMany(many=>many.patients)
				;

		}
	}
}
