using dk.nita.saml20;

namespace Imendo.Saml2.Factories
{
    public interface ISaml2MessageFactory
    {
        Saml2AuthnRequest CreateAuthnRequest(string authnRequestId, string assertionConsumerServiceUrl, bool isPassive, bool forceAuth);

        Saml2LogoutRequest CreateLogoutRequest(string logoutRequestId, string sessionIndex, string subject);
        Saml2LogoutResponse CreateLogoutResponse(string statusCode, string inResponseTo);
    }
}