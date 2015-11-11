using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaSeguridad.BE
{
    public class ResponseBE
    {
        public int Codigo { get; set; }
        public string Mensaje { get; set; }
        public string Error { get; set; }
        public bool Estado { get; set; }
        public string DataExtra { get; set; }
    }
}
