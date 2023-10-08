/*
 * Schemas.cs
 *
 *   Created: 2022-12-01-05:21:45
 *   Modified: 2022-12-01-05:21:46
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.EntityFrameworkCore.Enums;

[GenerateEnumerationRecordStruct("DbSchemas", "Dgmjr.EntityFrameworkCore")]
public enum SchemasEnum
{
    [Display(Name = "DBO Schema", ShortName = "dbo", Description = "The dbo schema")]
    DboSchema,

    [Display(
        Name = "Information Schema",
        ShortName = "information_schema",
        Description = "The information_schema schema"
    )]
    InformationSchema,

    [Display(Name = "Master Schema", ShortName = "master", Description = "The master schema")]
    MasterSchema,

    [Display(Name = "MSDB Schema", ShortName = "msdb", Description = "The msdb schema")]
    MsdbSchema,

    [Display(Name = "SYS Schema", ShortName = "sys", Description = "The sys schema")]
    SysSchema,

    [Display(Name = "TEMPDB Schema", ShortName = "tempdb", Description = "The tempdb schema")]
    TempDbSchema,

    [Display(Name = "Model Schema", ShortName = "model", Description = "The model schema")]
    ModelSchema,

    [Display(Name = "Identity Schema", ShortName = "id", Description = "The id schema")]
    IdentitySchema,
}
