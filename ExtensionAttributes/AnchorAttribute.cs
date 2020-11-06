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
        public enum VerAnchor { Top,Center,Bottom }
        public VerAnchor vanchor;
        public enum HorAnchor { Left,Center,Right}
        public HorAnchor hanchor;
        public AnchorAttribute(VerAnchor vanch,HorAnchor hanch)
        {
            vanchor = vanch;
            hanchor = hanch;
        }
    }
}
