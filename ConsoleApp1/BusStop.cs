using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrishBusStopTracker
{
	public class Result
	{
		public string Arrivaldatetime { get; set; }
		public string Duetime { get; set; }
		public string Departuredatetime { get; set; }
		public string Departureduetime { get; set; }
		public string Scheduledarrivaldatetime { get; set; }
		public string Scheduleddeparturedatetime { get; set; }
		public string Destination { get; set; }
		public string Destinationlocalized { get; set; }
		public string Origin { get; set; }
		public string Originlocalized { get; set; }
		public string Direction { get; set; }
		public string Operator { get; set; }
		public string Additionalinformation { get; set; }
		public string Lowfloorstatus { get; set; }
		public string Route { get; set; }
		public string Sourcetimestamp { get; set; }
		public string Monitored { get; set; }

		public override string ToString()
		{

			// If 'Duetime' string contains 'Due' the returned string removes the minutes addon to display 'Due' instead of 'Due Minutes'
			// Else if 'Duetime' string is equals '1' the string removes an 's' from 'minutes' to display '1 Minute' instead of '1 Minutes'
			if (Duetime.Contains("Due"))
			{
				return string.Format("\nBus: {0} \nArrival: {1} \nEstimated Arrival: {2} \nDestination: {3} \n", Route, Arrivaldatetime, Duetime, Destination);
			}
			else if (Int32.Parse(Duetime) == 1)
			{
				return string.Format("\nBus: {0} \nArrival: {1} \nEstimated Arrival: {2} Minute \nDestination: {3} \n", Route, Arrivaldatetime, Duetime, Destination);
			}

			// If neither statement is true then the Due time is greater then '1' so it dislays 'x Minutes' for due time
			return string.Format("\nBus: {0} \nArrival: {1} \nEstimated Arrival: {2} Minutes \nDestination: {3} \n", Route, Arrivaldatetime, Duetime, Destination);
		}
	}

	// This class contains header information about the JSON data
	public class RootObject
	{
		public string Errorcode { get; set; }
		public string Errormessage { get; set; }
		public int Numberofresults { get; set; }
		public string Stopid { get; set; }
		public string Timestamp { get; set; }
		public List<Result> Results { get; set; }

		public override string ToString()
		{
			// Returns vars from Results class
			return string.Format("{0}", string.Join("", Results));
		}
	}
}