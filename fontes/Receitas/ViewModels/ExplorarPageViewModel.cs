using Prism;
using Prism.Mvvm;
using Prism.Navigation;
using Receitas.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Receitas.ViewModels
{
    public class ExplorarPageViewModel : BindableBase, IActiveAware
    {
        public event EventHandler IsActiveChanged;

        public INavigationService _navigationService { get; }
        public ICommand ConfiguraçãoCommand { get; set; }

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
    }
}
