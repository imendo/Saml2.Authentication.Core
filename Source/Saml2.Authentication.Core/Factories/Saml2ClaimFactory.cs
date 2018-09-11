using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Imendo.Saml2.Authentication;
using Imendo.Saml2.Extensions;

namespace Imendo.Saml2.Factories
{
    internal class Saml2ClaimFactory : ISaml2ClaimFactory
    {
        public IList<Claim> Create(Saml2Assertion assertion)
        {
            var claims = new List<Claim>();
            if (!string.IsNullOrEmpty(assertion.Subject.Value))
            {
                claims.Add(new Claim(Saml2ClaimTypes.Subject, assertion.Subject.Value));
                claims.Add(new Claim(Saml2ClaimTypes.Name, assertion.Subject.Value));
                claims.Add(new Claim(Saml2ClaimTypes.NameIdentifier, assertion.Subject.Value));
            }

            claims.Add(assertion.SessionIndex.IsNotNullOrEmpty()
                ? new Claim(Saml2ClaimTypes.SessionIndex, assertion.SessionIndex)
                : new Claim(Saml2ClaimTypes.SessionIndex, assertion.Id));

            claims.AddRange(assertion.Attributes.Select(attribute =>
                new Claim(attribute.Name, attribute.AttributeValue[0].ToString())));

            return claims;
        }
    }
}