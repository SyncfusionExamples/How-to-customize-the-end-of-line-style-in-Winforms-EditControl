using System;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace Edit_demos
{  
    public partial class Form1 : Form
    {
        private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboboxAdv1;
        public Form1()
        {
            InitializeComponent();
            editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();          
            editControl1.Location = new Point(20, 100);
            editControl1.Size = new Size(600, 400);
            this.BackColor = Color.White;
            this.editControl1.ShowEndOfLine = true;
            this.editControl1.BorderStyle = BorderStyle.FixedSingle;
            this.editControl1.Dock = DockStyle.Fill;
            this.editControl1.ShowVerticalSplitters = false;
            this.editControl1.ShowHorizontalSplitters = false;
            editControl1.DefaultNewLineStyle = Syncfusion.IO.NewLineStyle.Windows;
            editControl1.LoadFile();
            this.panel2.Controls.Add(editControl1);



            comboboxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.comboboxAdv1.Location = new System.Drawing.Point(this.checkBox1.Location.X, this.checkBox1.Location.Y+50);
            this.comboboxAdv1.Size = new Size(120, 80);
            this.comboboxAdv1.Items.Add("Windows");
            this.comboboxAdv1.Items.Add("Mac");
            this.comboboxAdv1.Items.Add("Unix");
            this.comboboxAdv1.Items.Add("Control");
            this.comboboxAdv1.SelectedIndex = 0;
            this.comboboxAdv1.SelectedIndexChanged += ComboboxAdv1_SelectedIndexChanged;
            this.panel1.Controls.Add(this.comboboxAdv1);
        }

        private void ComboboxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((sender as ComboBoxAdv).SelectedIndex==0)
                editControl1.SetNewLineStyle(Syncfusion.IO.NewLineStyle.Windows);
            else if ((sender as ComboBoxAdv).SelectedIndex == 1)
                editControl1.SetNewLineStyle(Syncfusion.IO.NewLineStyle.Mac);
            else if ((sender as ComboBoxAdv).SelectedIndex == 2)
                editControl1.SetNewLineStyle(Syncfusion.IO.NewLineStyle.Unix);
            else if ((sender as ComboBoxAdv).SelectedIndex == 3)
                editControl1.SetNewLineStyle(Syncfusion.IO.NewLineStyle.Control);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.editControl1.ShowEndOfLine = this.checkBox1.Checked;
        }
    }
}
