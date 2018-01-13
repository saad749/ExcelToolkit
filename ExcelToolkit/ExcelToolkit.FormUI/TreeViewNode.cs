using System.Collections.Generic;

namespace ExcelToolkit.FormUI
{
    public partial class FormMain
    {
        public class TreeViewNode
        {
            public List<TreeViewNode> Nodes { get; set; }
            public TreeViewNode Parent { get; set; }
            public string Text { get; set; }
            public string Tag { get; set; }
            public string TooltipText { get; set; }
            public System.Drawing.Color BackColor { get; set; }
        }
    }
}
