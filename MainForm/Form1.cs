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

        string path = @"D:\University\3course\5semester\SPP\labs\laba4\MainForm\bin\Debug\plugins";
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
                            case AnchorAttribute atr:
                                AddToAnchor(atr,type);
                                break;
                            case LTRPanelAttribute _:
                                AddToLTRPanel(type);
                                break;
                            case RTLPanelAttribute _:
                                AddToRTLPanel(type);
                                break;
                            case TabAttribute _:
                                AddToTabControl(type);
                                break;
                            case VerticalPanelAttribute _:
                                AddToVerticalControl(type);
                                break;
                        }
                    }
                }
            }
        }
        void AddToAnchor(AnchorAttribute atr, Type formtype)//todo
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
        void AddToLTRPanel(Type formtype)//todo
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
        void AddToRTLPanel(Type formtype)//todo
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
            form.FormBorderStyle = FormBorderStyle.None;
            TabPage tp = new TabPage();
            tp.Text = form.Text;
            TabControl_Main.TabPages.Add(tp);
            form.TopLevel = false;
            form.Parent = tp;
            form.Show();
        }
    }
}
