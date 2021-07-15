using DoctorX.Models.Schedule;
using System.Collections.Generic;

namespace DoctorX.OprationArea
{
	public interface IDoSchadule
	{
		List<MorningSchedule> schedule(string period);
	}
}