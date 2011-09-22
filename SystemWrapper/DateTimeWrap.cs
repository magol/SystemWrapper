using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace SystemWrapper
{
    /// <summary>
    /// Wrapper for <see cref="System.Version"/> class.
    /// </summary>
    [Serializable]
    public class DateTimeWrap : IDateTimeWrap
	{
		#region Constructors and Initializers

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.DateTimeWrap"/> class. 
		/// </summary>
		public DateTimeWrap()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.DateTimeWrap"/> class. 
		/// </summary>
		public void Initialize()
		{
			DateTimeInstance = new DateTime();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.DateTimeWrap"/> class. 
		/// </summary>
		/// <param name="dateTime">A DateTime object.</param>
		public DateTimeWrap(DateTime dateTime)
		{
			Initialize(dateTime);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SystemWrapper.DateTimeWrap"/> class. 
		/// </summary>
		/// <param name="dateTime">A DateTime object.</param>
		public void Initialize(DateTime dateTime)
		{
			DateTimeInstance = dateTime;
		}

		/// <summary>
		/// Initializes a new instance of the DateTimeWrap class to a specified number of ticks.
		/// </summary>
		/// <param name="ticks">A date and time expressed in 100-nanosecond units. </param>
		public DateTimeWrap(long ticks)
		{
			Initialize(ticks);
		}

		/// <summary>
		/// Initializes a new instance of the DateTimeWrap class to a specified number of ticks.
		/// </summary>
		/// <param name="ticks">A date and time expressed in 100-nanosecond units. </param>
		public void Initialize(long ticks)
		{
			DateTimeInstance = new DateTime(ticks);
		}

		/// <summary>
		/// Initializes a new instance of the DateTimeWrap class to a specified number of ticks and to Coordinated Universal Time (UTC) or local time.
		/// </summary>
		/// <param name="ticks">A date and time expressed in 100-nanosecond units. </param>
		/// <param name="kind">One of the DateTimeKind values that indicates whether ticks specifies a local time, Coordinated Universal Time (UTC), or neither.</param>
		public DateTimeWrap(long ticks, DateTimeKind kind)
		{
			Initialize(ticks, kind);
		}

		/// <summary>
		/// Initializes a new instance of the DateTimeWrap class to a specified number of ticks and to Coordinated Universal Time (UTC) or local time.
		/// </summary>
		/// <param name="ticks">A date and time expressed in 100-nanosecond units. </param>
		/// <param name="kind">One of the DateTimeKind values that indicates whether ticks specifies a local time, Coordinated Universal Time (UTC), or neither.</param>
		public void Initialize(long ticks, DateTimeKind kind)
		{
			DateTimeInstance = new DateTime(ticks, kind);
		}

		/// <summary>
		/// Initializes a new instance of the DateTimeWrap class to the specified year, month, and day.
		/// </summary>
		/// <param name="year">The year (1 through 9999). </param>
		/// <param name="month">The month (1 through 12). </param>
		/// <param name="day">The day (1 through the number of days in month). </param>
		public DateTimeWrap(int year, int month, int day)
		{
			Initialize(year, month, day);
		}

		/// <summary>
		/// Initializes a new instance of the DateTimeWrap class to the specified year, month, and day.
		/// </summary>
		/// <param name="year">The year (1 through 9999). </param>
		/// <param name="month">The month (1 through 12). </param>
		/// <param name="day">The day (1 through the number of days in month). </param>
		public void Initialize(int year, int month, int day)
		{
			DateTimeInstance = new DateTime(year, month, day);
		}

		/// <summary>
		/// Initializes a new instance of the DateTimeWrap class to the specified year, month, and day for the specified calendar.
		/// </summary>
		/// <param name="year">The year (1 through 9999). </param>
		/// <param name="month">The month (1 through 12). </param>
		/// <param name="day">The day (1 through the number of days in month). </param>
		/// <param name="calendar">The Calendar that applies to this DateTimeWrap. </param>
		public DateTimeWrap(int year, int month, int day, Calendar calendar)
		{
			Initialize(year, month, day, calendar);
		}

		/// <summary>
		/// Initializes a new instance of the DateTimeWrap class to the specified year, month, and day for the specified calendar.
		/// </summary>
		/// <param name="year">The year (1 through 9999). </param>
		/// <param name="month">The month (1 through 12). </param>
		/// <param name="day">The day (1 through the number of days in month). </param>
		/// <param name="calendar">The Calendar that applies to this DateTimeWrap. </param>
		public void Initialize(int year, int month, int day, Calendar calendar)
		{
			DateTimeInstance = new DateTime(year, month, day, calendar);
		}

		/// <summary>
		/// Initializes a new instance of the DateTimeWrap class to the specified year, month, day, hour, minute, and second.
		/// </summary>
		/// <param name="year">The year (1 through 9999). </param>
		/// <param name="month">The month (1 through 12). </param>
		/// <param name="day">The day (1 through the number of days in month). </param>
		/// <param name="hour">The hours (0 through 23). </param>
		/// <param name="minute">The minutes (0 through 59). </param>
		/// <param name="second">The seconds (0 through 59). </param>
		public DateTimeWrap(int year, int month, int day, int hour, int minute, int second)
		{
			Initialize(year, month, day, hour, minute, second);
		}

		/// <summary>
		/// Initializes a new instance of the DateTimeWrap class to the specified year, month, day, hour, minute, and second.
		/// </summary>
		/// <param name="year">The year (1 through 9999). </param>
		/// <param name="month">The month (1 through 12). </param>
		/// <param name="day">The day (1 through the number of days in month). </param>
		/// <param name="hour">The hours (0 through 23). </param>
		/// <param name="minute">The minutes (0 through 59). </param>
		/// <param name="second">The seconds (0 through 59). </param>
		public void Initialize(int year, int month, int day, int hour, int minute, int second)
		{
			DateTimeInstance = new DateTime(year, month, day, hour, minute, second);
		}

		/// <summary>
		/// Initializes a new instance of the DateTimeWrap class to the specified year, month, day, hour, minute, second, and Coordinated Universal Time (UTC) or local time.
		/// </summary>
		/// <param name="year">The year (1 through 9999). </param>
		/// <param name="month">The month (1 through 12). </param>
		/// <param name="day">The day (1 through the number of days in month). </param>
		/// <param name="hour">The hours (0 through 23). </param>
		/// <param name="minute">The minutes (0 through 59). </param>
		/// <param name="second">The seconds (0 through 59). </param>
		/// <param name="kind">One of the DateTimeKind values that indicates whether year, month, day, hour, minute and second specify a local time, Coordinated Universal Time (UTC), or neither.</param>
		public DateTimeWrap(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind)
		{
			Initialize(year, month, day, hour, minute, second, kind);
		}

		/// <summary>
		/// Initializes a new instance of the DateTimeWrap class to the specified year, month, day, hour, minute, second, and Coordinated Universal Time (UTC) or local time.
		/// </summary>
		/// <param name="year">The year (1 through 9999). </param>
		/// <param name="month">The month (1 through 12). </param>
		/// <param name="day">The day (1 through the number of days in month). </param>
		/// <param name="hour">The hours (0 through 23). </param>
		/// <param name="minute">The minutes (0 through 59). </param>
		/// <param name="second">The seconds (0 through 59). </param>
		/// <param name="kind">One of the DateTimeKind values that indicates whether year, month, day, hour, minute and second specify a local time, Coordinated Universal Time (UTC), or neither.</param>
		public void Initialize(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind)
		{
			DateTimeInstance = new DateTime(year, month, day, hour, minute, second, kind);
		}

		/// <summary>
		/// Initializes a new instance of the DateTimeWrap class to the specified year, month, day, hour, minute, and second for the specified calendar.
		/// </summary>
		/// <param name="year">The year (1 through 9999). </param>
		/// <param name="month">The month (1 through 12). </param>
		/// <param name="day">The day (1 through the number of days in month). </param>
		/// <param name="hour">The hours (0 through 23). </param>
		/// <param name="minute">The minutes (0 through 59). </param>
		/// <param name="second">The seconds (0 through 59). </param>
		/// <param name="calendar">The Calendar that applies to this DateTimeWrap. </param>
		public DateTimeWrap(int year, int month, int day, int hour, int minute, int second, Calendar calendar)
		{
			Initialize(year, month, day, hour, minute, second, calendar);
		}

		/// <summary>
		/// Initializes a new instance of the DateTimeWrap class to the specified year, month, day, hour, minute, and second for the specified calendar.
		/// </summary>
		/// <param name="year">The year (1 through 9999). </param>
		/// <param name="month">The month (1 through 12). </param>
		/// <param name="day">The day (1 through the number of days in month). </param>
		/// <param name="hour">The hours (0 through 23). </param>
		/// <param name="minute">The minutes (0 through 59). </param>
		/// <param name="second">The seconds (0 through 59). </param>
		/// <param name="calendar">The Calendar that applies to this DateTimeWrap. </param>
		public void Initialize(int year, int month, int day, int hour, int minute, int second, Calendar calendar)
		{
			DateTimeInstance = new DateTime(year, month, day, hour, minute, second, calendar);
		}

		/// <summary>
		/// Initializes a new instance of the DateTimeWrap class to the specified year, month, day, hour, minute, second, and millisecond.
		/// </summary>
		/// <param name="year">The year (1 through 9999). </param>
		/// <param name="month">The month (1 through 12). </param>
		/// <param name="day">The day (1 through the number of days in month). </param>
		/// <param name="hour">The hours (0 through 23). </param>
		/// <param name="minute">The minutes (0 through 59). </param>
		/// <param name="second">The seconds (0 through 59). </param>
		/// <param name="millisecond">The milliseconds (0 through 999). </param>
		public DateTimeWrap(int year, int month, int day, int hour, int minute, int second, int millisecond)
		{
			Initialize(year, month, day, hour, minute, second, millisecond);
		}

		/// <summary>
		/// Initializes a new instance of the DateTimeWrap class to the specified year, month, day, hour, minute, second, and millisecond.
		/// </summary>
		/// <param name="year">The year (1 through 9999). </param>
		/// <param name="month">The month (1 through 12). </param>
		/// <param name="day">The day (1 through the number of days in month). </param>
		/// <param name="hour">The hours (0 through 23). </param>
		/// <param name="minute">The minutes (0 through 59). </param>
		/// <param name="second">The seconds (0 through 59). </param>
		/// <param name="millisecond">The milliseconds (0 through 999). </param>
		public void Initialize(int year, int month, int day, int hour, int minute, int second, int millisecond)
		{
			DateTimeInstance = new DateTime(year, month, day, hour, minute, second, millisecond);
		}

		/// <summary>
		/// Initializes a new instance of the DateTimeWrap class to the specified year, month, day, hour, minute, second, millisecond, and Coordinated Universal Time (UTC) or local time.
		/// </summary>
		/// <param name="year">The year (1 through 9999). </param>
		/// <param name="month">The month (1 through 12). </param>
		/// <param name="day">The day (1 through the number of days in month). </param>
		/// <param name="hour">The hours (0 through 23). </param>
		/// <param name="minute">The minutes (0 through 59). </param>
		/// <param name="second">The seconds (0 through 59). </param>
		/// <param name="millisecond">The milliseconds (0 through 999). </param>
		/// <param name="kind">One of the DateTimeKind values that indicates whether year, month, day, hour, minute, second, and millisecond specify a local time, Coordinated Universal Time (UTC), or neither.</param>
		public DateTimeWrap(int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind)
		{
			Initialize(year, month, day, hour, minute, second, millisecond, kind);
		}

		/// <summary>
		/// Initializes a new instance of the DateTimeWrap class to the specified year, month, day, hour, minute, second, millisecond, and Coordinated Universal Time (UTC) or local time.
		/// </summary>
		/// <param name="year">The year (1 through 9999). </param>
		/// <param name="month">The month (1 through 12). </param>
		/// <param name="day">The day (1 through the number of days in month). </param>
		/// <param name="hour">The hours (0 through 23). </param>
		/// <param name="minute">The minutes (0 through 59). </param>
		/// <param name="second">The seconds (0 through 59). </param>
		/// <param name="millisecond">The milliseconds (0 through 999). </param>
		/// <param name="kind">One of the DateTimeKind values that indicates whether year, month, day, hour, minute, second, and millisecond specify a local time, Coordinated Universal Time (UTC), or neither.</param>
		public void Initialize(int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind)
		{
			DateTimeInstance = new DateTime(year, month, day, hour, minute, second, millisecond, kind);
		}

		/// <summary>
		/// Initializes a new instance of the DateTimeWrap class to the specified year, month, day, hour, minute, second, millisecond for the specified calendar.
		/// </summary>
		/// <param name="year">The year (1 through 9999). </param>
		/// <param name="month">The month (1 through 12). </param>
		/// <param name="day">The day (1 through the number of days in month). </param>
		/// <param name="hour">The hours (0 through 23). </param>
		/// <param name="minute">The minutes (0 through 59). </param>
		/// <param name="second">The seconds (0 through 59). </param>
		/// <param name="millisecond">The milliseconds (0 through 999). </param>
		/// <param name="calendar">The Calendar that applies to this DateTimeWrap.</param>
		public DateTimeWrap(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar)
		{
			Initialize(year, month, day, hour, minute, second, millisecond, calendar);
		}

		/// <summary>
		/// Initializes a new instance of the DateTimeWrap class to the specified year, month, day, hour, minute, second, millisecond for the specified calendar.
		/// </summary>
		/// <param name="year">The year (1 through 9999). </param>
		/// <param name="month">The month (1 through 12). </param>
		/// <param name="day">The day (1 through the number of days in month). </param>
		/// <param name="hour">The hours (0 through 23). </param>
		/// <param name="minute">The minutes (0 through 59). </param>
		/// <param name="second">The seconds (0 through 59). </param>
		/// <param name="millisecond">The milliseconds (0 through 999). </param>
		/// <param name="calendar">The Calendar that applies to this DateTimeWrap.</param>
		public void Initialize(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar)
		{
			DateTimeInstance = new DateTime(year, month, day, hour, minute, second, millisecond, calendar);
		}

		/// <summary>
		/// Initializes a new instance of the DateTimeWrap class to the specified year, month, day, hour, minute, second, millisecond, and Coordinated Universal Time (UTC) or local time for the specified calendar.
		/// </summary>
		/// <param name="year">The year (1 through 9999). </param>
		/// <param name="month">The month (1 through 12). </param>
		/// <param name="day">The day (1 through the number of days in month). </param>
		/// <param name="hour">The hours (0 through 23). </param>
		/// <param name="minute">The minutes (0 through 59). </param>
		/// <param name="second">The seconds (0 through 59). </param>
		/// <param name="millisecond">The milliseconds (0 through 999). </param>
		/// <param name="calendar">The Calendar that applies to this DateTimeWrap.</param>
		/// <param name="kind">One of the DateTimeKind values that indicates whether year, month, day, hour, minute, second, and millisecond specify a local time, Coordinated Universal Time (UTC), or neither.</param>
		public DateTimeWrap(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, DateTimeKind kind)
		{
			Initialize(year, month, day, hour, minute, second, millisecond, calendar, kind);
		}

		/// <summary>
		/// Initializes a new instance of the DateTimeWrap class to the specified year, month, day, hour, minute, second, millisecond, and Coordinated Universal Time (UTC) or local time for the specified calendar.
		/// </summary>
		/// <param name="year">The year (1 through 9999). </param>
		/// <param name="month">The month (1 through 12). </param>
		/// <param name="day">The day (1 through the number of days in month). </param>
		/// <param name="hour">The hours (0 through 23). </param>
		/// <param name="minute">The minutes (0 through 59). </param>
		/// <param name="second">The seconds (0 through 59). </param>
		/// <param name="millisecond">The milliseconds (0 through 999). </param>
		/// <param name="calendar">The Calendar that applies to this DateTimeWrap.</param>
		/// <param name="kind">One of the DateTimeKind values that indicates whether year, month, day, hour, minute, second, and millisecond specify a local time, Coordinated Universal Time (UTC), or neither.</param>
		public void Initialize(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, DateTimeKind kind)
		{
			DateTimeInstance = new DateTime(year, month, day, hour, minute, second, millisecond, calendar, kind);
		}

		#endregion Constructors and Initializers
		
		public IDateTimeWrap Date
        {
            get { return new DateTimeWrap(DateTimeInstance.Date);}
        }

        public DateTime DateTimeInstance { get; private set; }

        public int Day
        {
            get { return DateTimeInstance.Day; }
        }

        public DayOfWeek DayOfWeek
        {
            get { return DateTimeInstance.DayOfWeek; }
        }

        public int DayOfYear
        {
            get { return DateTimeInstance.DayOfYear; }
        }

        public int Hour
        {
            get { return DateTimeInstance.Hour; }
        }

        public DateTimeKind Kind
        {
            get { return DateTimeInstance.Kind; }
        }

        public int Millisecond
        {
            get { return DateTimeInstance.Millisecond; }
        }

        public int Minute
        {
            get { return DateTimeInstance.Minute; }
        }

        public int Month
        {
            get { return DateTimeInstance.Month; }
        }

        public int Second
        {
            get { return DateTimeInstance.Second; }
        }

        public long Ticks
        {
            get { return DateTimeInstance.Ticks; }
        }

        public TimeSpan TimeOfDay
        {
            get { return DateTimeInstance.TimeOfDay; }
        }

        public int Year
        {
            get { return DateTimeInstance.Year; }
        }

        public IDateTimeWrap Add(TimeSpan value)
        {
            return new DateTimeWrap(DateTimeInstance.Add(value));
        }

        public IDateTimeWrap AddDays(double value)
        {
            return new DateTimeWrap(DateTimeInstance.AddDays(value));
        }

        public IDateTimeWrap AddHours(double value)
        {
            return new DateTimeWrap(DateTimeInstance.AddHours(value));
        }

        public IDateTimeWrap AddMilliseconds(double value)
        {
            return new DateTimeWrap(DateTimeInstance.AddMilliseconds(value));
        }

        public IDateTimeWrap AddMinutes(double value)
        {
            return new DateTimeWrap(DateTimeInstance.AddMinutes(value));
        }

        public IDateTimeWrap AddMonths(int months)
        {
            return new DateTimeWrap(DateTimeInstance.AddMonths(months));
        }

        public IDateTimeWrap AddSeconds(double value)
        {
            return new DateTimeWrap(DateTimeInstance.AddSeconds(value));
        }

        public IDateTimeWrap AddTicks(long value)
        {
            return new DateTimeWrap(DateTimeInstance.AddTicks(value));
        }

        public IDateTimeWrap AddYears(int value)
        {
            return new DateTimeWrap(DateTimeInstance.AddYears(value));
        }



        public int CompareTo(IDateTimeWrap value)
        {
            return DateTimeInstance.CompareTo(value.DateTimeInstance);
        }

        public int CompareTo(object value)
        {
            return DateTimeInstance.CompareTo(value);
        }

        public bool Equals(IDateTimeWrap value)
        {
            return DateTimeInstance.Equals(value);
        }

        public override bool Equals(object obj)
        {
            return DateTimeInstance.Equals(obj);
        }

        public string[] GetDateTimeFormats()
        {
            return DateTimeInstance.GetDateTimeFormats();
        }

        public string[] GetDateTimeFormats(char format)
        {
            return DateTimeInstance.GetDateTimeFormats(format);
        }

        public string[] GetDateTimeFormats(IFormatProvider provider)
        {
            return DateTimeInstance.GetDateTimeFormats(provider);
        }

        public string[] GetDateTimeFormats(char format, IFormatProvider provider)
        {
            return DateTimeInstance.GetDateTimeFormats(format, provider);
        }

        public override int GetHashCode()
        {
            return DateTimeInstance.GetHashCode();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            (DateTimeInstance as ISerializable).GetObjectData(info,context);
        }

        public TypeCode GetTypeCode()
        {
            return DateTimeInstance.GetTypeCode();
        }

        public bool IsDaylightSavingTime()
        {
            return DateTimeInstance.IsDaylightSavingTime();
        }

        public TimeSpan Subtract(IDateTimeWrap value)
        {
            return DateTimeInstance.Subtract(value.DateTimeInstance);
        }

        public IDateTimeWrap Subtract(TimeSpan value)
        {
            return new DateTimeWrap(DateTimeInstance.Subtract(value));
        }

        public long ToBinary()
        {
            return DateTimeInstance.ToBinary();
        }

        public long ToFileTime()
        {
            return DateTimeInstance.ToFileTime();
        }

        public long ToFileTimeUtc()
        {
            return DateTimeInstance.ToFileTimeUtc();
        }

        public IDateTimeWrap ToLocalTime()
        {
            return new DateTimeWrap(DateTimeInstance.ToLocalTime());
        }

        public string ToLongDateString()
        {
            return DateTimeInstance.ToLongDateString();
        }

        public string ToLongTimeString()
        {
            return DateTimeInstance.ToLongTimeString();
        }

        public double ToOADate()
        {
            return DateTimeInstance.ToOADate();
        }

        public string ToShortDateString()
        {
            return DateTimeInstance.ToShortDateString();
        }

        public string ToShortTimeString()
        {
            return DateTimeInstance.ToShortTimeString();
        }

        /// <summary>
        /// Converts the value of the current IDateTimeWrap object to its equivalent string representation.
        /// </summary>
        /// <returns>A string representation of the value of the current IDateTimeWrap object.</returns>
        public override string ToString()
        {
            return DateTimeInstance.ToString();
        }

        public string ToString(IFormatProvider provider)
        {
            return DateTimeInstance.ToString(provider);
        }

        public string ToString(string format)
        {
            return DateTimeInstance.ToString(format);
        }

        public string ToString(string format, IFormatProvider provider)
        {
            return DateTimeInstance.ToString(format, provider);
        }

        public IDateTimeWrap ToUniversalTime()
        {
            return new DateTimeWrap(DateTimeInstance.ToUniversalTime());
        }
    }
}