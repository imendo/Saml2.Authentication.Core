using System.Linq;
using Microsoft.AspNetCore.Http;
using Imendo.Saml2.Authentication;

namespace Imendo.Saml2.Extensions
{
    public static class HttpResponseExtensions
    {
        public static void DeleteAllRequestIdCookies(this HttpResponse response, HttpRequest request,
            CookieOptions options)
        {
            var cookies = request.Cookies;
            foreach (var coookie in cookies.Where(c => c.Key.StartsWith(Saml2Defaults.RequestIdCookiePrefix)))
                response.Cookies.Delete(coookie.Key, options);
        }
    }
}