using System;

/// <summary>
/// Functional switch class.
/// This one contains non-valuable switch.
/// </summary>
public partial class Switch<T>
{
    private T Object { get; set; }
    private bool WasMatch { get; set; }

    /// <summary>
    /// Create new instance of non-valuable switch.
    /// </summary>
    public Switch(T o)
    {
        Object = o;
        WasMatch = false;
    }

    #region Value switch

    /// <summary>
    /// If switch value equals <paramref name="o"/>, then <paramref name="action"/>(switch value) is performed. Fall-through is optional.
    /// </summary>
    public Switch<T> Case(T o, Action<T> action, bool fallThrough = false)
    {
        return Case(x => Equals(x, o), action, fallThrough);
    }

    /// <summary>
    /// If <paramref name="condition"/>(switch value) returns true, then <paramref name="action"/>(switch value) is performed. Fall-through is optional.
    /// </summary>
    public Switch<T> Case(Func<T, bool> condition, Action<T> action, bool fallThrough = false)
    {
        if (!WasMatch && condition(Object))
        {
            action(Object);
            if (!fallThrough) WasMatch = true;
        }

        return this;
    }

    /// <summary>
    /// If no cases matched, <paramref name="action"/>(switch value) is performed.
    /// </summary>
    public void Default(Action<T> action)
    {
        action(Object);
    }

    #endregion

    #region Type switch

    /// <summary>
    /// If switch value is of type <typeparamref name="TT"/>, then <paramref name="action"/>(switch value) is performed. Fall-through is optional.
    /// </summary>
    public Switch<T> Case<TT>(Action<TT> action, bool fallThrough = false) where TT : class
    {
        return Case(o => true, action, fallThrough);
    }

    /// <summary>
    /// If switch value is of type <typeparamref name="TT"/> and <paramref name="condition"/>(switch value) returns true, then <paramref name="action"/>(switch value) is performed. Fall-through is optional.
    /// </summary>
    public Switch<T> Case<TT>(Func<TT, bool> condition, Action<TT> action, bool fallThrough = false) where TT : class
    {
        TT t = Object as TT;
        if (t != null)
        {
            if (!WasMatch && condition(t))
            {
                action(t);
                if (!fallThrough) WasMatch = true;
            }
        }

        return this;
    }

    #endregion
}

/// <summary>
/// Functional switch class.
/// This one contains valuable switch.
/// </summary>
public class Switch<TSource, TResult>
{
    private TSource Object { get; set; }
    private bool HasValue { get; set; }
    private Func<TSource, TResult> DefaultFunction { get; set; }

    private TResult _value;
    private TResult Value
    {
        get { return _value; }
        set { HasValue = true; _value = value; }
    }

    /// <summary>
    /// Create new instance of non-valuable switch.
    /// If <paramref name="defaultFunction"/> is not specified now, it should be specified later.
    /// </summary>
    public Switch(TSource o, Func<TSource, TResult> defaultFunction = null)
    {
        Object = o;
        DefaultFunction = defaultFunction;
    }

    /// <summary>
    /// Completes this switch execution and returns resulting value.
    /// </summary>
    public TResult End()
    {
        if (HasValue) return Value;
        if (DefaultFunction == null) throw new InvalidOperationException("Value and DefaultFunction are not set.");
        return DefaultFunction(Object);
    }

    #region Value switch

    /// <summary>
    /// If switch value equals <paramref name="t"/>, then switch value is set to <paramref name="function"/>(switch value).
    /// </summary>
    public Switch<TSource, TResult> Case(TSource t, Func<TSource, TResult> function)
    {
        return Case(x => Equals(x, t), function);
    }

    /// <summary>
    /// If <paramref name="condition"/>(switch value) returns true, then switch value is set to <paramref name="function"/>(switch value).
    /// </summary>
    public Switch<TSource, TResult> Case(Func<TSource, bool> condition, Func<TSource, TResult> function)
    {
        if (!HasValue && condition(Object))
        {
            Value = function(Object);
        }

        return this;
    }

    /// <summary>
    /// Sets function, which returns default value for the switch and completes switch execution.
    /// </summary>
    public TResult Default(Func<TSource, TResult> function)
    {
        DefaultFunction = function;
        return End();
    }

    #endregion

    #region Type switch

    /// <summary>
    /// If switch value is of type <typeparamref name="T"/>, then switch value is set to <paramref name="func"/>(switch value).
    /// </summary>
    public Switch<TSource, TResult> Case<T>(Func<T, TResult> func) where T : class
    {
        return Case(o => true, func);
    }

    /// <summary>
    /// If switch value is of type <typeparamref name="T"/> and <paramref name="condition"/>(switch value) returns true, then switch value is set to <paramref name="func"/>(switch value).
    /// </summary>
    public Switch<TSource, TResult> Case<T>(Func<T, bool> condition, Func<T, TResult> func) where T : class
    {
        var t = Object as T;
        if (t != null)
        {
            if (!HasValue && condition(t))
            {
                Value = func(t);
            }
        }

        return this;
    }

    #endregion
}

/// <summary>
/// Factory class for simpler creation of generic switches.
/// </summary>
public static class Switch
{
    #region Factory

    /// <summary>
    /// Create non-valuable switch.
    /// </summary>
    public static Switch<T> Create<T>(T o)
    {
        return new Switch<T>(o);
    }

    /// <summary>
    /// Create valuable switch with default value specified by <paramref name="defaultFunction"/>.
    /// </summary>
    public static Switch<TSource, TResult> Create<TSource, TResult>(TSource o, Func<TSource, TResult> defaultFunction)
    {
        return new Switch<TSource, TResult>(o, defaultFunction);
    }

    /// <summary>
    /// Create valuable switch with <paramref name="defaultValue"/>.
    /// </summary>
    public static Switch<TSource, TResult> Create<TSource, TResult>(TSource o, TResult defaultValue)
    {
        return Create(o, t => defaultValue);
    }

    #endregion
}