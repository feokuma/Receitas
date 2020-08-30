using MvvmHelpers;
using Prism;
using Prism.Mvvm;
using Prism.Navigation;
using Receitas.Models;
using Receitas.Views;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Receitas.ViewModels
{
    public class ExplorarPageViewModel : BindableBase, IActiveAware, INavigatedAware 
    {
        public string TextoDaLista { get; set; }
        public event EventHandler IsActiveChanged;

        public INavigationService _navigationService { get; }
        public ICommand ConfiguraçãoCommand { get; set; }

        public ObservableCollection<Receita> Receitas { get; set; }

        public ExplorarPageViewModel(INavigationService navigationService)
        {
            ConfiguraçãoCommand = new Command(async () => await Configuração());
            _navigationService = navigationService;
        }

        private async Task Configuração()
        {
            await _navigationService.NavigateAsync($"{nameof(ReceitaPageView)}");
        }

        private bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set { SetProperty(ref _isActive, value, RaiseIsActiveChanged); }
        }


        protected virtual void RaiseIsActiveChanged()
        {
            IsActiveChanged?.Invoke(this, EventArgs.Empty);
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            Receitas = new ObservableCollection<Receita>
            {
                new Receita
                {
                    Nome = "Esfirra Fechada",
                    Descrição = "Esfirra de carne fechada",
                    Imagem = "cooking_book.png"
                },
                new Receita
                {
                    Nome = "Empada de Frango",
                    Descrição = "Empada de frango pequena",
                    Imagem = "cooking_book.png"
                },
                new Receita
                {
                    Nome = "Torta de Palmito",
                    Descrição = "Torta de palmito com alecrim",
                    Imagem = "cooking_book.png"
                }
            };
            RaisePropertyChanged(nameof(Receitas));
            TextoDaLista = "Teste";
        }
    }
}
