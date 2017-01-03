namespace GitHostingAPIKit
{
    public abstract class APIKitBase
    {
        public string _userName { get; protected set; }
        public string _password { get; protected set; }

        public static KitInstance GetKitInstance<KitInstance>(string userName, string password) where KitInstance : APIKitBase, new()
        {
            var instance = new KitInstance();
            instance._userName = userName;
            instance._password = password;
            return instance;
        }
    }
}
