namespace apk.admin
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.zabukowanebtn = new System.Windows.Forms.Button();
            this.usersbtn = new System.Windows.Forms.Button();
            this.lotybtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lotyokno = new apk.admin.lotypoprawa2();
            this.usersokno = new apk.admin.usersokno();
            this.zabukowaneokno1 = new apk.admin.zabukowaneokno();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 556);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.zabukowanebtn);
            this.panel2.Controls.Add(this.usersbtn);
            this.panel2.Controls.Add(this.lotybtn);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 556);
            this.panel2.TabIndex = 6;
            // 
            // zabukowanebtn
            // 
            this.zabukowanebtn.BackColor = System.Drawing.Color.DarkCyan;
            this.zabukowanebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zabukowanebtn.Location = new System.Drawing.Point(12, 91);
            this.zabukowanebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zabukowanebtn.Name = "zabukowanebtn";
            this.zabukowanebtn.Size = new System.Drawing.Size(155, 34);
            this.zabukowanebtn.TabIndex = 4;
            this.zabukowanebtn.Text = "Zabukowane";
            this.zabukowanebtn.UseVisualStyleBackColor = false;
            this.zabukowanebtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // usersbtn
            // 
            this.usersbtn.BackColor = System.Drawing.Color.DarkCyan;
            this.usersbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usersbtn.Location = new System.Drawing.Point(12, 51);
            this.usersbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usersbtn.Name = "usersbtn";
            this.usersbtn.Size = new System.Drawing.Size(155, 34);
            this.usersbtn.TabIndex = 3;
            this.usersbtn.Text = "Użytkownicy";
            this.usersbtn.UseVisualStyleBackColor = false;
            this.usersbtn.Click += new System.EventHandler(this.usersbtn_Click);
            // 
            // lotybtn
            // 
            this.lotybtn.BackColor = System.Drawing.Color.DarkCyan;
            this.lotybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lotybtn.Location = new System.Drawing.Point(12, 11);
            this.lotybtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lotybtn.Name = "lotybtn";
            this.lotybtn.Size = new System.Drawing.Size(155, 34);
            this.lotybtn.TabIndex = 2;
            this.lotybtn.Text = "Loty";
            this.lotybtn.UseVisualStyleBackColor = false;
            this.lotybtn.Click += new System.EventHandler(this.lotybtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(527, 79);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(7, 6);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lotyokno
            // 
            this.lotyokno.AutoSize = true;
            this.lotyokno.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lotyokno.BackColor = System.Drawing.Color.Transparent;
            this.lotyokno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lotyokno.Location = new System.Drawing.Point(173, 0);
            this.lotyokno.Name = "lotyokno";
            this.lotyokno.Size = new System.Drawing.Size(1097, 558);
            this.lotyokno.TabIndex = 5;
            // 
            // usersokno
            // 
            this.usersokno.AutoSize = true;
            this.usersokno.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usersokno.BackColor = System.Drawing.Color.Transparent;
            this.usersokno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.usersokno.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.usersokno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usersokno.Location = new System.Drawing.Point(173, 0);
            this.usersokno.Margin = new System.Windows.Forms.Padding(0);
            this.usersokno.Name = "usersokno";
            this.usersokno.Size = new System.Drawing.Size(1062, 600);
            this.usersokno.TabIndex = 3;
            this.usersokno.Load += new System.EventHandler(this.usersokno_Load);
            // 
            // zabukowaneokno1
            // 
            this.zabukowaneokno1.AutoSize = true;
            this.zabukowaneokno1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.zabukowaneokno1.BackColor = System.Drawing.Color.Transparent;
            this.zabukowaneokno1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.zabukowaneokno1.Location = new System.Drawing.Point(173, 0);
            this.zabukowaneokno1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zabukowaneokno1.Name = "zabukowaneokno1";
            this.zabukowaneokno1.Size = new System.Drawing.Size(1060, 605);
            this.zabukowaneokno1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1235, 556);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lotyokno);
            this.Controls.Add(this.usersokno);
            this.Controls.Add(this.zabukowaneokno1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Apk.Admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button lotybtn;
        private System.Windows.Forms.Button usersbtn;
        private System.Windows.Forms.Button zabukowanebtn;
        private zabukowaneokno zabukowaneokno1;
        public usersokno usersokno;
        private System.Windows.Forms.Panel panel2;
        private lotypoprawa2 lotyokno;
    }
}

