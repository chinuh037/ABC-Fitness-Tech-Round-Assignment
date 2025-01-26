using FitnessClasses.Models;

namespace FitnessClasses.Interfaces
{
    public interface IBookingService
    {
        Booking CreateBooking(string memberName, string className, DateTime participationDate);
        List<Booking> SearchBookings(string memberName = null, DateTime? startDate = null, DateTime? endDate = null);
    }
}
