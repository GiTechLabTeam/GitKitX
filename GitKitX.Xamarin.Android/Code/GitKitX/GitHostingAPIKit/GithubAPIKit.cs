
using System;
using System.Threading.Tasks;
using Octokit;

namespace GitHostingAPIKit
{
    public class GithubAPIKit : APIKitBase
    {
        public GithubAPIKit() { }

        public async void Connect()
        {
            var result = string.Empty;
            try
            {
                var client = new GitHubClient(new ProductHeaderValue("GitKitX"));
                client.Credentials = new Credentials(_userName, _password);
                var user = await client.User.Current();
                result = string.Format(
                        "{0} has {1} public repositories - go check out their profile at {2}",
                        user.Name,
                        user.PublicRepos,
                        user.Url
                    );
            }
            catch (Exception error)
            {
                var ExPInfo = error.Message;
            }
        }

        public string GetMessage(string userName, string password)
        {
            return "Hello, " + userName;
        }


    }
}

