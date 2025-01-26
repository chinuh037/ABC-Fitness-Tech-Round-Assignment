using FitnessClasses.Models;

namespace FitnessClasses.Interfaces
{
    public interface IClassService
    {
        Class CreateClass(string name, DateTime startDate, DateTime endDate, TimeSpan startTime, int duration, int capacity);
        List<Class> GetAllClasses();
        Class GetClassByName(string name);
    }
}
