namespace DiscordStatusUpdator2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cb_stat = new System.Windows.Forms.CheckBox();
            this.cb_afk = new System.Windows.Forms.CheckBox();
            this.cb_men = new System.Windows.Forms.CheckBox();
            this.t_stat = new System.Windows.Forms.TextBox();
            this.t_afk = new System.Windows.Forms.TextBox();
            this.t_men = new System.Windows.Forms.TextBox();
            this.l_stat = new System.Windows.Forms.Label();
            this.l_afk = new System.Windows.Forms.Label();
            this.l_men = new System.Windows.Forms.Label();
            this.b_upd = new System.Windows.Forms.Button();
            this.b_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_stat
            // 
            this.cb_stat.AutoSize = true;
            this.cb_stat.BackColor = System.Drawing.Color.Transparent;
            this.cb_stat.Location = new System.Drawing.Point(2, 6);
            this.cb_stat.Name = "cb_stat";
            this.cb_stat.Size = new System.Drawing.Size(67, 17);
            this.cb_stat.TabIndex = 0;
            this.cb_stat.Text = "ON/OFF";
            this.cb_stat.UseVisualStyleBackColor = false;
            this.cb_stat.CheckedChanged += new System.EventHandler(this.cb_stat_CheckedChanged);
            // 
            // cb_afk
            // 
            this.cb_afk.AutoSize = true;
            this.cb_afk.BackColor = System.Drawing.Color.Transparent;
            this.cb_afk.Location = new System.Drawing.Point(2, 33);
            this.cb_afk.Name = "cb_afk";
            this.cb_afk.Size = new System.Drawing.Size(67, 17);
            this.cb_afk.TabIndex = 1;
            this.cb_afk.Text = "ON/OFF";
            this.cb_afk.UseVisualStyleBackColor = false;
            this.cb_afk.CheckedChanged += new System.EventHandler(this.cb_afk_CheckedChanged);
            // 
            // cb_men
            // 
            this.cb_men.AutoSize = true;
            this.cb_men.BackColor = System.Drawing.Color.Transparent;
            this.cb_men.Location = new System.Drawing.Point(2, 60);
            this.cb_men.Name = "cb_men";
            this.cb_men.Size = new System.Drawing.Size(67, 17);
            this.cb_men.TabIndex = 2;
            this.cb_men.Text = "ON/OFF";
            this.cb_men.UseVisualStyleBackColor = false;
            this.cb_men.CheckedChanged += new System.EventHandler(this.cb_men_CheckedChanged);
            // 
            // t_stat
            // 
            this.t_stat.Location = new System.Drawing.Point(125, 3);
            this.t_stat.Name = "t_stat";
            this.t_stat.Size = new System.Drawing.Size(208, 20);
            this.t_stat.TabIndex = 3;
            this.t_stat.Text = "DSU!";
            this.t_stat.TextChanged += new System.EventHandler(this.t_stat_TextChanged);
            // 
            // t_afk
            // 
            this.t_afk.Location = new System.Drawing.Point(125, 30);
            this.t_afk.Name = "t_afk";
            this.t_afk.Size = new System.Drawing.Size(208, 20);
            this.t_afk.TabIndex = 4;
            this.t_afk.Text = "Sorry! Im AFK";
            this.t_afk.TextChanged += new System.EventHandler(this.t_afk_TextChanged);
            // 
            // t_men
            // 
            this.t_men.Location = new System.Drawing.Point(125, 57);
            this.t_men.Name = "t_men";
            this.t_men.Size = new System.Drawing.Size(208, 20);
            this.t_men.TabIndex = 5;
            this.t_men.Text = "Hey, Whats Up!";
            this.t_men.TextChanged += new System.EventHandler(this.t_men_TextChanged);
            // 
            // l_stat
            // 
            this.l_stat.AutoSize = true;
            this.l_stat.BackColor = System.Drawing.Color.Transparent;
            this.l_stat.Location = new System.Drawing.Point(75, 6);
            this.l_stat.Name = "l_stat";
            this.l_stat.Size = new System.Drawing.Size(40, 13);
            this.l_stat.TabIndex = 6;
            this.l_stat.Text = "Status:";
            // 
            // l_afk
            // 
            this.l_afk.AutoSize = true;
            this.l_afk.BackColor = System.Drawing.Color.Transparent;
            this.l_afk.Location = new System.Drawing.Point(75, 33);
            this.l_afk.Name = "l_afk";
            this.l_afk.Size = new System.Drawing.Size(30, 13);
            this.l_afk.TabIndex = 7;
            this.l_afk.Text = "AFK:";
            // 
            // l_men
            // 
            this.l_men.AutoSize = true;
            this.l_men.BackColor = System.Drawing.Color.Transparent;
            this.l_men.Location = new System.Drawing.Point(75, 61);
            this.l_men.Name = "l_men";
            this.l_men.Size = new System.Drawing.Size(48, 13);
            this.l_men.TabIndex = 8;
            this.l_men.Text = "Mention:";
            // 
            // b_upd
            // 
            this.b_upd.Location = new System.Drawing.Point(125, 83);
            this.b_upd.Name = "b_upd";
            this.b_upd.Size = new System.Drawing.Size(208, 23);
            this.b_upd.TabIndex = 9;
            this.b_upd.Text = "Update";
            this.b_upd.UseVisualStyleBackColor = true;
            this.b_upd.Click += new System.EventHandler(this.b_upd_Click);
            // 
            // b_logout
            // 
            this.b_logout.Location = new System.Drawing.Point(2, 84);
            this.b_logout.Name = "b_logout";
            this.b_logout.Size = new System.Drawing.Size(117, 22);
            this.b_logout.TabIndex = 10;
            this.b_logout.Text = "Logout";
            this.b_logout.UseVisualStyleBackColor = true;
            this.b_logout.Click += new System.EventHandler(this.b_logout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(345, 117);
            this.Controls.Add(this.b_logout);
            this.Controls.Add(this.b_upd);
            this.Controls.Add(this.l_men);
            this.Controls.Add(this.l_afk);
            this.Controls.Add(this.l_stat);
            this.Controls.Add(this.t_men);
            this.Controls.Add(this.t_afk);
            this.Controls.Add(this.t_stat);
            this.Controls.Add(this.cb_men);
            this.Controls.Add(this.cb_afk);
            this.Controls.Add(this.cb_stat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_stat;
        private System.Windows.Forms.CheckBox cb_afk;
        private System.Windows.Forms.CheckBox cb_men;
        private System.Windows.Forms.TextBox t_stat;
        private System.Windows.Forms.TextBox t_afk;
        private System.Windows.Forms.TextBox t_men;
        private System.Windows.Forms.Label l_stat;
        private System.Windows.Forms.Label l_afk;
        private System.Windows.Forms.Label l_men;
        private System.Windows.Forms.Button b_upd;
        private System.Windows.Forms.Button b_logout;
    }
}