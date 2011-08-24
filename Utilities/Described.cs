using System;
using System.ComponentModel;

/// <summary>
/// Wrapper around a enum with emproved ToString: it automatically replaces CamelCase with Sentence Case, and if enum value has DescriptionAttribute, its value is returned.<para/>
/// Described &lt;<typeparamref name="T"/>&gt; has implicit conversion operators to <typeparamref name="T"/> and from it.
/// </summary>
/// <typeparam name="T">Enum to be Described</typeparam>
public struct Described<T> where T : struct
{
    private T _value;

    public Described(T value)
    {
        if (!value.GetType().IsEnum)
        {
            throw new ArgumentException("Only enums are supported.", "value");
        }
        _value = value;
    }

    /// <summary>
    /// Returns string representation of the enum value.<para/>
    /// CamelCase is automatically converted to Sentence Case, and if the value has DescriptionAttribute, its value is used.
    /// </summary>
    public override string ToString()
    {
        string name = _value.ToString();
        object[] attr = typeof(T).GetField(name).GetCustomAttributes(typeof(DescriptionAttribute), false);
        return attr.Length == 1 ?
            attr[0].To<DescriptionAttribute>().Description :
            name.ToSentenceCase();
    }

    public static implicit operator Described<T>(T value)
    {
        return new Described<T>(value);
    }

    public static implicit operator T(Described<T> value)
    {
        return value._value;
    }
}