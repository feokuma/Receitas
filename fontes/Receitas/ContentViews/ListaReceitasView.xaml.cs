using Receitas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Receitas.ContentViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaReceitasView : ContentView
    {
        public static readonly BindableProperty ListaReceitasProperty = BindableProperty.Create(
            "ListaReceitas",
            typeof(IList<Receita>),
            typeof(ListaReceitasView));

        public IList<Receita> ListaReceitas
        {
            get => (IList<Receita>)GetValue(ListaReceitasProperty);
            set => SetValue(ListaReceitasProperty, value);
        }

        public ListaReceitasView()
        {
            InitializeComponent();
        }
    }
}