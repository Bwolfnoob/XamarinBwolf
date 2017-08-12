using System;
using System.Collections.Generic;
using System.Text;

namespace BwolfXamarin.ViewModels
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public bool Novo { get; set; }
    }
}
