using System;
using Prism.Commands;
using Prism.Mvvm;

namespace Receitas.ViewModels
{
    public class TelaPrincipalViewModel : BindableBase
    {
        private string _TextoPrincipal = "Texto da tela principal";
        public string TextoPrincipal
        {
            get { return _TextoPrincipal; }
            set { SetProperty(ref _TextoPrincipal, value); }
        }

        private bool _EstáSelecionado;
        public bool EstáSelecionado
        {
            get { return _EstáSelecionado; } 
            set { SetProperty(ref _EstáSelecionado, value); } 
        }

        public DelegateCommand BotãoCommand { get; set; }

        public TelaPrincipalViewModel()
        {
            BotãoCommand = new DelegateCommand(BotãoAcionado)
                .ObservesCanExecute(() => EstáSelecionado);
        }

        private void BotãoAcionado()
        {
            TextoPrincipal = "Botão acionado";
        }
    }
}
