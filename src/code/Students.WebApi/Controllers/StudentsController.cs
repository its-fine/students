using Microsoft.AspNetCore.Mvc;

namespace Students.WebApi.Controllers
{
    /// <summary>
    /// API for students.
    /// </summary>
    [Produces("application/json")]
    [Route("api/Students")]
    public class StudentsController : Controller
    {
    }
}