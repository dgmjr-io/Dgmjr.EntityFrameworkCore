namespace Dgmjr.EntityFrameworkCore.Migrations;

public class CreateViewOperation(string schema, string name, string selectStatement) : SqlOperation
{
    public string Schema { get; set; } = schema;
public string Name { get; set; } = name;
public string SelectStatement { get; set; } = selectStatement;

public override string Sql => Format(CreateOrAlterViewPattern, Schema, Name, SelectStatement);
}
