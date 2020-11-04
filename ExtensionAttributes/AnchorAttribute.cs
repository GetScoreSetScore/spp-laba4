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
        public enum Anchor { Top=1, Bottom,Left,Right, }
        public Anchor anchor;
        public AnchorAttribute(Anchor anch)
        {
            anchor = anch;
        }
    }
}
