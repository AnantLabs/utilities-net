using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Part of MathEx class: MathEx.Abs.
/// </summary>
public static partial class MathEx
{
#region sbyte
    /// <summary>
    /// Returns absolute value of sbyte <paramref name="value"/>.
    /// </summary>
    public static sbyte Abs(sbyte value)
    {
        checked
        {
            return value >= 0 ? value : (sbyte)-value;
        }
    }
#endregion

#region short
    /// <summary>
    /// Returns absolute value of short <paramref name="value"/>.
    /// </summary>
    public static short Abs(short value)
    {
        checked
        {
            return value >= 0 ? value : (short)-value;
        }
    }
#endregion

#region int
    /// <summary>
    /// Returns absolute value of int <paramref name="value"/>.
    /// </summary>
    public static int Abs(int value)
    {
        checked
        {
            return value >= 0 ? value : (int)-value;
        }
    }
#endregion

#region long
    /// <summary>
    /// Returns absolute value of long <paramref name="value"/>.
    /// </summary>
    public static long Abs(long value)
    {
        checked
        {
            return value >= 0 ? value : (long)-value;
        }
    }
#endregion

#region float
    /// <summary>
    /// Returns absolute value of float <paramref name="value"/>.
    /// </summary>
    public static float Abs(float value)
    {
        checked
        {
            return value >= 0 ? value : (float)-value;
        }
    }
#endregion

#region double
    /// <summary>
    /// Returns absolute value of double <paramref name="value"/>.
    /// </summary>
    public static double Abs(double value)
    {
        checked
        {
            return value >= 0 ? value : (double)-value;
        }
    }
#endregion

#region decimal
    /// <summary>
    /// Returns absolute value of decimal <paramref name="value"/>.
    /// </summary>
    public static decimal Abs(decimal value)
    {
        checked
        {
            return value >= 0 ? value : (decimal)-value;
        }
    }
#endregion

#region byte
    /// <summary>
    /// Returns absolute value of byte <paramref name="value"/>.
    /// </summary>
    public static byte Abs(byte value)
    {
		return value;
    }
#endregion

#region ushort
    /// <summary>
    /// Returns absolute value of ushort <paramref name="value"/>.
    /// </summary>
    public static ushort Abs(ushort value)
    {
		return value;
    }
#endregion

#region uint
    /// <summary>
    /// Returns absolute value of uint <paramref name="value"/>.
    /// </summary>
    public static uint Abs(uint value)
    {
		return value;
    }
#endregion

#region ulong
    /// <summary>
    /// Returns absolute value of ulong <paramref name="value"/>.
    /// </summary>
    public static ulong Abs(ulong value)
    {
		return value;
    }
#endregion
}