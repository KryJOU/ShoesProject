using System;
using System.Windows.Forms;

namespace ShoesProject
{
    public partial class ChooseForm : Form
    {
        public int Choose { get; private set; } = 0;

        public ChooseForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Choose = 2;
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Choose = 1;
            this.DialogResult = DialogResult.OK;
        }
    }
}
