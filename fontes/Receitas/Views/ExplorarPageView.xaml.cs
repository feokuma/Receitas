using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Receitas.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExplorarPageView : ContentPage
    {
        private int TabSelecionada = 0;
        private List<Label> TabLabels = new List<Label>();

        public ExplorarPageView()
        {
            InitializeComponent();

            TabLabels.Add(labelTabExplorar);
            TabLabels.Add(labelTabCozinharAgora);
            TabLabels.Add(labelTabFavoritos);
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var label = sender as Label;
            var index = TabLabels.IndexOf(label);

            await ExibirConteúdoTabSelecionada(index);
        }

        private async Task ExibirConteúdoTabSelecionada(int index)
        {
            if (index == TabSelecionada)
                return;

            var styleNormal = (Style)Resources["TabLabelNormalStyle"];
            var styleSelecionado = (Style)Resources["TabLabelSelecionadoStyle"];

            TabLabels[TabSelecionada].Style = styleNormal;
            var tabLabelSelecionada = TabLabels[index];
            _ = await marcadorSeleção.TranslateTo(tabLabelSelecionada.X, 0, 100, Easing.SinInOut);
            tabLabelSelecionada.Style = styleSelecionado;
            TabSelecionada = index;
        }
    }
}