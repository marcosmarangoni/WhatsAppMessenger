using System;
using System.Windows.Forms;
using WhatsAppApi;

namespace WhatsAppCsharp
{
    public partial class FormWhatsApp : Form
    {
        WhatsApp whatsApp;
        public FormWhatsApp()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

        }

        private void chkBoxRemember_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormWhatsApp_Load(object sender, EventArgs e)
        {
            signOutToolStripMenuItem.Visible = false;
            panel1.BringToFront();
            if(Properties.Settings.Default.Remember)
            {
                txtBoxPhone.Text = Properties.Settings.Default.Phone;
                txtBoxPassword.Text = Properties.Settings.Default.Password;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (formRegister form = new formRegister())
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    txtBoxPhone.Text = Properties.Settings.Default.Phone;
                    txtBoxPassword.Text = Properties.Settings.Default.Password;
                }
            }
        }
    }

}
