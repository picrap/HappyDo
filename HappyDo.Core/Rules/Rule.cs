#region HappyDo
// This is HappyDo
// which downloads files from one place to another
// thus, making me happy.
// https://github.com/picrap/HappyDo
// MIT License
#endregion
namespace HappyDo.Core.Rules
{
    public class Rule
    {
        public string Match { get; set; }

        public string SubDirectory { get; set; }
    }
}
