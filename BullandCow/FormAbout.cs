using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullandCow
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            this.linkLabel1.Click += LinkLabel_Click;
            this.linkLabel2.Click += LinkLabel_Click;
        }

        private void LinkLabel_Click(object sender, EventArgs e)
        {
            String url = ((LinkLabel)sender).Text.Trim ();
            System.Diagnostics.Process.Start(url);

        }
    }
}
