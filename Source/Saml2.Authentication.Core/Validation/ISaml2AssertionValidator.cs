using System;
using dk.nita.saml20.Schema.Core;

namespace Imendo.Saml2.Validation
{
    internal interface ISaml2AssertionValidator
    {
        void ValidateAssertion(Assertion assertion);

        void ValidateTimeRestrictions(Assertion assertion, TimeSpan allowedClockSkew);
    }
}