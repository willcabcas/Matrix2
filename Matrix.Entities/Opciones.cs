using System;
using System.Collections.Generic;

namespace Matrix.Entities
{
    public partial class Opciones
    {
        public int Id { get; set; }
        public int NumeroOperacionesM { get; set; }
        public int NumeroCasoPruebasT { get; set; }
        public int TamanoMatrizN { get; set; }
    }
}
