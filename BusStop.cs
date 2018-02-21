using System;

public class Class1
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
            return string.Format("\nBus: {0} \nArrival: {1}\n", Route, Arrivaldatetime);
        }
    }

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
            return string.Format("Test: {0}", string.Join(",", Results));
        }
    }
}
