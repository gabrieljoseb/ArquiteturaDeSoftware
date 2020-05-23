using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace SOLID.LSP.Violocao
{
    public class Retangulo
    {
        public virtual double Altura { get; set; }
        public virtual double Largura { get; set; }
        public double Area { get { return Altura * Largura; } }
    }
}
