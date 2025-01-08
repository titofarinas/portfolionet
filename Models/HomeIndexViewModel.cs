namespace Portfolio.Models
{
    public class HomeIndexViewModel
    {
        public Persona Persona{ get; set; }
        public IEnumerable<Proyecto> Proyectos { get; set; }
    }
}
