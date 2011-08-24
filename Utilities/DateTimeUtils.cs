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

    /// <summary>
    /// Returns friendly relative representation of <paramref name="dateTime"/> (e.g. "yesterday, about 7 hours ago").
    /// Now only english representation supported.
    /// For future dates "somewhere in the future" string is returned.
    /// </summary>
    /// <param name="dateTime">UTC DateTime</param>
    /// <param name="timeZone">TimeZoneInfo which is used to convert specified dateTime and DateTime.UtcNow</param>
    public static string ToFriendlyRelative(this DateTime dateTime, TimeZoneInfo timeZone)
    {
        dateTime = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timeZone);
        var now = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZone);

        if (dateTime > now) return "somewhere in the future";

        var timeSpan = now - dateTime;

        if (timeSpan < TimeSpan.FromSeconds(30)) return "just now";

        string result = "";
        if (timeSpan < TimeSpan.FromMinutes(1.5)) result = ", about a minute ago";
        else if (timeSpan < TimeSpan.FromMinutes(50)) result = ", about " + (timeSpan.Minutes + 0.5).To<int>() + " minutes ago";
        else if (timeSpan < TimeSpan.FromHours(1.5)) result = ", about an hour ago";
        else if (timeSpan < TimeSpan.FromHours(24)) result = ", about " + (timeSpan.Hours + 0.5).To<int>() + " hours ago";

        int days = (now.Date - dateTime.Date).TotalDays.To<int>();

        if (days == 0) return "today" + result;
        if (days == 1) return "yesterday" + result;

        if (days <= 7) return "about " + days + " days ago";
        if (days <= 7 * 4) return "about " + days / 7 + " weeks ago";

        if (days <= 365) return "about " + days / 30 + " months ago";
        return "about " + days / 365 + " years ago";
    }
}