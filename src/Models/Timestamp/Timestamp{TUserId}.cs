﻿namespace Dgmjr.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using Dgmjr.EntityFrameworkCore.Abstractions;

/// <summary>
/// <inheritdoc cref="ITimestamp{TUserId}"/>
/// </summary>
public struct Timestamp<TUserId> : ITimestamp<TUserId>
{
    public Timestamp() { }

    public readonly TUserId By
    {
        get => (TUserId)(this as ITimestamp)!.By!;
        set => ((ITimestamp)this).By = value!;
    }

    [DataType(DataType.DateTime)]
    public DateTimeOffset When { get; set; } = DateTimeOffset.UtcNow;
    public IStringDictionary Details { get; set; } = new StringDictionary();
    object? ITimestamp.By
    {
        readonly get => By!;
        set => By = (TUserId)value!;
    }

    public int Version { get; set; }
}
