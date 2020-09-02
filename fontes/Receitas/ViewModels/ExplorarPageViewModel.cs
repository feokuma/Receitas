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
    public class ExplorarPageViewModel : BindableBase  
    {
        public ObservableCollection<Categoria> Categorias { get; set; }
        public ExplorarPageViewModel(INavigationService navigationService)
        {
            Categorias = new ObservableCollection<Categoria>
            {
                new Categoria
                {
                    Nome = "Massa",
                    Imagem = "pasta.png"
                },
                new Categoria
                {
                    Nome = "Frutos do Mar",
                    Imagem = "seafood.png"
                },
                new Categoria
                {
                    Nome = "Saladas",
                    Imagem = "salad.png"
                },
                new Categoria
                {
                    Nome = "Ovos",
                    Imagem = "eggs.png"
                }
            };
        }
    }
}
