using GP.Opgavesaet5.Opgave51.Model;

namespace GP.Opgavesaet5.Opgave51.ViewModel.Helpers
{
    public static class PersonExtensions
    {
        public static WrappedPersonToBindTo Wrap(this Person person)
        {
            return new WrappedPersonToBindTo(person);
        }
    }
}