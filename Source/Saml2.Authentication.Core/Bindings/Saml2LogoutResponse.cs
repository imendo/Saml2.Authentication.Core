using dk.nita.saml20.Schema.Protocol;

namespace Imendo.Saml2.Bindings
{
    public class Saml2LogoutResponse
    {
        public LogoutRequest OriginalLogoutRequest { get; set; }

        public string StatusCode { get; set; }
    }
}