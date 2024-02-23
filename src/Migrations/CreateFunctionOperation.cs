namespace Dgmjr.EntityFrameworkCore.Migrations;

using Microsoft.EntityFrameworkCore.Migrations.Operations;

public class CreateFunctionOperation(string schema, string name, SqlArgument[] arguments, string returnType, string body)
    : SqlOperation
{
    public string Schema { get; set; } = schema;
public string Name { get; set; } = name;
public SqlArgument[] Arguments { get; set; } = arguments;
public string Body { get; set; } = body;
public string ReturnType { get; set; } = returnType;

public override string Sql =>
    Format(CreateOrAlterFunctionPattern, Schema, Name, Arguments.Join(", "), ReturnType, Body);

public CreateFunctionOperation(
    MethodInfo mi,
    string body,
    string schema = DboSchema.ShortName,
    string? name = default,
    SqlArgument[]? arguments = default
)
    : this(
        schema,
        name ?? mi.Name,
        arguments
            ?? mi.GetParameters()
                // .Select(p => $"@{p.Name} {ClrTypeToSqlTypeMap[p.ParameterType]}").ToArray(),
                .Select(arg => (SqlArgument)arg)
                .ToArray(),
        ClrTypeToSqlTypeMap[mi.ReturnType],
        body
    )
{ }
}
