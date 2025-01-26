namespace FitnessClasses.Models
{
    public class Class
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public int Duration { get; set; }
        public int Capacity { get; set; }


        public Class(string name, DateTime startDate, DateTime endDate, TimeSpan startTime, int duration, int capacity)
        {
            if (capacity < 1)
                throw new ArgumentException("Capacity must be at least 1.");
            if (endDate <= DateTime.Now)
                throw new ArgumentException("End date must be in the future.");

            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            StartTime = startTime;
            Duration = duration;
            Capacity = capacity;
        }
    }
}
