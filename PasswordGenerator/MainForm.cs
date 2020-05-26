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

        private enum Option { Letters, Numbers, Upper, Lower, Special }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (nudLength.Value > 0)
            {
                List<Option> options = new List<Option>(5);

                if (chkbxLetters.Checked)
                {
                    if (chkbxUpper.Checked)
                    {
                        options.Add(Option.Upper);
                    }
                    if (chkbxLower.Checked)
                    {
                        options.Add(Option.Lower);
                    }
                }
                if (chkbxNumbers.Checked)
                {
                    options.Add(Option.Numbers);
                }

                if (chkbxSpecial.Checked)
                {
                    options.Add(Option.Special);
                }

                string letters = "abcdefghijklmnopqrstuvwxyz";
                string password = string.Empty;
                Random rnd = new Random();
                Option rndOption;

                for (int i = 0; i < nudLength.Value; i++)
                {
                    rndOption = options[rnd.Next(0, options.Count)];

                    switch (rndOption)
                    {
                        case Option.Numbers:
                            password += rnd.Next(0, 10).ToString(); //[0; 9]
                            break;
                        case Option.Upper:
                            password += letters[rnd.Next(0, letters.Length)].ToString().ToUpper();
                            break;
                        case Option.Lower:
                            password += letters[rnd.Next(0, letters.Length)];
                            break;
                        case Option.Special:
                            break;
                    }
                }
                txbPasswords.Text = password;
            }
        }

        private void chkbxLetters_CheckStateChanged(object sender, EventArgs e)
        {
            bool status = ((CheckBox)sender).Checked;

            chkbxLower.Enabled = status;
            chkbxUpper.Enabled = status;
        }
    }
}
