using System.Domain;
using System.Net.Mail;
using System.Runtime.InteropServices.ComTypes;

using Dgmjr.EntityFrameworkCore.Constants;

using Byte = Dgmjr.EntityFrameworkCore.DbTypeNames.Byte;

namespace Dgmjr.EntityFrameworkCore.Migrations;

public static class Constants
{
    public const string CreateOrAlterFunctionPattern = """
        CREATE OR ALTER FUNCTION {0}.{1}({2})
        RETURNS {3}
AS
BEGIN
{4}
END
        """;
    public const string CreateOrAlterViewPattern = """
        CREATE OR ALTER VIEW {0}.{ 1}
AS
{ 2}
""";
    public const string CreateOrAlterProcedurePattern = """
        CREATE OR ALTER PROCEDURE {0}.{ 1}
{ 2}
AS
BEGIN
{3}
END
        """;

    public const string Function = "FUNCTION";
public const string Procedure = "PROCEDURE";
public const string View = "VIEW";

public const string DropFunctionIfExistsPattern = "DROP FUNCTION IF EXISTS {0}.{1}";
public const string DropProcedureIfExistsPattern = "DROP PROCEDURE IF EXISTS {0}.{1}";
public const string DropViewIfExistsPattern = "DROP VIEW IF EXISTS {0}.{1}";
public const string DropSomethingIfExistsPattern = "DROP {0} IF EXISTS {1}.{2}";

public static readonly IReadOnlyDictionary<Type, string> ClrTypeToSqlTypeMap = new Dictionary<
    Type,
    string
>
    {
        { typeof(string), NVarCharMax.ShortName },
        { typeof(int), Int.ShortName },
        { typeof(long), BigInt.ShortName },
        { typeof(DateTimeOffset), SqlDateTimeOffset.ShortName },
        { typeof(guid), UniqueIdentifier.ShortName },
        { typeof(bool), Bit.ShortName },
        { typeof(decimal), Float.ShortName },
        { typeof(double), Float.ShortName },
        { typeof(float), Float.ShortName },
        { typeof(byte), Byte.ShortName },
        { typeof(short), TinyInt.ShortName },
        { typeof(byte[]), VarBinaryMax.ShortName },
        { typeof(DateTime), Date.ShortName },
        { typeof(DateTime?), Date.ShortName },
        { typeof(DateTimeOffset?), SqlDateTime2.ShortName },
        { typeof(TimeSpan), Time.ShortName },
        { typeof(TimeSpan?), Time.ShortName },
        { typeof(decimal?), Float.ShortName },
        { typeof(double?), Float.ShortName },
        { typeof(float?), Float.ShortName },
        { typeof(byte?), Byte.ShortName },
        { typeof(short?), TinyInt.ShortName },
        { typeof(int?), Int.ShortName },
        { typeof(long?), BigInt.ShortName },
        { typeof(bool?), Bit.ShortName },
        { typeof(NetTopologySuite.Geometries.Point), Geography.ShortName },
        { typeof(NetTopologySuite.Geometries.LineString), Geography.ShortName },
        { typeof(NetTopologySuite.Geometries.Polygon), Geography.ShortName },
        { typeof(NetTopologySuite.Geometries.MultiPoint), Geography.ShortName },
        { typeof(NetTopologySuite.Geometries.MultiLineString), Geography.ShortName },
        { typeof(NetTopologySuite.Geometries.MultiPolygon), Geography.ShortName },
        { typeof(NetTopologySuite.Geometries.GeometryCollection), Geography.ShortName },
        { typeof(Slug), Format(CharX.DisplayName, 6) },
        { typeof(Uri), NVarCharMax.DisplayName },
        { typeof(uri), NVarCharMax.DisplayName },
        { typeof(urn), NVarCharMax.DisplayName },
        { typeof(url), NVarCharMax.DisplayName },
        { typeof(xri), NVarCharMax.DisplayName },
        { typeof(EmailAddress), Format(NVarCharX.DisplayName, UriMaxLengthConstant.UriMaxLength) },
        { typeof(PhoneNumber), Format(VarCharX.DisplayName, 24) },
        { typeof(EmailAddress?), Format(NVarCharX.DisplayName, UriMaxLengthConstant.UriMaxLength) },
        { typeof(PhoneNumber?), Format(VarCharX.DisplayName, 24) },
    };
}
