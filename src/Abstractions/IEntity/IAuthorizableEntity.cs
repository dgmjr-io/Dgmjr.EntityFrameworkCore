/*
 * IAuthorizableEntity.cs
 *
 *   Created: 2023-01-03-12:29:17
 *   Modified: 2023-01-03-12:29:17
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.EntityFrameworkCore.Abstractions;

using System.Security.Claims;

/// <summary>
/// An interface that represents an entity that requires authorization to perform operations on it.
/// </summary>
public interface IAuthorizableEntity : IEntity
{
    /// <summary>
    /// Checks if the specified principal has permission perform <paramref name="operation"/> on the entity.
    /// </summary>
    /// <param name="principal">Claims principal that represents the user.</param>
    /// <param name="operation">The operation the claims principal wishes to perform on the entity</param>
    /// <returns><see langword="true" /> if the principal has permission perform the action, <see langword="false" /> otherwise..</returns>
    bool CanDo(ClaimsPrincipal principal, string operation);

#if NET6_0_OR_GREATER
    /// <summary>
    /// Checks if the specified principal has permission to read the entity.
    /// </summary>
    /// <param name="principal">Claims principal that represents the user.</param>
    /// <returns>True if the principal has permission to read the entity, else false.</returns>
    bool CanRead(ClaimsPrincipal principal) =>
        CanDo(principal, Dgmjr.Security.Operations.Read.Name);

    /// <summary>
    /// Checks if the specified principal has permission to update the entity.
    /// </summary>
    /// <param name="principal">Claims principal that represents the user.</param>
    /// <returns>True if the principal has permission to update the entity, else false.</returns>
    bool CanUpdate(ClaimsPrincipal principal) =>
        CanDo(principal, Dgmjr.Security.Operations.Update.Name);

    /// <summary>
    /// Checks if the specified principal has permission to delete the entity.
    /// </summary>
    /// <param name="principal">Claims principal that represents the user.</param>
    /// <returns>True if the principal has permission to delete the entity, else false.</returns>
    bool CanDelete(ClaimsPrincipal principal) =>
        CanDo(principal, Dgmjr.Security.Operations.Delete.Name);

    /// <summary>
    /// Checks if the specified principal has permission to create the entity.
    /// </summary>
    /// <param name="principal">Claims principal that represents the user.</param>
    /// <returns>True if the principal has permission to create the entity, else false.</returns>
    bool CanCreate(ClaimsPrincipal principal) =>
        CanDo(principal, Dgmjr.Security.Operations.Create.Name);
#else
    /// <summary>
    /// Checks if the specified principal has permission to read the entity.
    /// </summary>
    /// <param name="principal">Claims principal that represents the user.</param>
    /// <returns>True if the principal has permission to read the entity, else false.</returns>
    bool CanRead(ClaimsPrincipal principal);

    /// <summary>
    /// Checks if the specified principal has permission to update the entity.
    /// </summary>
    /// <param name="principal">Claims principal that represents the user.</param>
    /// <returns>True if the principal has permission to update the entity, else false.</returns>
    bool CanUpdate(ClaimsPrincipal principal);

    /// <summary>
    /// Checks if the specified principal has permission to delete the entity.
    /// </summary>
    /// <param name="principal">Claims principal that represents the user.</param>
    /// <returns>True if the principal has permission to delete the entity, else false.</returns>
    bool CanDelete(ClaimsPrincipal principal);

    /// <summary>
    /// Checks if the specified principal has permission to create the entity.
    /// </summary>
    /// <param name="principal">Claims principal that represents the user.</param>
    /// <returns>True if the principal has permission to create the entity, else false.</returns>
    bool CanCreate(ClaimsPrincipal principal);
#endif
}
