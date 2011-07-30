using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Part of MathEx class: MathEx.Lerp.
/// </summary>
public static partial class MathEx
{
#region float
    /// <summary>
    /// Linear interpolation: <paramref name="left"/> + (<paramref name="right"/> - <paramref name="left"/>) * <paramref name="frac"/>.
    /// </summary>
    public static float Lerp(float left, float right, float frac)
    {
        return left + (right - left) * frac;
    }
#endregion

#region double
    /// <summary>
    /// Linear interpolation: <paramref name="left"/> + (<paramref name="right"/> - <paramref name="left"/>) * <paramref name="frac"/>.
    /// </summary>
    public static double Lerp(double left, double right, double frac)
    {
        return left + (right - left) * frac;
    }
#endregion
}