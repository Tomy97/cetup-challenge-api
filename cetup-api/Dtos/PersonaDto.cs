namespace cetup_api.Dtos
{
    public class PersonaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Provincia { get; set; }

        public DateTime FechaAlta { get; set; }
    }
}
