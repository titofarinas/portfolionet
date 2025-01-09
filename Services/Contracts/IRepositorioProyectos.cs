using Portfolio.Models;

namespace Portfolio.Services.Contracts
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
}
