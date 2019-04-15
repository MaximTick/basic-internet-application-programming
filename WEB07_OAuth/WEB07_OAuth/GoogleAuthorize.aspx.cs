using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Util.Store;
using System;
using System.Threading;


namespace WEB07_OAuth
{
    public partial class GoogleAuthorize : System.Web.UI.Page
    {
        public static string ApplicationName = "WEB07_OAuth Client 1";
        public static string ClientId = "783117306674-d7eq14joh7bqd04mf3duo17atljk5b5g.apps.googleusercontent.com";
        public static string ClientSecret = "здесь мой серет";

        public static string[] Scopes =
        {
            GmailService.Scope.GmailCompose,
            GmailService.Scope.GmailSend
        };
        public static UserCredential GetUserCredential(out string error)
        {
            UserCredential credential = null;
            error = string.Empty;
            try
            {
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    new ClientSecrets
                    {
                        ClientId = ClientId,
                        ClientSecret = ClientSecret
                    },
                    Scopes,
                    Environment.UserName,
                    CancellationToken.None,
                    new FileDataStore("Google Oaut2 Client App")).Result;
            }
            catch(Exception ex)
            {
                credential = null;
                error = "Failed to UserCredential Initialization " + ex.ToString();
            }
            return credential;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Authorize_Click(object sender, EventArgs e)
        {
            string credentialError = string.Empty;
            string refreshTocken = string.Empty;
            UserCredential credential = GetUserCredential(out credentialError);
            if(credential != null && string.IsNullOrWhiteSpace(credentialError))
            {
                refreshTocken = credential.Token.RefreshToken;
            }
        }
    }
}