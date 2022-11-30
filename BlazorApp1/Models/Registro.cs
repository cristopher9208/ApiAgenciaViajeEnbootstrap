using System;
using System.Collections.Generic;

namespace BlazorApp1.Models
{
    public partial class Registro
    {
        public int Cedula { get; set; }
        public string Nombre { get; set; } = null!;
        public int Telefono { get; set; }
        public int TelefonoEmergencia { get; set; }
        public string Correo { get; set; } = null!;
        public int Contraseña { get; set; }
    }
}
