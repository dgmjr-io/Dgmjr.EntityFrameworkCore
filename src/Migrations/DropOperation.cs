namespace Dgmjr.EntityFrameworkCore.Migrations;

public class DropOperation(string thingKind, string schema, string name) : SqlOperation
{
    public string ThingKind { get; set; } = thingKind;
public string Schema { get; set; } = schema;
public string Name { get; set; } = name;
public override bool IsDestructiveChange => true;

public override string Sql => Format(DropSomethingIfExistsPattern, ThingKind, Schema, Name);
}
