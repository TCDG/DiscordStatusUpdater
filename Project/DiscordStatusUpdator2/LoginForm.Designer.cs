namespace DiscordStatusUpdator2
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.rb_user = new System.Windows.Forms.RadioButton();
            this.rb_bot = new System.Windows.Forms.RadioButton();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.l_email = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.l_pass = new System.Windows.Forms.Label();
            this.tb_token = new System.Windows.Forms.TextBox();
            this.l_token = new System.Windows.Forms.Label();
            this.b_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rb_user
            // 
            this.rb_user.AutoSize = true;
            this.rb_user.BackColor = System.Drawing.Color.Transparent;
            this.rb_user.Checked = true;
            this.rb_user.Location = new System.Drawing.Point(13, 13);
            this.rb_user.Name = "rb_user";
            this.rb_user.Size = new System.Drawing.Size(47, 17);
            this.rb_user.TabIndex = 0;
            this.rb_user.TabStop = true;
            this.rb_user.Text = "User";
            this.rb_user.UseVisualStyleBackColor = false;
            this.rb_user.CheckedChanged += new System.EventHandler(this.rb_user_CheckedChanged);
            // 
            // rb_bot
            // 
            this.rb_bot.AutoSize = true;
            this.rb_bot.BackColor = System.Drawing.Color.Transparent;
            this.rb_bot.Location = new System.Drawing.Point(13, 37);
            this.rb_bot.Name = "rb_bot";
            this.rb_bot.Size = new System.Drawing.Size(41, 17);
            this.rb_bot.TabIndex = 1;
            this.rb_bot.Text = "Bot";
            this.rb_bot.UseVisualStyleBackColor = false;
            this.rb_bot.CheckedChanged += new System.EventHandler(this.rb_bot_CheckedChanged);
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(119, 10);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(214, 20);
            this.tb_user.TabIndex = 2;
            // 
            // l_email
            // 
            this.l_email.AutoSize = true;
            this.l_email.BackColor = System.Drawing.Color.Transparent;
            this.l_email.Location = new System.Drawing.Point(73, 13);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(35, 13);
            this.l_email.TabIndex = 3;
            this.l_email.Text = "Email:";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(119, 37);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(214, 20);
            this.tb_pass.TabIndex = 4;
            // 
            // l_pass
            // 
            this.l_pass.AutoSize = true;
            this.l_pass.BackColor = System.Drawing.Color.Transparent;
            this.l_pass.Location = new System.Drawing.Point(73, 40);
            this.l_pass.Name = "l_pass";
            this.l_pass.Size = new System.Drawing.Size(33, 13);
            this.l_pass.TabIndex = 5;
            this.l_pass.Text = "Pass:";
            // 
            // tb_token
            // 
            this.tb_token.Location = new System.Drawing.Point(119, 63);
            this.tb_token.Name = "tb_token";
            this.tb_token.Size = new System.Drawing.Size(214, 20);
            this.tb_token.TabIndex = 6;
            // 
            // l_token
            // 
            this.l_token.AutoSize = true;
            this.l_token.BackColor = System.Drawing.Color.Transparent;
            this.l_token.Location = new System.Drawing.Point(73, 66);
            this.l_token.Name = "l_token";
            this.l_token.Size = new System.Drawing.Size(41, 13);
            this.l_token.TabIndex = 7;
            this.l_token.Text = "Token:";
            // 
            // b_login
            // 
            this.b_login.Location = new System.Drawing.Point(238, 89);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(95, 23);
            this.b_login.TabIndex = 8;
            this.b_login.Text = "Login";
            this.b_login.UseVisualStyleBackColor = true;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(345, 117);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.l_token);
            this.Controls.Add(this.tb_token);
            this.Controls.Add(this.l_pass);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.l_email);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.rb_bot);
            this.Controls.Add(this.rb_user);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton rb_user;
        public System.Windows.Forms.RadioButton rb_bot;
        public System.Windows.Forms.TextBox tb_user;
        public System.Windows.Forms.Label l_email;
        public System.Windows.Forms.TextBox tb_pass;
        public System.Windows.Forms.Label l_pass;
        public System.Windows.Forms.TextBox tb_token;
        public System.Windows.Forms.Label l_token;
        public System.Windows.Forms.Button b_login;
    }
}