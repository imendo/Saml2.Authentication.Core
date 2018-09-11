﻿using System;
using Microsoft.AspNetCore.Http;
using Imendo.Saml2.Bindings;

namespace Imendo.Saml2.Services
{
    public interface ISamlService
    {
        string GetAuthnRequest(string authnRequestId, string relayState, string assertionConsumerServiceUrl, bool isPassive, bool forceAuth);

        Saml2Assertion HandleHttpRedirectResponse(string base64EncodedSamlResponse, string originalSamlRequestId);

        Saml2Assertion HandleHttpArtifactResponse(HttpRequest request);

        bool IsLogoutResponseValid(Uri uri, string originalRequestId);

        string GetLogoutRequest(string logoutRequestId, string sessionIndex, string subject, string relayState);
        Saml2LogoutResponse GetLogoutReponse(Uri uri);
        string GetLogoutResponseUrl(Saml2LogoutResponse logoutResponse, string relayState);
    }
}