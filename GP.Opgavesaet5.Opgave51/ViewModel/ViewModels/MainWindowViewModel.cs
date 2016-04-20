using System.Collections.ObjectModel;
using GP.Opgavesaet5.Opgave51.Model;
using GP.Opgavesaet5.Opgave51.ViewModel.BaseClasses;
using GP.Opgavesaet5.Opgave51.ViewModel.Helpers;

namespace GP.Opgavesaet5.Opgave51.ViewModel.ViewModels
{
    public class MainWindowViewModel : NotifyBase
    {
        public ObservableCollection<WrappedPersonToBindTo> Persons { get; } = new ObservableCollection<WrappedPersonToBindTo>();

        public MainWindowViewModel()
        {
            Persons.Add(
                new Person("020680-1234")
                {
                    FirstName = "Klaus", MiddleName = "Vestfall", LastName = "Mark"
                }
                .Wrap());
            Persons.Add(
                new Person("Hans", "Nielsen", "Hansen", "151024-3543")
                .Wrap());
        }
    }
}
