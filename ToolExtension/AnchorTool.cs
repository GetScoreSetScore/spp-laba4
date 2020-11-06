using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtensionAttributes;
namespace ToolExtension
{
    [Anchor(AnchorAttribute.VerAnchor.Bottom,AnchorAttribute.HorAnchor.Left)]
    [VerticalPanel]
    [LTRPanel]
    [RTLPanel]
    public partial class AnchorTool : Form
    {
        public AnchorTool()
        {
            InitializeComponent();
        }
    }
}
