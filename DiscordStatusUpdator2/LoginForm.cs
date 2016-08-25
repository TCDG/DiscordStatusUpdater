using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordStatusUpdator2
{
    public partial class LoginForm : Form
    {
        private Boolean waitc = false;
        public LoginForm()
        {
            InitializeComponent();
            tb_user.Enabled = true;
            tb_pass.Enabled = true;
            tb_token.Enabled = false;
            if (File.Exists("luser.txt")) {
                StreamReader File = new StreamReader("luser.txt");
                tb_user.Text = File.ReadLine();
                File.Close();
            }
            if (File.Exists("ltoken.txt"))
            {
                StreamReader File = new StreamReader("ltoken.txt");
                tb_token.Text = File.ReadLine();
                File.Close();
            }
            l_email.ForeColor = Color.Black;
            l_pass.ForeColor = Color.Black;
            l_token.ForeColor = Color.LightGray;
            Program.atry = false;
            this.Text = "DSU: User Login";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            while (waitc)
            {
                waitc = true;
                Program.log("Waiting");
                System.Threading.Thread.Sleep(1000);
            }
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
            Program.abot = rb_bot.Checked;
            Program.auser = tb_user.Text;
            Program.apass = tb_pass.Text;
            Program.atoken = tb_token.Text;
            waitc = false;
            StreamWriter File1 = new StreamWriter("luser.txt");
            File1.Write(tb_user.Text);
            File1.Close();
            StreamWriter File2 = new StreamWriter("ltoken.txt");
            File2.Write(tb_token.Text);
            File2.Close();
            Program.atry = true;
            this.Close();
        }

        private void rb_user_CheckedChanged(object sender, EventArgs e)
        {
            tb_user.Enabled = true;
            tb_pass.Enabled = true;
            tb_token.Enabled = false;

            l_email.ForeColor = Color.Black;
            l_pass.ForeColor = Color.Black;
            l_token.ForeColor = Color.LightGray;
            this.Text = "DSU: User Login";

        }

        private void rb_bot_CheckedChanged(object sender, EventArgs e)
        {
            tb_user.Enabled = false;
            tb_pass.Enabled = false;
            tb_token.Enabled = true;

            l_email.ForeColor = Color.LightGray;
            l_pass.ForeColor = Color.LightGray;
            l_token.ForeColor = Color.Black;
            this.Text = "DSU: Bot Login";
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.end(false);
        }
    }
}
