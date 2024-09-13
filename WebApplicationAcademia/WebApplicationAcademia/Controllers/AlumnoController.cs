using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApplicationAcademia.Data;
using WebApplicationAcademia.Model;

namespace WebApplicationAcademia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlumnoController : ControllerBase
    {
        private DaoAlumno daoAlumno = new DaoAlumno();
        private readonly ILogger<WeatherForecastController> _logger;


        [HttpGet("listarTodos")]
        public List<Alummno> getLista()
        {
            return daoAlumno.getAll();
        }
        [HttpPost("registrar")]
        public Alummno registrarAlumno(Alummno alummno)
        {

            if (alummno != null)
            {
                return daoAlumno.registrarAlumno(alummno);
            }
            return null;

        }
        [HttpPost("{id}/actualizar")]
        public bool actualizarAlumno(int id, Alummno alummno)
        {

            return daoAlumno.actualizarAlummno(id, alummno);
        }


    }
    
}
