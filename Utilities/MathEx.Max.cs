using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Part of MathEx class: MathEx.Max.
/// </summary>
public static partial class MathEx
{
#region byte
    /// <summary>
    /// Returns maximum of specified <paramref name="values"/>.
    /// </summary>
    public static byte Max(params byte[] values)
    {
		if(values == null) throw new ArgumentNullException("values");
		if(values.Empty()) throw new InvalidOperationException("Maximum of zero values isn't defined");
		
        return values.Max();
    }
#endregion

#region sbyte
    /// <summary>
    /// Returns maximum of specified <paramref name="values"/>.
    /// </summary>
    public static sbyte Max(params sbyte[] values)
    {
		if(values == null) throw new ArgumentNullException("values");
		if(values.Empty()) throw new InvalidOperationException("Maximum of zero values isn't defined");
		
        return values.Max();
    }
#endregion

#region short
    /// <summary>
    /// Returns maximum of specified <paramref name="values"/>.
    /// </summary>
    public static short Max(params short[] values)
    {
		if(values == null) throw new ArgumentNullException("values");
		if(values.Empty()) throw new InvalidOperationException("Maximum of zero values isn't defined");
		
        return values.Max();
    }
#endregion

#region ushort
    /// <summary>
    /// Returns maximum of specified <paramref name="values"/>.
    /// </summary>
    public static ushort Max(params ushort[] values)
    {
		if(values == null) throw new ArgumentNullException("values");
		if(values.Empty()) throw new InvalidOperationException("Maximum of zero values isn't defined");
		
        return values.Max();
    }
#endregion

#region int
    /// <summary>
    /// Returns maximum of specified <paramref name="values"/>.
    /// </summary>
    public static int Max(params int[] values)
    {
		if(values == null) throw new ArgumentNullException("values");
		if(values.Empty()) throw new InvalidOperationException("Maximum of zero values isn't defined");
		
        return values.Max();
    }
#endregion

#region uint
    /// <summary>
    /// Returns maximum of specified <paramref name="values"/>.
    /// </summary>
    public static uint Max(params uint[] values)
    {
		if(values == null) throw new ArgumentNullException("values");
		if(values.Empty()) throw new InvalidOperationException("Maximum of zero values isn't defined");
		
        return values.Max();
    }
#endregion

#region long
    /// <summary>
    /// Returns maximum of specified <paramref name="values"/>.
    /// </summary>
    public static long Max(params long[] values)
    {
		if(values == null) throw new ArgumentNullException("values");
		if(values.Empty()) throw new InvalidOperationException("Maximum of zero values isn't defined");
		
        return values.Max();
    }
#endregion

#region ulong
    /// <summary>
    /// Returns maximum of specified <paramref name="values"/>.
    /// </summary>
    public static ulong Max(params ulong[] values)
    {
		if(values == null) throw new ArgumentNullException("values");
		if(values.Empty()) throw new InvalidOperationException("Maximum of zero values isn't defined");
		
        return values.Max();
    }
#endregion

#region float
    /// <summary>
    /// Returns maximum of specified <paramref name="values"/>.
    /// </summary>
    public static float Max(params float[] values)
    {
		if(values == null) throw new ArgumentNullException("values");
		if(values.Empty()) throw new InvalidOperationException("Maximum of zero values isn't defined");
		
        return values.Max();
    }
#endregion

#region double
    /// <summary>
    /// Returns maximum of specified <paramref name="values"/>.
    /// </summary>
    public static double Max(params double[] values)
    {
		if(values == null) throw new ArgumentNullException("values");
		if(values.Empty()) throw new InvalidOperationException("Maximum of zero values isn't defined");
		
        return values.Max();
    }
#endregion

#region decimal
    /// <summary>
    /// Returns maximum of specified <paramref name="values"/>.
    /// </summary>
    public static decimal Max(params decimal[] values)
    {
		if(values == null) throw new ArgumentNullException("values");
		if(values.Empty()) throw new InvalidOperationException("Maximum of zero values isn't defined");
		
        return values.Max();
    }
#endregion
}