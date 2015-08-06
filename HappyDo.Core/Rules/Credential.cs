#region HappyDo
// This is HappyDo
// which downloads files from one place to another
// thus, making me happy.
// https://github.com/picrap/HappyDo
// MIT License
#endregion
namespace HappyDo.Core.Rules
{
    using System.Net;

    public class Credential
    {
        private readonly NetworkCredential _networkCredential;

        public string UserName
        {
            get { return _networkCredential.UserName; }
            set { _networkCredential.UserName = value; }
        }

        public string Password
        {
            get { return _networkCredential.Password; }
            set { _networkCredential.Password = value; }
        }

        public Credential()
        {
            _networkCredential = new NetworkCredential();
        }

        public Credential(string user, string password)
        {
            _networkCredential = new NetworkCredential(user, password);
        }

        public Credential(NetworkCredential networkCredential)
        {
            _networkCredential = networkCredential;
        }

        public static implicit operator NetworkCredential(Credential credential)
        {
            return credential._networkCredential;
        }
    }
}