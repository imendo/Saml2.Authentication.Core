namespace Imendo.Saml2.Providers
{
    public interface ICertificateProvider
    {
        SigningCertificate GetCertificate();
    }
}