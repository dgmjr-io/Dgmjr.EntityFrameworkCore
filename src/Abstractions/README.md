---

title: Dgmjr.EntityFrameworkCore.Abstractions
lastmod: 2023-10-10T08:39:22:00.000Z
date: 2023-10-10T08:39:22:00.000Z
license: MIT
slug: Dgmjr.EntityFrameworkCore.Abstractions-readme
version: 0.0.1-Local
authors:
- dgmjr
description: Contains a bunch of "abstractions" for working with EntityFrameworkCore
keywords:
- Dgmjr.EntityFrameworkCore.Abstractions
- dgmjr
- dgmjr-io
type: readme
------------

# DGMJR Entity Framework Core Abstractions

Contains a bunch of "abstractions" for working with EntityFrameworkCore, specifically:

## Interfaces for DbContexts

- [IDbContext](https://github.com/dgmjr-io/EntityFrameworkCore/blob/main/src/Abstractions/IDbContext.cs)
- [IDbSet](https://github.com/dgmjr-io/EntityFrameworkCore/blob/main/src/Abstractions/IDbSet{T}.cs)
- [IHaveADbContext](https://github.com/dgmjr-io/EntityFrameworkCore/blob/main/src/Abstractions/IHaveADbContext.cs)
- [IHaveADbContext{TContext}](https://github.com/dgmjr-io/EntityFrameworkCore/blob/main/src/Abstractions/IHaveADbContext{TContext}.cs)
- [IValidatableDbContext](https://github.com/dgmjr-io/EntityFrameworkCore/blob/main/src/Abstractions/IValidatableDbContext.cs)
- [IValidatableDbContext{TSelf}](https://github.com/dgmjr-io/EntityFrameworkCore/blob/main/src/Abstractions/IValidatableDbContext{TSelf}.cs)

## Interfaces for Entities

- [IEntity](https://github.com/dgmjr-io/EntityFrameworkCore/blob/main/src/Abstractions/IEntity/IEntity.cs)
- [IEntity{TId}](https://github.com/dgmjr-io/EntityFrameworkCore/blob/main/src/Abstractions/IEntity/IEntity{TId}.cs)
- [IEntity{TSelf,TId}](https://github.com/dgmjr-io/EntityFrameworkCore/blob/main/src/Abstractions/IEntity/IEntity{TSelf,TId}.cs)

