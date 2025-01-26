using FitnessClasses.Interfaces;
using FitnessClasses.Models;
using Microsoft.AspNetCore.Mvc;

namespace FitnessClasses.Controllers
{
    [ApiController]
    [Route("api/classes")]
    public class ClassController : ControllerBase
    {
        private readonly IClassService _classService;

        public ClassController(IClassService classService)
        {
            _classService = classService;
        }

        [HttpPost]
        [Route("create")]
        public Class CreateClass(string name, DateTime startDate, DateTime endDate, TimeSpan startTime, int duration, int capacity)
        {
            return _classService.CreateClass(name, startDate, endDate, startTime, duration, capacity);
        }

        [HttpGet]
        [Route("all")]
        public List<Class> GetAllClasses()
        {
            return _classService.GetAllClasses();
        }
    }
}
