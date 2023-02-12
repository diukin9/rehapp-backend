﻿using System.Security.Claims;

namespace RehApp.Infrastructure.Common.Extensions;

public static class ClaimExtensions
{
    public static string? GetByClaimType(this IEnumerable<Claim> claims, string claimType)
    {
        return claims?.Where(c => c.Type == claimType).SingleOrDefault()?.Value;
    }
}
