using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace Receitas.Models
{
    public class Categoria : BindableBase
    {
        public string Nome { get; set; }
        public string Imagem { get; set; }
    }
}
