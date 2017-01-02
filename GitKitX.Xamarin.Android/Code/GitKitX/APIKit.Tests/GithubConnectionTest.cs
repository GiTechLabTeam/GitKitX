using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using GitHostingAPIKit;

namespace APIKit.Tests
{
    [TestClass]
    public class GithubConnectionTest
    {
        [TestMethod]
        public void ClientValidation()
        {
            var apiKit = APIKitBase.GetKitInstance<GithubAPIKit>("gitechlab", "1233445");
            var info = apiKit.ClientValidation();
            info.Wait();
        }
    }
}
