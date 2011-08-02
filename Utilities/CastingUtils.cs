using System;

/// <summary>
/// Extension methods for safe casting/converting between types.
/// </summary>
public static class CastingUtils
{
    /// <summary>
    /// Try cast <paramref name="obj"/> value to type <typeparamref name="T"/>,
    /// if can't will return default(<typeparamref name="T"/>)
    /// </summary>
    public static T To<T>(this object obj)
    {
        return To(obj, default(T));
    }

    /// <summary>
    /// Try cast <paramref name="obj"/> value to type <typeparamref name="T"/>,
    /// if can't will return <paramref name="defaultValue"/>
    /// </summary>
    public static T To<T>(this object obj, T defaultValue)
    {
        if (obj == null) return defaultValue;
        if (obj is T) return (T)obj;

        Type type = typeof(T);

        return To(obj, defaultValue, type);
    }

    private static T To<T>(object obj, T defaultValue, Type type)
    {
        if (type.IsEnum)
        {
            return Enum.IsDefined(type, obj) ?
                (T)Enum.Parse(type, obj.ToString()) :
                defaultValue;
        }

        try
        {
            return (T)Convert.ChangeType(obj, type);
        }
        catch
        {
            return defaultValue;
        }
    }
}