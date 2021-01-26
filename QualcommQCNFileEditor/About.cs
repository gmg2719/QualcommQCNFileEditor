using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QualcommQCNFileEditor
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + " v" + Application.ProductVersion + " - About";
            label1.Text = Application.ProductName + " v" + Application.ProductVersion + "\n\nThis software is made by Fatih KUÇMEN for all Xiaomi Users.\n\nFor Information : fatihkucmen@gmail.com\nAll Rights Reserved - 2021";
            label1.Left = (this.Width - label1.Width) / 2;
            pictureBox1.Left = (this.Width - pictureBox1.Width) / 2;
        }
    }
}
