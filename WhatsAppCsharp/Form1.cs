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
            if(string.IsNullOrEmpty(txtBoxCode.Text))
            {
                MessageBox.Show("Please enter the sms code.", "Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxCode.Focus();
                return;
            }
            password = WhatsAppApi.Register.WhatsRegisterV2.RegisterCode(
                txtBoxPhone.Text,
                txtBoxCode.Text);
            Save();
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
                if(!string.IsNullOrEmpty(password))
                {
                    Save();
                }
                else
                {
                    groupRequestCode.Enabled = false;
                    grpConfirm.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Could not generate password.", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if(Globals.DB.Accounts.FindByAccountID(txtBoxPhone.Text) == null)
            {
                WhatsAppDataSet.AccountsRow row = Globals.DB.Accounts.NewAccountsRow();
                row.AccountID = txtBoxPhone.Text;
                row.FullName = txtBoxFullName.Text;
                row.Password = password;
                Globals.DB.Accounts.AddAccountsRow(row);
                Globals.DB.Accounts.AcceptChanges();
                Globals.DB.Accounts.WriteXml(string.Format("{0}\\accounts.dat", Application.StartupPath));
            }
            DialogResult = DialogResult.OK;
        }
    }
}
