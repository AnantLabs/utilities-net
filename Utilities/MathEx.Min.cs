using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Part of MathEx class: MathEx.Min.
/// </summary>
public static partial class MathEx
{
#region byte
    /// <summary>
    /// Returns minimum of specified <paramref name="values"/>.
    /// </summary>
    public static byte Min(params byte[] values)
    {
		if(values == null) throw new ArgumentNullException("values");
		if(values.Empty()) throw new InvalidOperationException("Minimum of zero values isn't defined");
		
        return values.Min();
    }
#endregion

#region sbyte
    /// <summary>
    /// Returns minimum of specified <paramref name="values"/>.
    /// </summary>
    public static sbyte Min(params sbyte[] values)
    {
		if(values == null) throw new ArgumentNullException("values");
		if(values.Empty()) throw new InvalidOperationException("Minimum of zero values isn't defined");
		
        return values.Min();
    }
#endregion

#region short
    /// <summary>
    /// Returns minimum of specified <paramref name="values"/>.
    /// </summary>
    public static short Min(params short[] values)
    {
		if(values == null) throw new ArgumentNullException("values");
		if(values.Empty()) throw new InvalidOperationException("Minimum of zero values isn't defined");
		
        return values.Min();
    }
#endregion

#region ushort
    /// <summary>
    /// Returns minimum of specified <paramref name="values"/>.
    /// </summary>
    public static ushort Min(params ushort[] values)
    {
		if(values == null) throw new ArgumentNullException("values");
		if(values.Empty()) throw new InvalidOperationException("Minimum of zero values isn't defined");
		
        return values.Min();
    }
#endregion

#region int
    /// <summary>
    /// Returns minimum of specified <paramref name="values"/>.
    /// </summary>
    public static int Min(params int[] values)
    {
		if(values == null) throw new ArgumentNullException("values");
		if(values.Empty()) throw new InvalidOperationException("Minimum of zero values isn't defined");
		
        return values.Min();
    }
#endregion

#region uint
    /// <summary>
    /// Returns minimum of specified <paramref name="values"/>.
    /// </summary>
    public static uint Min(params uint[] values)
    {
		if(values == null) throw new ArgumentNullException("values");
		if(values.Empty()) throw new InvalidOperationException("Minimum of zero values isn't defined");
		
        return values.Min();
    }
#endregion

#region long
    /// <summary>
    /// Returns minimum of specified <paramref name="values"/>.
    /// </summary>
    public static long Min(params long[] values)
    {
		if(values == null) throw new ArgumentNullException("values");
		if(values.Empty()) throw new InvalidOperationException("Minimum of zero values isn't defined");
		
        return values.Min();
    }
#endregion

#region ulong
    /// <summary>
    /// Returns minimum of specified <paramref name="values"/>.
    /// </summary>
    public static ulong Min(params ulong[] values)
    {
		if(values == null) throw new ArgumentNullException("values");
		if(values.Empty()) throw new InvalidOperationException("Minimum of zero values isn't defined");
		
        return values.Min();
    }
#endregion

#region float
    /// <summary>
    /// Returns minimum of specified <paramref name="values"/>.
    /// </summary>
    public static float Min(params float[] values)
    {
		if(values == null) throw new ArgumentNullException("values");
		if(values.Empty()) throw new InvalidOperationException("Minimum of zero values isn't defined");
		
        return values.Min();
    }
#endregion

#region double
    /// <summary>
    /// Returns minimum of specified <paramref name="values"/>.
    /// </summary>
    public static double Min(params double[] values)
    {
		if(values == null) throw new ArgumentNullException("values");
		if(values.Empty()) throw new InvalidOperationException("Minimum of zero values isn't defined");
		
        return values.Min();
    }
#endregion

#region decimal
    /// <summary>
    /// Returns minimum of specified <paramref name="values"/>.
    /// </summary>
    public static decimal Min(params decimal[] values)
    {
		if(values == null) throw new ArgumentNullException("values");
		if(values.Empty()) throw new InvalidOperationException("Minimum of zero values isn't defined");
		
        return values.Min();
    }
#endregion
}