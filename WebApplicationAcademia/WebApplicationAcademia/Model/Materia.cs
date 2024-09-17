namespace WebApplicationAcademia.Model
{
    public class Materia
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set;}
        public int    prerequisito { get; set; }
        public int    creditos { get; set;}
        public int    semestre { get; set;}
    }
}
