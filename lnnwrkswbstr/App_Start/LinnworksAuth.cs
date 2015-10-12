using LinnworksAPI;
using System.Linq;

namespace lnnwrkswbstr
{
    public static class LinnworksAuth
    {
        public static void Authorize()
        {
            var user = "info@pitaron.co.uk";
            var password = "Vassa1234";
            var baseUser = AuthMethods.MultiLogin(user, password).First();
            var baseSession = AuthMethods.Authorize(user, password, baseUser.Id);
            Token = baseSession.Token;
        }

        public static string Token { get; set; }
    }
}
