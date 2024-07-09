namespace cetup_api.Data.Entities
{
    public class Provincia
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }

        public DateTime FechaAlta { get; set; }
        public DateTime FechaModificacion { get; set; }

        public Provincia()
        {
            FechaAlta = DateTime.Now;
            FechaModificacion = DateTime.Now;
        }
    }
}
