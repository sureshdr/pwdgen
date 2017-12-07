using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pwdgen
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] result = Enumerable.Range(0, 100)
                            .Select(i => (int)i + 1)
                            .ToArray();
            cmbLength.DataSource = result;
            cmbLength.SelectedIndex = 19;
            chkLower.Checked = true;
            chkUpper.Checked = true;
            chkSpecial.Checked = true;
            chkNum.Checked = true;
            PasswordGen.useLower = true;
            PasswordGen.useUpper = true;
            PasswordGen.useSpecial = true;
            PasswordGen.useNumeric = true; 
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtResult.Text = PasswordGen.Generate(Convert.ToInt32(cmbLength.SelectedValue));
        }

        private void chkLower_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLower.Checked)
                PasswordGen.useLower = true;
            else
                PasswordGen.useLower = false; 
        }

        private void chkUpper_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUpper.Checked)
                PasswordGen.useUpper = true;
            else
                PasswordGen.useUpper = false;
        }

        private void chkNum_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNum.Checked)
                PasswordGen.useNumeric = true;
            else
                PasswordGen.useNumeric = false; 
        }

        private void chkSpace_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpace.Checked)
                PasswordGen.useSpace = true;
            else
                PasswordGen.useSpace = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpecial.Checked)
                PasswordGen.useSpecial = true;
            else
                PasswordGen.useSpecial = false;
        }

        private void chkBracket_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBracket.Checked)
                PasswordGen.useBracket = true;
            else
                PasswordGen.useBracket = false;
        }
    }
}
