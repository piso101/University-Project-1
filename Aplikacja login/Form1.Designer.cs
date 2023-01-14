namespace login
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Registeruser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progresladowania = new System.Windows.Forms.ProgressBar();
            this.userapk1 = new login.userapk();
            this.register_ui = new login.register_ui();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // password
            // 
            resources.ApplyResources(this.password, "password");
            this.password.Name = "password";
            this.password.UseSystemPasswordChar = true;
            this.password.MouseLeave += new System.EventHandler(this.password_MouseLeave);
            this.password.MouseHover += new System.EventHandler(this.password_MouseHover);
            // 
            // login
            // 
            resources.ApplyResources(this.login, "login");
            this.login.Name = "login";
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // check
            // 
            resources.ApplyResources(this.check, "check");
            this.check.Name = "check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Registeruser
            // 
            resources.ApplyResources(this.Registeruser, "Registeruser");
            this.Registeruser.Name = "Registeruser";
            this.Registeruser.UseVisualStyleBackColor = true;
            this.Registeruser.Click += new System.EventHandler(this.registeruser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.progresladowania);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.Registeruser);
            this.panel1.Controls.Add(this.check);
            this.panel1.ForeColor = System.Drawing.SystemColors.Desktop;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // progresladowania
            // 
            this.progresladowania.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.progresladowania, "progresladowania");
            this.progresladowania.MarqueeAnimationSpeed = 100000;
            this.progresladowania.Name = "progresladowania";
            this.progresladowania.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progresladowania.UseWaitCursor = true;
            // 
            // userapk1
            // 
            resources.ApplyResources(this.userapk1, "userapk1");
            this.userapk1.Name = "userapk1";
            this.userapk1.Load += new System.EventHandler(this.userapk1_Load);
            // 
            // register_ui
            // 
            this.register_ui.BackColor = System.Drawing.Color.LightBlue;
            resources.ApplyResources(this.register_ui, "register_ui");
            this.register_ui.Name = "register_ui";
            this.register_ui.Load += new System.EventHandler(this.register_ui_Load);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.userapk1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.register_ui);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Registeruser;
        private register_ui register_ui;
        private userapk userapk1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progresladowania;
    }
}

