using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Receitas.ViewModels;
using Receitas.Views;
using Xamarin.Forms;

namespace Receitas
{
    public partial class App : PrismApplication
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(TelaPrincipal)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<TelaPrincipal, TelaPrincipalViewModel>();
        }
    }
}
