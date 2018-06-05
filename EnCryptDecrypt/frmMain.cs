using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnCryptDecrypt
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (txtMail1.Text == "")
            {
                error.SetError(txtMail1, "Enter the text for email1.");
                return;
            }
            else
            {
                if (!Common.IsValidEmail(txtMail1.Text))
                {
                    error.SetError(txtMail1, "Email1 not valid!");
                    return;
                }
                error.Clear();
            }

            if (txtPass.Text == "")
            {
                error.SetError(txtPass, "Enter the text for pass");
                return;
            }
            else
            {
                error.Clear();
            }

            if (txtMail2.Text != "")
            {
                if (!Common.IsValidEmail(txtMail2.Text))
                {
                    error.SetError(txtMail2, "Email2 not valid!");
                    return;
                }
                error.Clear();
            }

            try
            {
                //error.Clear();
                string mail1 = txtMail1.Text.Trim();
                string pass = txtPass.Text.Trim();
                string mail2 = txtMail2.Text.Trim();

                string cipherText = CryptorEngine.Encrypt(String.Format("{0}/{1}/{2}", mail1, pass, mail2), true);
                txtLicense.Text = cipherText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}