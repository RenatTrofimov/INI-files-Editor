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
    public partial class Block : Form
    {
        public INIBlock output;

        public Block()
        {
            InitializeComponent();
        }
        public Block(string name)
        {
            InitializeComponent();
            nameTB.Text = name;
        }
            private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            output = new INIBlock(nameTB.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
