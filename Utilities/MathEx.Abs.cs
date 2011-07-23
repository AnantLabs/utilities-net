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
    /// Returns absolute value of parameter.
    /// </summary>
    public static sbyte Abs(sbyte value)
    {
        if(value >= 0) return value;
		else if(value < 0) {
			if(value == sbyte.MinValue)
				throw new OverflowException("Can't negate minimum value of type sbyte.");
			else
				return (sbyte)-value;
		}
		throw new InvalidOperationException("This shouldn't happen: !(value >= 0) && !(value < 0).");
    }
#endregion

#region short
    /// <summary>
    /// Returns absolute value of parameter.
    /// </summary>
    public static short Abs(short value)
    {
        if(value >= 0) return value;
		else if(value < 0) {
			if(value == short.MinValue)
				throw new OverflowException("Can't negate minimum value of type short.");
			else
				return (short)-value;
		}
		throw new InvalidOperationException("This shouldn't happen: !(value >= 0) && !(value < 0).");
    }
#endregion

#region int
    /// <summary>
    /// Returns absolute value of parameter.
    /// </summary>
    public static int Abs(int value)
    {
        if(value >= 0) return value;
		else if(value < 0) {
			if(value == int.MinValue)
				throw new OverflowException("Can't negate minimum value of type int.");
			else
				return (int)-value;
		}
		throw new InvalidOperationException("This shouldn't happen: !(value >= 0) && !(value < 0).");
    }
#endregion

#region long
    /// <summary>
    /// Returns absolute value of parameter.
    /// </summary>
    public static long Abs(long value)
    {
        if(value >= 0) return value;
		else if(value < 0) {
			if(value == long.MinValue)
				throw new OverflowException("Can't negate minimum value of type long.");
			else
				return (long)-value;
		}
		throw new InvalidOperationException("This shouldn't happen: !(value >= 0) && !(value < 0).");
    }
#endregion

#region float
    /// <summary>
    /// Returns absolute value of parameter.
    /// </summary>
    public static float Abs(float value)
    {
        if(value >= 0) return value;
		else if(value < 0) {
			if(value == float.MinValue)
				throw new OverflowException("Can't negate minimum value of type float.");
			else
				return (float)-value;
		}
		throw new InvalidOperationException("This shouldn't happen: !(value >= 0) && !(value < 0).");
    }
#endregion

#region double
    /// <summary>
    /// Returns absolute value of parameter.
    /// </summary>
    public static double Abs(double value)
    {
        if(value >= 0) return value;
		else if(value < 0) {
			if(value == double.MinValue)
				throw new OverflowException("Can't negate minimum value of type double.");
			else
				return (double)-value;
		}
		throw new InvalidOperationException("This shouldn't happen: !(value >= 0) && !(value < 0).");
    }
#endregion

#region decimal
    /// <summary>
    /// Returns absolute value of parameter.
    /// </summary>
    public static decimal Abs(decimal value)
    {
        if(value >= 0) return value;
		else if(value < 0) {
			if(value == decimal.MinValue)
				throw new OverflowException("Can't negate minimum value of type decimal.");
			else
				return (decimal)-value;
		}
		throw new InvalidOperationException("This shouldn't happen: !(value >= 0) && !(value < 0).");
    }
#endregion

#region byte
    /// <summary>
    /// Returns absolute value of parameter.
    /// </summary>
    public static byte Abs(byte value)
    {
		return value;
    }
#endregion

#region ushort
    /// <summary>
    /// Returns absolute value of parameter.
    /// </summary>
    public static ushort Abs(ushort value)
    {
		return value;
    }
#endregion

#region uint
    /// <summary>
    /// Returns absolute value of parameter.
    /// </summary>
    public static uint Abs(uint value)
    {
		return value;
    }
#endregion

#region ulong
    /// <summary>
    /// Returns absolute value of parameter.
    /// </summary>
    public static ulong Abs(ulong value)
    {
		return value;
    }
#endregion
}