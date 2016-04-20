using System;
using System.Text.RegularExpressions;

namespace GP.Opgavesaet5.Opgave51.Model
{
    public class CprParser
    {
        private readonly string _cpr;
        private Match _match;
        private int _day;
        private int _month;
        private int _year;
        private int _lastFourDigits;
        private ParsedCpr _parsedCpr;

        public CprParser(string cpr)
        {
            if (cpr == null) throw new ArgumentNullException(nameof(cpr));
            _cpr = cpr;
        }

        public ParsedCpr Parse()
        {
            DoRegexMatch();
            PopulateParsedCpr();
            return _parsedCpr;
        }

        private void DoRegexMatch()
        {
            _match = Regex.Match(_cpr, @"(0[1-9]|[1-2][0-9]|3[01])(0[1-9]|1[012])(\d{2})-(\d{4})");
            if (!_match.Success) throw new Exception("Comming up");

            _day = int.Parse(_match.Groups[0].Value);
            _month = int.Parse(_match.Groups[1].Value);
            _year = int.Parse(_match.Groups[2].Value);
            _lastFourDigits = int.Parse(_match.Groups[3].Value);

            MakeYearFourDigit();
            VerifyNumberOfDays();
        }

        private void MakeYearFourDigit()
        {
            _year = _year + 2000 > DateTime.Now.Year ? _year + 1900 : _year + 2000;
        }

        private void VerifyNumberOfDays()
        {
            if (_day > DateTime.DaysInMonth(_year, _month)) throw new Exception("yes yes");
        }

        private void PopulateParsedCpr()
        {
            _parsedCpr = new ParsedCpr(_day, _month, _year, _lastFourDigits);
        }
    }
}