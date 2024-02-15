/*
 Copyright (c) 2024 HigginsSoft
 Written by Alexander Higgins https://github.com/alexhiggins732/ 
 

 Copyright (c) 2018, Brock Allen & Dominick Baier. All rights reserved.

 Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information. 
 Source code for this software can be found at https://github.com/alexhiggins732/IdentityServer8

 The above copyright notice and this permission notice shall be included in all
 copies or substantial portions of the Software.

*/

namespace IdentityServer8.Validation;

/// <summary>
/// Validator for handling client authentication
/// </summary>
public interface IClientSecretValidator
{
    /// <summary>
    /// Tries to authenticate a client based on the incoming request
    /// </summary>
    /// <param name="context">The context.</param>
    /// <returns></returns>
    Task<ClientSecretValidationResult> ValidateAsync(HttpContext context);
}
