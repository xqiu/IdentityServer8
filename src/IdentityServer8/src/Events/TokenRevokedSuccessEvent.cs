/*
 Copyright (c) 2024 HigginsSoft
 Written by Alexander Higgins https://github.com/alexhiggins732/ 
 

 Copyright (c) 2018, Brock Allen & Dominick Baier. All rights reserved.

 Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information. 
 Source code for this software can be found at https://github.com/alexhiggins732/IdentityServer8

 The above copyright notice and this permission notice shall be included in all
 copies or substantial portions of the Software.

*/

namespace IdentityServer8.Events;

/// <summary>
/// Event for successful token revocation
/// </summary>
/// <seealso cref="IdentityServer8.Events.Event" />
public class TokenRevokedSuccessEvent : Event
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TokenRevokedSuccessEvent"/> class.
    /// </summary>
    /// <param name="requestResult">The request result.</param>
    /// <param name="client">The client.</param>
    public TokenRevokedSuccessEvent(TokenRevocationRequestValidationResult requestResult, Client client)
        : base(EventCategories.Token,
              "Token Revoked Success",
              EventTypes.Success,
              EventIds.TokenRevokedSuccess)
    {
        ClientId = client.ClientId;
        ClientName = client.ClientName;
        TokenType = requestResult.TokenTypeHint;
        Token = Obfuscate(requestResult.Token);
    }

    /// <summary>
    /// Gets or sets the client identifier.
    /// </summary>
    /// <value>
    /// The client identifier.
    /// </value>
    public string ClientId { get; set; }

    /// <summary>
    /// Gets or sets the name of the client.
    /// </summary>
    /// <value>
    /// The name of the client.
    /// </value>
    public string ClientName { get; set; }

    /// <summary>
    /// Gets or sets the type of the token.
    /// </summary>
    /// <value>
    /// The type of the token.
    /// </value>
    public string TokenType { get; set; }

    /// <summary>
    /// Gets or sets the token.
    /// </summary>
    /// <value>
    /// The token.
    /// </value>
    public string Token { get; set; }
}
