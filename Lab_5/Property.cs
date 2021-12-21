using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class Property : Form
    {
        public INIProperty output;
        public Property()
        {
            InitializeComponent();
        }
        public Property(string field, string value)
        {
            InitializeComponent();
            fieldTB.Text = field; 
            ValueTB.Text = value;
            
        }
            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            output = new INIProperty(fieldTB.Text, ValueTB.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
