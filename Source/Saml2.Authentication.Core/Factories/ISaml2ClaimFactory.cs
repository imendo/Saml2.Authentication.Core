using System.Collections.Generic;
using System.Security.Claims;

namespace Imendo.Saml2.Factories
{
    public interface ISaml2ClaimFactory
    {
        IList<Claim> Create(Saml2Assertion assertion);
    }
}