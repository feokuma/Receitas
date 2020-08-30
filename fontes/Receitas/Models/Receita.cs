using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Receitas.Models
{
    public class Receita : ObservableObject
    {
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public string Descrição { get; set; }
    }
}
