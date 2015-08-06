#region HappyDo
// This is HappyDo
// which downloads files from one place to another
// thus, making me happy.
// https://github.com/picrap/HappyDo
// MIT License
#endregion

namespace HappyDo.Core.Rules
{
    using System.IO;
    using Newtonsoft.Json;

    public class Do
    {
        public string SourcePath { get; set; }
        public Credential SourceCredential { get; set; }

        public string TargetPath { get; set; }
        public Credential TargetCredential { get; set; }

        public Rule[] Rules { get; set; }

        public void Serialize(TextWriter textWriter)
        {
            var serializer = JsonSerializer.Create();
            serializer.Serialize(textWriter, this);
        }

        public void Serialize(Stream stream)
        {
            using (var writer = new StreamWriter(stream))
                Serialize(writer);
        }

    }
}
