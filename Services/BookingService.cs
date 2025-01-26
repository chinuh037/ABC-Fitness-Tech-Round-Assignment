using FitnessClasses.Interfaces;
using FitnessClasses.Models;

namespace FitnessClasses.Services
{
    public class BookingService : IBookingService
    {
        private readonly List<Booking> bookings = new();
        private readonly IClassService classService;

        public BookingService(IClassService classService)
        {
            this.classService = classService;
        }

        public Booking CreateBooking(string memberName, string className, DateTime participationDate)
        {
            var classToBook = classService.GetClassByName(className);

            if (classToBook == null)
                throw new Exception("Class not found.");

            if (participationDate < classToBook.StartDate || participationDate > classToBook.EndDate)
                throw new Exception("Participation date is outside the class schedule.");

            int currentBookings = bookings.Count(b => b.ClassName == className && b.ParticipationDate == participationDate);

            if (currentBookings >= classToBook.Capacity)
                throw new Exception("Class capacity exceeded for the selected date.");

            var newBooking = new Booking(memberName, className, participationDate);
            bookings.Add(newBooking);
            return newBooking;
        }

        public List<Booking> SearchBookings(string memberName = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            var result = bookings.AsEnumerable();

            if (!string.IsNullOrEmpty(memberName))
                result = result.Where(b => b.MemberName == memberName);

            if (startDate.HasValue && endDate.HasValue)
                result = result.Where(b => b.ParticipationDate >= startDate && b.ParticipationDate <= endDate);

            return result.ToList();
        }
    }
}
