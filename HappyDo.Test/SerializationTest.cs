#region HappyDo
// This is HappyDo
// which downloads files from one place to another
// thus, making me happy.
// https://github.com/picrap/HappyDo
// MIT License
#endregion

namespace HappyDo.Test
{
    using System.IO;
    using System.Net;
    using System.Text;
    using Core;
    using Core.Rules;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SerializationTest
    {
        [TestMethod]
        public void SimpleSerialization()
        {
            using (var memoryStream = new MemoryStream())
            {
                var d = new Do { SourcePath = "here", SourceCredential = new Credential("user", "password") };
                d.Serialize(memoryStream);
                var b = Encoding.UTF8.GetString(memoryStream.ToArray());
            }
        }
    }
}
