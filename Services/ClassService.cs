using FitnessClasses.Interfaces;
using FitnessClasses.Models;


namespace FitnessClasses.Services
{
    public class ClassService : IClassService
    {
        private readonly List<Class> classes = new();

        public Class CreateClass(string name, DateTime startDate, DateTime endDate, TimeSpan startTime, int duration, int capacity)
        {
            var newClass = new Class(name, startDate, endDate, startTime, duration, capacity);
            classes.Add(newClass);
            return newClass;
        }

        public List<Class> GetAllClasses()
        {
            return classes;
        }

        public Class GetClassByName(string name)
        {
            return classes.FirstOrDefault(c => c.Name == name);
        }
    }
}
