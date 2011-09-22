using System;
using System.Globalization;

namespace SystemWrapper
{
    public class DateTimeSystem : IDateTimeSystem
    {
        public IDateTimeWrap Today
        {
            get { return new DateTimeWrap(DateTime.Today); }
        }

        public IDateTimeWrap UtcNow
        {
            get { return new DateTimeWrap(DateTime.UtcNow); }
        }

        public IDateTimeWrap Now
        {
            get { return new DateTimeWrap(DateTime.Now); }
        }

        public bool Equals(IDateTimeWrap t1, IDateTimeWrap t2)
        {
            return DateTime.Equals(t1.DateTimeInstance, t2.DateTimeInstance);
        }

        public IDateTimeWrap FromBinary(long dateData)
        {
            return new DateTimeWrap(DateTime.FromBinary(dateData));
        }

        public IDateTimeWrap FromFileTime(long fileTime)
        {
            return new DateTimeWrap(DateTime.FromFileTime(fileTime));
        }

        public IDateTimeWrap FromFileTimeUtc(long fileTime)
        {
            return new DateTimeWrap(DateTime.FromFileTimeUtc(fileTime));
        }

        public IDateTimeWrap FromOADate(double d)
        {
            return new DateTimeWrap(DateTime.FromOADate(d));
        }

        public int Compare(IDateTimeWrap t1, IDateTimeWrap t2)
        {
            return DateTime.Compare(t1.DateTimeInstance, t2.DateTimeInstance);
        }

        public int DaysInMonth(int year, int month)
        {
            return DateTime.DaysInMonth(year, month);
        }

        public bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }

        public IDateTimeWrap Parse(string s)
        {
            return new DateTimeWrap(DateTime.Parse(s));
        }

        public IDateTimeWrap Parse(string s, IFormatProvider provider)
        {
            return new DateTimeWrap(DateTime.Parse(s, provider));
        }

        public IDateTimeWrap Parse(string s, IFormatProvider provider, DateTimeStyles styles)
        {
            return new DateTimeWrap(DateTime.Parse(s, provider, styles));
        }

        public IDateTimeWrap ParseExact(string s, string format, IFormatProvider provider)
        {
            return new DateTimeWrap(DateTime.ParseExact(s, format, provider));
        }

        public IDateTimeWrap ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style)
        {
            return new DateTimeWrap(DateTime.ParseExact(s, format, provider, style));
        }

        public IDateTimeWrap ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style)
        {
            return new DateTimeWrap(DateTime.ParseExact(s, formats, provider, style));
        }

        public IDateTimeWrap SpecifyKind(IDateTimeWrap value, DateTimeKind kind)
        {
            return new DateTimeWrap(DateTime.SpecifyKind(value.DateTimeInstance, kind));
        }

        public bool TryParse(string s, out IDateTimeWrap result)
        {
            DateTime dtResult;
            bool returnValue = DateTime.TryParse(s, out dtResult);
            result = new DateTimeWrap(dtResult);
            return returnValue;
        }

        public bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out IDateTimeWrap result)
        {
            DateTime dtResult;
            bool returnValue = DateTime.TryParse(s, provider, styles, out dtResult);
            result = new DateTimeWrap(dtResult);
            return returnValue;
        }

        public bool TryParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style, out IDateTimeWrap result)
        {
            DateTime dtResult;
            bool returnValue = DateTime.TryParseExact(s, formats, provider, style, out dtResult);
            result = new DateTimeWrap(dtResult);
            return returnValue;
        }

        public bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out IDateTimeWrap result)
        {
            DateTime dtResult;
            bool returnValue = DateTime.TryParseExact(s, format, provider, style, out dtResult);
            result = new DateTimeWrap(dtResult);
            return returnValue;
        }
    }
}