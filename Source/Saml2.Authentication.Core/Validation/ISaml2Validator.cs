using System.Security.Cryptography;
using System.Xml;

namespace Imendo.Saml2.Validation
{
    public interface ISaml2Validator
    {
        void CheckReplayAttack(string inResponseTo, string originalSamlRequestId);

        void CheckReplayAttack(XmlElement element, string originalSamlRequestId);

        bool CheckStatus(XmlDocument samlResponseDocument);

        Saml2Assertion GetValidatedAssertion(XmlElement assertionElement, AsymmetricAlgorithm key, string audience, bool omitAssertionSignatureCheck = false);
        bool ValidateLogoutRequestIssuer(string logoutRequestIssuer, string identityProviderEntityId);
    }
}