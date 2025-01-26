using FitnessClasses.Interfaces;
using FitnessClasses.Models;
using Microsoft.AspNetCore.Mvc;

namespace FitnessClasses.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClassController : ControllerBase
    {
        private readonly IClassService classService;

        public ClassController(IClassService classService)
        {
            this.classService = classService;
        }

        [HttpPost]
        [Route("create")]
        public Class CreateClass(string name, DateTime startDate, DateTime endDate, TimeSpan startTime, int duration, int capacity)
        {
            return classService.CreateClass(name, startDate, endDate, startTime, duration, capacity);
        }

        [HttpGet]
        [Route("all")]
        public List<Class> GetAllClasses()
        {
            return classService.GetAllClasses();
        }
    }
}
