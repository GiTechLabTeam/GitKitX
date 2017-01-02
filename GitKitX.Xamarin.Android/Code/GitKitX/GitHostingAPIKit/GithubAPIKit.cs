
using System;
using System.Threading.Tasks;
using Octokit;

namespace GitHostingAPIKit
{
    public class GithubAPIKit : APIKitBase
    {
        public GithubAPIKit() { }

        public async Task ClientValidation()
        {
            var client = new GitHubClient(new ProductHeaderValue("GitKitX"));
            client.Credentials = new Credentials(_userName, _password);
            var user = await client.User.Current();
            var result = string.Format(
                    "{0} has {1} public repositories - go check out their profile at {2}",
                    user.Name,
                    user.PublicRepos,
                    user.Url
                );
        }

        public override void Connect()
        {
            var result = string.Empty;
            try
            {
                var client = new GitHubClient(new ProductHeaderValue("GitKitX"));
                client.Credentials = new Credentials(_userName, _password);
                var connectTask = GetData(client);
                connectTask.Wait();
            }
            catch (Exception error)
            {
                var ExPInfo = error.Message;
            }
        }

        public async Task GetData(GitHubClient client)
        {
            var user = await client.User.Current();
            var result = string.Format(
                    "{0} has {1} public repositories - go check out their profile at {2}",
                    user.Name,
                    user.PublicRepos,
                    user.Url
                );
        }

        public string GetMessage(string userName, string password)
        {
            return "Hello, " + userName;
        }


    }
}

