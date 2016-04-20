using System;
using GP.Opgavesaet5.Opgave51.ViewModel.ViewModels;

namespace GP.Opgavesaet5.Opgave51.View.Helpers
{
    public class ViewModelLocator
    {
        private readonly Lazy<MainWindowViewModel> _mainWindowViewModel = new Lazy<MainWindowViewModel>();
        public MainWindowViewModel MainWindowViewModel => _mainWindowViewModel.Value;
    }
}
