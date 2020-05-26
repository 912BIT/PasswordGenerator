using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CheckDefaultOptions();
        }

        private void CheckDefaultOptions()
        {
            bool status = chkbxDefault.Checked;
            if (status)
            {
                chkbxLetters.Checked = status;
                chkbxNumbers.Checked = status;
                chkbxUpper.Checked = status;
                chkbxLower.Checked = status;
                chkbxSpecial.Checked = !status;

                chkbxLetters.Enabled = !status;
                chkbxNumbers.Enabled = !status;
                chkbxUpper.Enabled = !status;
                chkbxLower.Enabled = !status;
                chkbxSpecial.Enabled = !status;

            }
            else
            {
                chkbxLetters.Enabled = !status;
                chkbxNumbers.Enabled = !status;
                chkbxUpper.Enabled = !status;
                chkbxLower.Enabled = !status;
                chkbxSpecial.Enabled = !status;
            }
        }

        private void chkbxDefault_CheckStateChanged(object sender, EventArgs e)
        {
            CheckDefaultOptions();
        }
    }
}
