﻿using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace BloodBank.WEB.AuthenticationProviders
{
        public class AuthenticationProviderTest : AuthenticationStateProvider
        {
            public override async Task<AuthenticationState> GetAuthenticationStateAsync()
            {
                var anonimous = new ClaimsIdentity();
                return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(anonimous)));
            }
        }
}

