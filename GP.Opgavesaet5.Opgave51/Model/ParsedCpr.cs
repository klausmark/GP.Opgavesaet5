using System.Runtime.InteropServices;

namespace GP.Opgavesaet5.Opgave51.Model
{
    public class ParsedCpr
    {
        public ParsedCpr(int day, int month, int year, int lastFourDigits)
        {
            Day = day;
            Month = month;
            Year = year;
            LastFourDigits = lastFourDigits;
        }

        public int Day { get; }
        public int Month { get; }
        public int Year { get; }
        public int LastFourDigits { get; }

        public override bool Equals(object obj)
        {
            var parsedCpr = obj as ParsedCpr;
            return parsedCpr != null && Equals(parsedCpr);
        }

        public bool Equals(ParsedCpr parsedCpr)
        {
            if (ReferenceEquals(this, parsedCpr)) return true;
            if (LastFourDigits != parsedCpr.LastFourDigits) return false;
            if (Day != parsedCpr.Day) return false;
            if (Month != parsedCpr.Month) return false;
            if (Year != parsedCpr.Year) return false;
            return false;
        }

        public override int GetHashCode()
        {
            return Day + (Month << 6) + (Year << 11) + (LastFourDigits << 11);
        }
    }
}