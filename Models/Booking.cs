namespace FitnessClasses.Models
{
    public class Booking
    {
        public string MemberName { get; set; }
        public string ClassName { get; set; }
        public DateTime ParticipationDate { get; set; }

        public Booking()
        {

        }

        public Booking(string memberName, string className, DateTime participationDate)
        {
            if (participationDate <= DateTime.Now)
                throw new ArgumentException("Participation date must be in the future.");

            MemberName = memberName;
            ClassName = className;
            ParticipationDate = participationDate;
        }
    }
}
