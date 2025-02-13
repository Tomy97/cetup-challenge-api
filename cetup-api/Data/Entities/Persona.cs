﻿namespace cetup_api.Data.Entities
{
    public class Persona
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int ProvinciaId { get; set; }
        public string? DNI { get; set; }
        public string? Telefono { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaModificacion { get; set; }

        public Provincia? Provincia { get; set; }
    }
}
