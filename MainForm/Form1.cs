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
using System.IO;
using System.Reflection;
namespace MainForm
{
    public partial class MainForm : Form
    {

        string path = Environment.CurrentDirectory+@"\plugins";
        public MainForm()
        {
            InitializeComponent();
            LoadComponents(path);
        }
        void LoadComponents(string path)
        {
            if (Directory.Exists(path))
                
                foreach (var fileInfo in new DirectoryInfo(path).GetFiles())
                {
                    if(fileInfo.Extension==".dll")
                    try
                    {
                        Assembly assembly = Assembly.LoadFile(fileInfo.FullName);
                        LoadExtension(assembly);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(string.Format("Unable to load assembly ",fileInfo.Name," : ",ex));
                    }
                }
        }
        void LoadExtension(Assembly assembly)
        {
            Type[] types = assembly.GetTypes();
            foreach (var type in types)
            {
                if (type.BaseType == typeof(Form))
                {
                    foreach (object attribute in type.GetCustomAttributes(false))
                    {
                        switch (attribute)
                        {
                            case LTRPanelAttribute _:
                                AddToLTRPanel(type);
                                break;
                            case AnchorAttribute atr:
                                AddToAnchorTable(atr,type);
                                break;
                            case RTLPanelAttribute _:
                                AddToRTLPanel(type);
                                break;
                            case TabAttribute _:
                                AddToTabControl(type);
                                break;
                            case VerticalPanelAttribute _:
                                AddToVerticalPanel(type);
                                break;
                        }
                    }
                }
            }
        }
        void AddToLTRPanel(Type formtype)//todo
        {
            Form form = (Form)formtype.GetConstructor(new Type[0]).Invoke(null);
            form.Hide();
            form.TopLevel = false;
            form.Parent = FlowLayoutPanel_LTRToolbox;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }
        void AddToAnchorTable(AnchorAttribute atr,Type formtype)//todo
        {
            Form form = (Form)formtype.GetConstructor(new Type[0]).Invoke(null);
            form.Hide();
            form.TopLevel = false;
            form.Parent = TableLayoutPanel_Anchoring;
            form.Anchor=AnchorStyles.Left|AnchorStyles.Right|AnchorStyles.Top|AnchorStyles.Bottom;
            TableLayoutPanel_Anchoring.SetCellPosition(form, new TableLayoutPanelCellPosition((int)atr.hanchor, (int)atr.vanchor));
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }
        void AddToRTLPanel(Type formtype)//todo
        {
            Form form = (Form)formtype.GetConstructor(new Type[0]).Invoke(null);
            form.Hide();
            form.TopLevel = false;
            form.Parent = FlowLayoutPanel_RTLToolbox;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }
        void AddToTabControl(Type formtype)
        {
            Form form = (Form)formtype.GetConstructor(new Type[0]).Invoke(null);
            form.Hide();
            form.FormBorderStyle = FormBorderStyle.None;
            TabPage tp = new TabPage();
            tp.Text = form.Text;
            TabControl_Main.TabPages.Add(tp);
            form.TopLevel = false;
            form.Parent = tp;
            form.Show();
        }
        void AddToVerticalPanel(Type formtype)//todo
        {
            Form form = (Form)formtype.GetConstructor(new Type[0]).Invoke(null);
            form.Hide();
            form.TopLevel = false;
            form.Parent = FlowLayoutPanel_Vertical;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }
    }
}
