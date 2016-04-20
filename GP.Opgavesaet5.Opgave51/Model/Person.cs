using System;

namespace GP.Opgavesaet5.Opgave51.Model
{
    public class Person
    {
        private readonly ParsedCpr _parsedCpr;

        protected string _firstName;
        protected string _lastName;
        protected string _middleName;
        protected readonly string _CprNo;

        public Person(string cprNo)
        {
            _CprNo = cprNo;
            _parsedCpr = new CprParser(_CprNo).Parse();
        }

        public Person(string firstName, string middleName, string lastName, string cprNo) : this(cprNo)
        {
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }

        public string GetName()
        {
            var fullName = _firstName;
            if (PersonHasMiddleName()) fullName += $" {_middleName}";
            return fullName + $" {_lastName}";
        }

        private bool PersonHasMiddleName()
        {
            return !string.IsNullOrEmpty(_middleName);
        }

        public string GetSex()
        {
            return (_CprNo[_CprNo.Length - 1] - '0') % 2 == 0 ? "mand" : "kvinde";
        }

        public DateTime GetBirthday()
        {
            return new DateTime(_parsedCpr.Year, _parsedCpr.Month, _parsedCpr.Day);
        }

        public byte GetAge()
        {
            var birthday = GetBirthday();
            var years = (byte) (DateTime.Today.Year - birthday.Year);
            if (birthday < DateTime.Today) years--;
            return years;
        }
    }
}
