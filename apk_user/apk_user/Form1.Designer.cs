namespace apk_user
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
            this.searchbtn = new System.Windows.Forms.Button();
            this.mojelotybtn = new System.Windows.Forms.Button();
            this.mojedanebtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logindisplay = new System.Windows.Forms.Label();
            this.wyszlotow1 = new apk_user.wyszlotow();
            this.zabukowaneuser1 = new apk_user.zabukowaneuser();
            this.daneuser2 = new apk_user.daneuser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(2, 132);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(159, 56);
            this.searchbtn.TabIndex = 1;
            this.searchbtn.Text = "Wyszukiwarka";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // mojelotybtn
            // 
            this.mojelotybtn.Location = new System.Drawing.Point(0, 193);
            this.mojelotybtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mojelotybtn.Name = "mojelotybtn";
            this.mojelotybtn.Size = new System.Drawing.Size(159, 50);
            this.mojelotybtn.TabIndex = 2;
            this.mojelotybtn.Text = "Zabukowane";
            this.mojelotybtn.UseVisualStyleBackColor = true;
            this.mojelotybtn.Click += new System.EventHandler(this.mojelotybtn_Click);
            // 
            // mojedanebtn
            // 
            this.mojedanebtn.Location = new System.Drawing.Point(2, 248);
            this.mojedanebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mojedanebtn.Name = "mojedanebtn";
            this.mojedanebtn.Size = new System.Drawing.Size(159, 51);
            this.mojedanebtn.TabIndex = 3;
            this.mojedanebtn.Text = "Moje Dane";
            this.mojedanebtn.UseVisualStyleBackColor = true;
            this.mojedanebtn.Click += new System.EventHandler(this.mojedanebtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logindisplay);
            this.panel1.Controls.Add(this.mojelotybtn);
            this.panel1.Controls.Add(this.mojedanebtn);
            this.panel1.Controls.Add(this.searchbtn);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 346);
            this.panel1.TabIndex = 4;
            // 
            // logindisplay
            // 
            this.logindisplay.AutoSize = true;
            this.logindisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logindisplay.Location = new System.Drawing.Point(2, 11);
            this.logindisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logindisplay.Name = "logindisplay";
            this.logindisplay.Size = new System.Drawing.Size(79, 29);
            this.logindisplay.TabIndex = 4;
            this.logindisplay.Text = "label1";
            this.logindisplay.Click += new System.EventHandler(this.logindisplay_Click);
            // 
            // wyszlotow1
            // 
            this.wyszlotow1.Location = new System.Drawing.Point(175, 9);
            this.wyszlotow1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wyszlotow1.Name = "wyszlotow1";
            this.wyszlotow1.Size = new System.Drawing.Size(598, 365);
            this.wyszlotow1.TabIndex = 5;
            // 
            // zabukowaneuser1
            // 
            this.zabukowaneuser1.Location = new System.Drawing.Point(177, 10);
            this.zabukowaneuser1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zabukowaneuser1.Name = "zabukowaneuser1";
            this.zabukowaneuser1.Size = new System.Drawing.Size(596, 364);
            this.zabukowaneuser1.TabIndex = 6;
            this.zabukowaneuser1.Load += new System.EventHandler(this.zabukowaneuser1_Load);
            // 
            // daneuser2
            // 
            this.daneuser2.Location = new System.Drawing.Point(178, 9);
            this.daneuser2.Name = "daneuser2";
            this.daneuser2.Size = new System.Drawing.Size(592, 347);
            this.daneuser2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 384);
            this.Controls.Add(this.daneuser2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.wyszlotow1);
            this.Controls.Add(this.zabukowaneuser1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button mojelotybtn;
        private System.Windows.Forms.Button mojedanebtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label logindisplay;
        private wyszlotow wyszlotow1;
        private zabukowaneuser zabukowaneuser1;
        private daneuser daneuser1;
        private daneuser daneuser2;
    }
}

