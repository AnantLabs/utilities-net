using System;

/// <summary>
/// Common DateTime utility methods.
/// </summary>
public static class DateTimeUtils
{
    /// <summary>
    /// 1970.1.1 - start date for Unix time.
    /// </summary>
    private static readonly DateTime UnixStartDate = new DateTime(1970, 1, 1);

    /// <summary>
    /// Gets UTC offset.
    /// </summary>
    public static double UtcOffset
    {
        get
        {
            return DateTime.Now.Subtract(DateTime.UtcNow).TotalHours;
        }
    }

    /// <summary>
    /// Calculates the age from <paramref name="birthDate"/> until today date.
    /// </summary>
    public static int CalculateAge(this DateTime birthDate)
    {
        return CalculateAge(birthDate, DateTime.Now);
    }

    /// <summary>
    /// Calculates the age from <paramref name="birthDate"/> until <paramref name="referenceDate"/>.
    /// </summary>
    public static int CalculateAge(this DateTime birthDate, DateTime referenceDate)
    {
        if (referenceDate < birthDate) throw new ArgumentException("Reference date cannot be less than birth date.");

        int years = referenceDate.Year - birthDate.Year;
        if (referenceDate.Month < birthDate.Month ||
            (referenceDate.Month == birthDate.Month && referenceDate.Day < birthDate.Day))
        {
            --years;
        }

        return years;
    }

    /// <summary>
    /// Returns the number of days in the month of the <paramref name="date"/>.
    /// </summary>
    public static int DaysInMonth(DateTime date)
    {
        DateTime nextMonth = date.AddMonths(1);
        return new DateTime(nextMonth.Year, nextMonth.Month, 1).AddDays(-1).Day;
    }

    /// <summary>
    /// Converts this DateTime to Unix time (number of [milli]seconds from 1970.1.1).
    /// </summary>
    public static long ToUnixTime(this DateTime dateTime, bool withMilliseconds = false)
    {
        double value = withMilliseconds ?
            (dateTime - UnixStartDate).TotalMilliseconds :
            (dateTime - UnixStartDate).TotalSeconds;
        return (long)Math.Floor(value);
    }

    /// <summary>
    /// Converts Unix time (number of [milli]seconds from 1970.1.1) to DateTime.
    /// </summary>
    public static DateTime FromUnixTime(long unixTime, bool withMilliseconds = false)
    {
        var exception = new Lazy<OverflowException>(() =>
            new OverflowException("Specified unix time represents too long time period."));

        try
        {
            return withMilliseconds ? UnixStartDate.AddMilliseconds(unixTime) : UnixStartDate.AddSeconds(unixTime);
        }
        catch (OverflowException)
        {
            throw exception.Value;
        }
        catch (ArgumentOutOfRangeException)
        {
            throw exception.Value;
        }
    }
}