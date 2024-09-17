using Microsoft.AspNetCore.Mvc;
using WebApplicationAcademia.Model;

namespace WebApplicationAcademia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MateriaController : Controller
    {
        [HttpGet("{id}/")]
        public Materia getMateria(int id)
        {

            return null;
        }
        [HttpGet("listarTodos")]
        public List<Materia> getListaMateria()
        {
            return null;
        }
        [HttpPost("registrar")]
        public void crearMateria(Materia materia)
        {
           
        }
        [HttpPost("{id}/actualizar")]
        public void actualizarMateria(int id, Materia materia)
        {

            
        }

    }
}
