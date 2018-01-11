using System;
using System.Windows.Forms;

namespace WhatsAppCsharp
{
    public partial class formRegister : Form
    {
        string password = "";
        public formRegister()
        {
            InitializeComponent();
        }

        private void txtBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtBoxPhone.Text))
            {
                MessageBox.Show("Please enter your phone number.", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxPhone.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtBoxFullName.Text))
            {
                MessageBox.Show("Please enter your full name.", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxFullName.Focus();
                return;
            }

            if (WhatsAppApi.Register.WhatsRegisterV2.RequestCode(txtBoxPhone.Text, out password, "sms"))
            {

            }
        }

        private void Save()
        {
            this.groupRequestCode.Enabled = false;
            this.grpConfirm.Enabled = false;
            Properties.Settings.Default.Phone = txtBoxPhone.Text;
            Properties.Settings.Default.Password = password;
            Properties.Settings.Default.FullName = txtBoxFullName.Text;
            Properties.Settings.Default.Save();
        }
    }
}
