using System.ComponentModel.DataAnnotations;

namespace WebApiFinal2024II.Dal.Entities
{
    public class Categorias : AuditBase
    {   
        public int Nombre_cat { get; set; }
        public int descripcion { get; set; }
    }
}
