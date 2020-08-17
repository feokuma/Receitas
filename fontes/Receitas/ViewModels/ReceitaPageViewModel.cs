using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace Receitas.ViewModels
{
    public class ReceitaPageViewModel : BindableBase
    {
        public string Título { get; set; } = "Nome da Receita";
    }
}
