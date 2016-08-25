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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = "DSU: ControlPannel [" + Program.client.CurrentUser.Name+"]";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            if (File.Exists("mstat.txt"))
            {
                StreamReader File = new StreamReader("mstat.txt");
                t_stat.Text = File.ReadLine();
                File.Close();
            }
            if (File.Exists("mafk.txt"))
            {
                StreamReader File = new StreamReader("mafk.txt");
                t_afk.Text = File.ReadLine();
                File.Close();
            }
            if (File.Exists("mmen.txt"))
            {
                StreamReader File = new StreamReader("mmen.txt");
                t_men.Text = File.ReadLine();
                File.Close();
            }
        }

        private void cb_men_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_afk.Checked)
            {
                cb_afk.Checked = false;
            }

        }

        private void cb_afk_CheckedChanged(object sender, EventArgs e)
        {

            if (cb_men.Checked)
            {
                cb_men.Checked = false;
            }



        }

        private void t_stat_TextChanged(object sender, EventArgs e)
        {
            StreamWriter File = new StreamWriter("mstat.txt");
            File.Write(t_stat.Text);
            File.Close();
        }

        private void t_afk_TextChanged(object sender, EventArgs e)
        {
            StreamWriter File = new StreamWriter("mafk.txt");
            File.Write(t_afk.Text);
            File.Close();
        }

        private void t_men_TextChanged(object sender, EventArgs e)
        {
            StreamWriter File = new StreamWriter("mmen.txt");
            File.Write(t_men.Text);
            File.Close();
        }

        private void cb_stat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void b_upd_Click(object sender, EventArgs e)
        {


            Program.update_stat(cb_stat.Checked, t_stat.Text);
            Program.update_afk(cb_afk.Checked, t_afk.Text);
            Program.update_men(cb_men.Checked, t_men.Text);


        }

        private void b_logout_Click(object sender, EventArgs e)
        {
            Program.end(true);
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.end(true);
        }
    }
}
