namespace Dgmjr.EntityFrameworkCore;
using static Vogen.Conversions;
using Vogen;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public readonly partial struct Slug(string? Value = default) : IComparable<Slug>, IEquatable<Slug>, IComparable
{
    public Slug()
        : this(NewSlug()) { }

public string Value { get; init; } = Value ?? NewSlug();

public int CompareTo(Slug other)
    => Compare(Value, other.Value, OrdinalIgnoreCase);

public int CompareTo(object obj)
    => obj is Slug other ? CompareTo(other) : 1;

public static string NewSlug()
    => guid.NewGuid().ToString("N").Substring(0, 6).ToLowerInvariant();

public override string ToString()
    => Value;

public bool Equals(Slug other)
    => CompareTo(other) == 0;

public override bool Equals(object? obj)
    => obj is Slug other && Equals(other);

public override int GetHashCode()
    => Value.GetHashCode();

public static bool operator ==(Slug left, Slug right)
    => left.Equals(right);

public static bool operator !=(Slug left, Slug right)
    => !left.Equals(right);

public static bool operator <(Slug left, Slug right)
    => left.CompareTo(right) < 0;

public static bool operator <=(Slug left, Slug right)
    => left.CompareTo(right) <= 0;

public static bool operator >(Slug left, Slug right)
    => left.CompareTo(right) > 0;

public static bool operator >=(Slug left, Slug right)
    => left.CompareTo(right) >= 0;
}

public class SlugEfCoreConverter : ValueConverter<Slug, string>
{
    public SlugEfCoreConverter() : this(null) { }
    public SlugEfCoreConverter(ConverterMappingHints? mappingHints = null)
        : base(v => v.Value, v => v.ToSlug(), mappingHints) { }
}

public class SlugJsonConverter : JsonConverter<Slug>
{
    public override Slug Read(ref Utf8JsonReader reader, type typeToConvert, Jso options)
        => new(reader.GetString());

    public override void Write(Utf8JsonWriter writer, Slug value, Jso options)
        => writer.WriteStringValue(value.Value);
}

public class SlugTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
    where TEntity : class, IIdentifiable<Slug>
{
    public void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedNever();
        builder.Property(e => e.Id).HasConversion(v => v.Value, v => v.ToSlug());
    }
}

public static class SlugExtensions
{
    public static Slug ToSlug(this string value)
        => new(value);

    public static Slug NewSlug()
        => new();
}
