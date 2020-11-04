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
    [Tab]
    public partial class ToolForm : Form
    {
        public ToolForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button " + button1.Text + " was clicked in form" + ActiveForm.Text);
        }
    }
}
