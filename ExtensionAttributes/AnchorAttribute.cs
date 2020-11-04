using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionAttributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AnchorAttribute : Attribute
    {
        public enum Anchor {Left,Right,Top,Bottom }
        public Anchor anchor;
        public AnchorAttribute(Anchor anch)
        {
            anchor = anch;
        }
    }
}
