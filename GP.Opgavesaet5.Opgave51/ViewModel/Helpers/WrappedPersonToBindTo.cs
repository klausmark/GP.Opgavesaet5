using System;
using GP.Opgavesaet5.Opgave51.Model;

namespace GP.Opgavesaet5.Opgave51.ViewModel.Helpers
{
    public class WrappedPersonToBindTo
    {
        private readonly Person _person;

        public WrappedPersonToBindTo(Person person)
        {
            _person = person;
        }

        public string FirstName => _person.FirstName;
        public string MiddleName => _person.MiddleName;
        public string LastName => _person.LastName;
        public string FullName => _person.GetName();
        public string Sex => _person.GetSex();
        public byte Age => _person.GetAge();
        public DateTime Birthday => _person.GetBirthday();
    }
}