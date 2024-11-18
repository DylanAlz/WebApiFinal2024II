namespace WebApiFinal2024II.Dal.Entities
{
    public class Libros_Categorias
    {
        public Guid libroId { get; set; }
        public Libros libros { get; set; }



        public Guid categoriaId { get; set; }
        public Categorias categorias { get; set; }
    }
}
