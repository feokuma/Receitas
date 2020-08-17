using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Receitas.ViewModels;
using Receitas.Views;
using Xamarin.Forms;

[assembly: ExportFont("fontello.ttf", Alias = "fontello")]
namespace Receitas
{
    public partial class App : PrismApplication
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(TelaPrincipalPage)}?selectedTab={nameof(ExplorarPageView)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<TelaPrincipalPage, TelaPrincipalViewModel>();
            containerRegistry.RegisterForNavigation<ReceitaPageView, ReceitaPageViewModel>();
        }
    }
}
