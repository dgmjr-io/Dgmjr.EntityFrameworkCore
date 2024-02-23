namespace Dgmjr.EntityFrameworkCore.Migrations;

using Microsoft.EntityFrameworkCore.Migrations.Operations;

public class CreateProcedureOperation(string schema, string name, SqlArgument[] arguments, string body)
    : SqlOperation
{
    public string Schema { get; set; } = schema;
public string Name { get; set; } = name;
public SqlArgument[] Arguments { get; set; } = arguments;
public string Body { get; set; } = body;

public override string Sql =>
    Format(CreateOrAlterProcedurePattern, Schema, Name, Arguments.Join(", "), Body);

public CreateProcedureOperation(
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
                .Select(arg => (SqlArgument)arg)
                .ToArray(),
        body
    )
{ }
}
