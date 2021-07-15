using DoctorX.Models;
using DoctorX.Models.Schedule;
using DoctorX.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorX.OprationArea
{
	//be carful this class contain alot of logic to represent a scadule
	public class DoSchadule:IDoSchadule
	{
		public IDoctorOprations _doctorOpration;
		public DoSchadule(IDoctorOprations doctorOpration)
		{
			_doctorOpration =doctorOpration;
		}


		public List<MorningSchedule> schedule(string period) {	
			//get patient data
		var patient = _doctorOpration.get(period);
			//get session date for all pationt 
			List<string> sessionDates = getSessionDates(patient);
			//get session name not session represent when the patient can meat the doctor
			List<string> sessionNames = getSessionNames(patient);
			//repare the scahdule acording to above Lists
			List<MorningSchedule> initmorningSchedule = initializeMorningSchedule(sessionDates);
			//if you have't a gun dont opent theis method hhhhh; the real schadule :);
			List<MorningSchedule> morningSchedule = lastStepToSetMorningSchedule(patient,initmorningSchedule, sessionNames, sessionDates);

			return morningSchedule;
		}	
		public List<string> getSessionDates(List<Patient> patient)
		{
			List<string> sessionDates = new List<string>();
			foreach (var item in patient)
			{
				if (!sessionDates.Contains(item.SessionStart.Date.ToString()))
				{
					sessionDates.Add(item.SessionStart.Date.ToString());
				}

			}
			return sessionDates;
			
		}
		public List<string> getSessionNames(List<Patient> patient)
		{

			List<string> sessionNames= new List<string>();
			foreach (var item in patient)
			{
				if (!sessionNames.Contains(item.sessionName))
				{
					sessionNames.Add(item.sessionName);
				}

			}
			return sessionNames;
		}
		public List<MorningSchedule> initializeMorningSchedule(List<string> sessionDates)
		{
			List<MorningSchedule> MorningSchedule = new List<MorningSchedule>();
			SessionDetals sessionDetals;
			foreach (var date in sessionDates)
			{
				sessionDetals = new SessionDetals();
				sessionDetals.SessionName = "";sessionDetals.SessionStart = "";sessionDetals.PatientName="";
				MorningSchedule.Add(new MorningSchedule
				{
					Date = date,
					session1 = sessionDetals,
					session2 = sessionDetals,
					session3 = sessionDetals,
					session4 = sessionDetals,
					session5 = sessionDetals,
					session6 = sessionDetals,
					session7 = sessionDetals,
					session8 = sessionDetals,
					session9 = sessionDetals,
					session10 = sessionDetals,
					session11 = sessionDetals,

				});

			}
			return MorningSchedule;
		}
		public List<MorningSchedule> lastStepToSetMorningSchedule(List<Patient> patient,List<MorningSchedule> initmorningSchedule,List<string> sessionNames,List<string> sessionDates)
		{
			foreach (var sessinDate in sessionDates)
			{
				foreach (var sessionName in sessionNames)
				{
					switch (sessionName)
					{
						case "session1":
							SessionDetals sessiondetal = getssionDetails(patient, sessionName,         sessinDate);
							foreach (var item in initmorningSchedule)
							{
								if (item.Date==sessinDate)
								{
									item.session1 = sessiondetal;
								}
							}
						    break;
						case "session2":
							 sessiondetal = getssionDetails(patient, sessionName, sessinDate);
							foreach (var item in initmorningSchedule)
							{
								if (item.Date == sessinDate)
								{
									item.session2 = sessiondetal;
								}
							}
							break;
						case "session3":
							sessiondetal = getssionDetails(patient, sessionName, sessinDate);
							foreach (var item in initmorningSchedule)
							{
								if (item.Date == sessinDate)
								{
									item.session3 = sessiondetal;
								}
							}
							break;
						case "session4":
							sessiondetal = getssionDetails(patient, sessionName, sessinDate);
							foreach (var item in initmorningSchedule)
							{
								if (item.Date == sessinDate)
								{
									item.session4 = sessiondetal;
								}
							}
							break;
						case "session5":
							sessiondetal = getssionDetails(patient, sessionName, sessinDate);
							foreach (var item in initmorningSchedule)
							{
								if (item.Date == sessinDate)
								{
									item.session5 = sessiondetal;
								}
							}
							break;
						case "session6":
							sessiondetal = getssionDetails(patient, sessionName, sessinDate);
							foreach (var item in initmorningSchedule)
							{
								if (item.Date == sessinDate)
								{
									item.session6 = sessiondetal;
								}
							}
							break;
						case "session7":
							sessiondetal = getssionDetails(patient, sessionName, sessinDate);
							foreach (var item in initmorningSchedule)
							{
								if (item.Date == sessinDate)
								{
									item.session7 = sessiondetal;
								}
							}
							break;
						case "session8":
							sessiondetal = getssionDetails(patient, sessionName, sessinDate);
							foreach (var item in initmorningSchedule)
							{
								if (item.Date == sessinDate)
								{
									item.session8 = sessiondetal;
								}
							}
							break;
						case "session9":
							sessiondetal = getssionDetails(patient, sessionName, sessinDate);
							foreach (var item in initmorningSchedule)
							{
								if (item.Date == sessinDate)
								{
									item.session9 = sessiondetal;
								}
							}
							break;
						case "session10":
							sessiondetal = getssionDetails(patient, sessionName, sessinDate);
							foreach (var item in initmorningSchedule)
							{
								if (item.Date == sessinDate)
								{
									item.session10 = sessiondetal;
								}
							}
							break;
						case "session11":
							sessiondetal = getssionDetails(patient, sessionName, sessinDate);
							foreach (var item in initmorningSchedule)
							{
								if (item.Date == sessinDate)
								{
									item.session11 = sessiondetal;
								}
							}
							break;

					}

				}

			}


			return initmorningSchedule;
		}
		public SessionDetals getssionDetails(List<Patient> patient, string sessionName, string sessinDate)
		{
			SessionDetals session;
			session = (from data in patient
					   where data.SessionStart.Date.ToString() == sessinDate & data.sessionName == sessionName
					   select new SessionDetals
					   {
						   SessionName = data.sessionName,
						   PatientName = data.PatientName,
						   SessionStart= data.SessionStart.ToString()

					   }).FirstOrDefault();

			return session;
		}
	}
}
