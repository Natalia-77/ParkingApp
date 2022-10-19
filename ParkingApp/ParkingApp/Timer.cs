namespace ParkingApp
{
    internal class Timer
    {
        static readonly Random random = new Random();
        public DateTime Start { get; }
        public DateTime End { get; }
        public DateTime PayedTime { get; }
        public TimeSpan Outstand { get => End - Start; }
        public Timer()
        {
            Start = DateTime.UtcNow;
            End = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, DateTime.UtcNow.Day,
                random.Next(Start.Hour + 1, 24), random.Next(Start.Minute, 60), random.Next(Start.Second, 60));
            PayedTime = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, DateTime.UtcNow.Day,
                random.Next(Start.Hour, 24), random.Next(Start.Minute, 60), random.Next(Start.Second, 60));
        }

        //public DateTime ParkingTime()
        //{


        //}
    }
}
