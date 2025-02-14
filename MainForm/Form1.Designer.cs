﻿namespace MainForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel_Explorer = new System.Windows.Forms.Panel();
            this.FlowLayoutPanel_Vertical = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel_Toolbox = new System.Windows.Forms.Panel();
            this.FlowLayoutPanel_LTRToolbox = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel_Tabs = new System.Windows.Forms.Panel();
            this.TabControl_Main = new System.Windows.Forms.TabControl();
            this.Panel_Output = new System.Windows.Forms.Panel();
            this.FlowLayoutPanel_RTLToolbox = new System.Windows.Forms.FlowLayoutPanel();
            this.TabPage_Table = new System.Windows.Forms.TabPage();
            this.TableLayoutPanel_Anchoring = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_Explorer.SuspendLayout();
            this.Panel_Toolbox.SuspendLayout();
            this.Panel_Tabs.SuspendLayout();
            this.TabControl_Main.SuspendLayout();
            this.Panel_Output.SuspendLayout();
            this.TabPage_Table.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Explorer
            // 
            this.Panel_Explorer.AutoScroll = true;
            this.Panel_Explorer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Panel_Explorer.Controls.Add(this.FlowLayoutPanel_Vertical);
            this.Panel_Explorer.Location = new System.Drawing.Point(1004, 119);
            this.Panel_Explorer.Name = "Panel_Explorer";
            this.Panel_Explorer.Size = new System.Drawing.Size(216, 771);
            this.Panel_Explorer.TabIndex = 0;
            // 
            // FlowLayoutPanel_Vertical
            // 
            this.FlowLayoutPanel_Vertical.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowLayoutPanel_Vertical.AutoScroll = true;
            this.FlowLayoutPanel_Vertical.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowLayoutPanel_Vertical.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutPanel_Vertical.Name = "FlowLayoutPanel_Vertical";
            this.FlowLayoutPanel_Vertical.Size = new System.Drawing.Size(216, 768);
            this.FlowLayoutPanel_Vertical.TabIndex = 0;
            this.FlowLayoutPanel_Vertical.WrapContents = false;
            // 
            // Panel_Toolbox
            // 
            this.Panel_Toolbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Panel_Toolbox.Controls.Add(this.FlowLayoutPanel_LTRToolbox);
            this.Panel_Toolbox.Location = new System.Drawing.Point(3, 4);
            this.Panel_Toolbox.Name = "Panel_Toolbox";
            this.Panel_Toolbox.Size = new System.Drawing.Size(626, 109);
            this.Panel_Toolbox.TabIndex = 1;
            // 
            // FlowLayoutPanel_LTRToolbox
            // 
            this.FlowLayoutPanel_LTRToolbox.AutoScroll = true;
            this.FlowLayoutPanel_LTRToolbox.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutPanel_LTRToolbox.Name = "FlowLayoutPanel_LTRToolbox";
            this.FlowLayoutPanel_LTRToolbox.Size = new System.Drawing.Size(626, 109);
            this.FlowLayoutPanel_LTRToolbox.TabIndex = 0;
            this.FlowLayoutPanel_LTRToolbox.WrapContents = false;
            // 
            // Panel_Tabs
            // 
            this.Panel_Tabs.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Panel_Tabs.Controls.Add(this.TabControl_Main);
            this.Panel_Tabs.Location = new System.Drawing.Point(3, 119);
            this.Panel_Tabs.Name = "Panel_Tabs";
            this.Panel_Tabs.Size = new System.Drawing.Size(995, 771);
            this.Panel_Tabs.TabIndex = 2;
            // 
            // TabControl_Main
            // 
            this.TabControl_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl_Main.Controls.Add(this.TabPage_Table);
            this.TabControl_Main.Location = new System.Drawing.Point(4, 4);
            this.TabControl_Main.Name = "TabControl_Main";
            this.TabControl_Main.SelectedIndex = 0;
            this.TabControl_Main.Size = new System.Drawing.Size(988, 764);
            this.TabControl_Main.TabIndex = 0;
            // 
            // Panel_Output
            // 
            this.Panel_Output.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Panel_Output.Controls.Add(this.FlowLayoutPanel_RTLToolbox);
            this.Panel_Output.Location = new System.Drawing.Point(635, 4);
            this.Panel_Output.Name = "Panel_Output";
            this.Panel_Output.Size = new System.Drawing.Size(585, 109);
            this.Panel_Output.TabIndex = 3;
            // 
            // FlowLayoutPanel_RTLToolbox
            // 
            this.FlowLayoutPanel_RTLToolbox.AutoScroll = true;
            this.FlowLayoutPanel_RTLToolbox.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlowLayoutPanel_RTLToolbox.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutPanel_RTLToolbox.Name = "FlowLayoutPanel_RTLToolbox";
            this.FlowLayoutPanel_RTLToolbox.Size = new System.Drawing.Size(585, 109);
            this.FlowLayoutPanel_RTLToolbox.TabIndex = 0;
            this.FlowLayoutPanel_RTLToolbox.WrapContents = false;
            // 
            // TabPage_Table
            // 
            this.TabPage_Table.Controls.Add(this.TableLayoutPanel_Anchoring);
            this.TabPage_Table.Location = new System.Drawing.Point(4, 25);
            this.TabPage_Table.Name = "TabPage_Table";
            this.TabPage_Table.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Table.Size = new System.Drawing.Size(980, 735);
            this.TabPage_Table.TabIndex = 0;
            this.TabPage_Table.Text = "TableTab";
            this.TabPage_Table.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanel_Anchoring
            // 
            this.TableLayoutPanel_Anchoring.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TableLayoutPanel_Anchoring.ColumnCount = 3;
            this.TableLayoutPanel_Anchoring.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel_Anchoring.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel_Anchoring.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel_Anchoring.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanel_Anchoring.Name = "TableLayoutPanel_Anchoring";
            this.TableLayoutPanel_Anchoring.RowCount = 3;
            this.TableLayoutPanel_Anchoring.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel_Anchoring.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel_Anchoring.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel_Anchoring.Size = new System.Drawing.Size(971, 726);
            this.TableLayoutPanel_Anchoring.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1225, 902);
            this.Controls.Add(this.Panel_Output);
            this.Controls.Add(this.Panel_Tabs);
            this.Controls.Add(this.Panel_Toolbox);
            this.Controls.Add(this.Panel_Explorer);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main form";
            this.Panel_Explorer.ResumeLayout(false);
            this.Panel_Toolbox.ResumeLayout(false);
            this.Panel_Tabs.ResumeLayout(false);
            this.TabControl_Main.ResumeLayout(false);
            this.Panel_Output.ResumeLayout(false);
            this.TabPage_Table.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Explorer;
        private System.Windows.Forms.Panel Panel_Toolbox;
        private System.Windows.Forms.Panel Panel_Tabs;
        private System.Windows.Forms.Panel Panel_Output;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_Vertical;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_LTRToolbox;
        private System.Windows.Forms.TabControl TabControl_Main;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_RTLToolbox;
        private System.Windows.Forms.TabPage TabPage_Table;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel_Anchoring;
    }
}

