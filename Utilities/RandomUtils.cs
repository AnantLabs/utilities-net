using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

///<summary>
/// Various methods that use a <see cref="Random"/> class instance for their main functionality.
///</summary>
public static class RandomUtils
{
    [Flags]
    public enum StringOptions
    {
        All = 0,
        Space = 1,
        AlphaUpper = 2,
        AlphaLower = 4,
        Numeric = 8,
        Punctuation = 16,
        Typography = 32,
    }

    private static readonly Random Generator = RandomGenerator();

    /// <summary>
    /// Creates a properly seeded <see cref="Random">Random</see> generator instance.
    /// </summary>
    /// <returns></returns>
    public static Random RandomGenerator()
    {
        byte[] randomBytes = new byte[4];

        using (var rng = new RNGCryptoServiceProvider())
        {
            rng.GetBytes(randomBytes);
        }

        int seed = (randomBytes[0] & 0x7f) << 24 | randomBytes[1] << 16 | randomBytes[2] << 8 | randomBytes[3];

        return new Random(seed);
    }

    #region String Methods

    /// <summary>
    /// Creates the random string using <see cref="RandomUtility.StringOptions" /> AlphaUpper | AlphaLower |  Numeric to the specified length.
    /// </summary>
    /// <returns></returns>
    public static string RandomString(int length)
    {
        return RandomString(length, StringOptions.AlphaLower | StringOptions.AlphaUpper | StringOptions.Numeric);
    }

    /// <summary>
    /// Creates the random string of predefined character types to the specified length
    /// </summary>
    /// <returns></returns>
    public static string RandomString(int length, StringOptions stringOptions)
    {
        StringBuilder sb = new StringBuilder(length);

        Action spc = () => sb.Append(' ');
        Action ucc = () => sb.Append(Convert.ToChar(Convert.ToInt32(Math.Floor(26 * Generator.NextDouble() + 65))));
        Action lcc = () => sb.Append(Convert.ToChar(Convert.ToInt32(Math.Floor(26 * Generator.NextDouble() + 97))));
        Action nmc = () => sb.Append(Convert.ToChar(Convert.ToInt32(Math.Floor(10 * Generator.NextDouble() + 48))));
        Action puc = () => sb.Append(RandomPunctuation());
        Action tyc = () => sb.Append(RandomTypography());

        var actions = new List<Action>();

        if (stringOptions == StringOptions.All)
        {
            actions.Add(spc);
            actions.Add(ucc);
            actions.Add(lcc);
            actions.Add(nmc);
            actions.Add(puc);
            actions.Add(tyc);
        }
        else
        {
            if (stringOptions.HasFlag(StringOptions.Space)) { actions.Add(spc); }
            if (stringOptions.HasFlag(StringOptions.AlphaLower)) { actions.Add(lcc); }
            if (stringOptions.HasFlag(StringOptions.AlphaUpper)) { actions.Add(ucc); }
            if (stringOptions.HasFlag(StringOptions.Numeric)) { actions.Add(nmc); }
            if (stringOptions.HasFlag(StringOptions.Punctuation)) { actions.Add(puc); }
            if (stringOptions.HasFlag(StringOptions.Typography)) { actions.Add(tyc); }
        }

        if (actions.Empty()) throw new ArgumentException("Unknown string options configuration", "stringOptions");

        for (int i = 0; i < length; i++)
        {
            actions[Generator.Next(0, actions.Count)]();
        }

        return sb.ToString();
    }

    private static char RandomPunctuation()
    {
        // ! " ' ( ) , - . / : ; < > ? [ ] { }
        int[] chars = new[] { 0x21, 0x22, 0x27, 0x28, 0x29, 0x2C, 0x2D, 0x2E, 0x2F, 0x3A, 0x3B, 0x3C, 0x3E, 0x3F, 0x5B, 0x5D, 0x7B, 0x7D };
        return Convert.ToChar(chars[Generator.Next(0, chars.Length)]);
    }

    private static char RandomTypography()
    {
        // & @ * \ ^ # ~ _
        int[] chars = new[] { 0x26, 0x40, 0x2A, 0x5C, 0x5E, 0x23, 0x7E, 0x5F };
        return Convert.ToChar(chars[Generator.Next(0, chars.Length)]);
    }

    #endregion

    /// <summary>
    /// Returns a random Integer between the specified inclusive lower and inclusive upper bounds.
    /// </summary>
    /// <param name="inclusiveLower">The inclusive lower.</param>
    /// <param name="inclusiveUpper">The inclusive upper.</param>
    /// <returns></returns>
    public static int RandomInt(int inclusiveLower, int inclusiveUpper)
    {
        ThrowIfLowerGreaterThanUpper(inclusiveLower, inclusiveUpper);

        return Generator.Next(inclusiveLower, inclusiveUpper + 1);
    }

    ///<summary>
    /// Returns a random Double between the specified inclusive lower and inclusive upper bounds.
    ///</summary>
    ///<param name="inclusiveLower"></param>
    ///<param name="inclusiveUpper"></param>
    ///<returns></returns>
    ///<exception cref="ArgumentOutOfRangeException"></exception>
    public static double RandomDouble(double inclusiveLower, double inclusiveUpper)
    {
        ThrowIfLowerGreaterThanUpper(inclusiveLower, inclusiveUpper);

        return (inclusiveUpper - inclusiveLower) * Generator.NextDouble() + inclusiveLower;
    }

    /// <summary>
    /// Returns a random Double between the specified inclusive lower and inclusive upper bounds rounded to the specified precision
    /// </summary>
    /// <param name="inclusiveLower">The inclusive lower.</param>
    /// <param name="inclusiveUpper">The inclusive upper.</param>
    /// <param name="precision">The precision.</param>
    /// <returns></returns>
    public static double RandomDouble(double inclusiveLower, double inclusiveUpper, int precision)
    {
        return Math.Round(RandomDouble(inclusiveLower, inclusiveUpper), precision);
    }

    /// <summary>
    /// Returns a random True or False
    /// </summary>
    /// <returns></returns>
    public static bool RandomBoolean()
    {
        return Generator.Next(0, 1 + 1) == 0;
    }

    /// <summary>
    /// Returns a random DateTime between the specified inclusive lower and inclusive upper bounds.
    /// </summary>
    /// <param name="inclusiveLower">The inclusive lower.</param>
    /// <param name="inclusiveUpper">The inclusive upper.</param>
    /// <returns></returns>
    public static DateTime RandomDateTime(DateTime inclusiveLower, DateTime inclusiveUpper)
    {
        ThrowIfLowerGreaterThanUpper(inclusiveLower, inclusiveUpper);

        long minTicks = inclusiveLower.Ticks;
        long maxTicks = inclusiveUpper.Ticks;
        double rn = (Convert.ToDouble(maxTicks) - Convert.ToDouble(minTicks)) * Generator.NextDouble() + Convert.ToDouble(minTicks);

        return new DateTime(Convert.ToInt64(rn));
    }

    /// <summary>
    /// Returns a random TimeSpan between the specified inclusive lower and inclusive upper bounds.
    /// </summary>
    /// <param name="inclusiveLower">The inclusive lower.</param>
    /// <param name="inclusiveUpper">The inclusive upper.</param>
    /// <returns></returns>
    public static TimeSpan RandomTimeSpan(TimeSpan inclusiveLower, TimeSpan inclusiveUpper)
    {
        ThrowIfLowerGreaterThanUpper(inclusiveLower, inclusiveUpper);

        long minTicks = inclusiveLower.Ticks;
        long maxTicks = inclusiveUpper.Ticks;
        double rn = (Convert.ToDouble(maxTicks) - Convert.ToDouble(minTicks)) * Generator.NextDouble() + Convert.ToDouble(minTicks);

        return new TimeSpan(Convert.ToInt64(rn));
    }

    private static void ThrowIfLowerGreaterThanUpper(IComparable inclusiveLower, IComparable inclusiveUpper)
    {
        if (inclusiveLower.CompareTo(inclusiveUpper) > 0)
        {
            throw new ArgumentException("InclusiveLower must be less than or equal to inclusiveUpper", "inclusiveLower");
        }
    }
}