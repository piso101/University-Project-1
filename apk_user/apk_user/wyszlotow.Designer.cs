namespace apk_user
{
    partial class wyszlotow
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.loadbtn = new System.Windows.Forms.Button();
            this.todate = new System.Windows.Forms.DateTimePicker();
            this.fromdate = new System.Windows.Forms.DateTimePicker();
            this.dokadbox = new System.Windows.Forms.ComboBox();
            this.skadbox = new System.Windows.Forms.ComboBox();
            this.cena_bag_box = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 61);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(582, 288);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cena_bag_box);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.loadbtn);
            this.panel1.Controls.Add(this.todate);
            this.panel1.Controls.Add(this.fromdate);
            this.panel1.Controls.Add(this.dokadbox);
            this.panel1.Controls.Add(this.skadbox);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 54);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Zabukuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loadbtn
            // 
            this.loadbtn.Location = new System.Drawing.Point(262, 6);
            this.loadbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(72, 37);
            this.loadbtn.TabIndex = 4;
            this.loadbtn.Text = "Wyszukaj";
            this.loadbtn.UseVisualStyleBackColor = true;
            this.loadbtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // todate
            // 
            this.todate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.todate.Location = new System.Drawing.Point(153, 25);
            this.todate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(92, 20);
            this.todate.TabIndex = 3;
            this.todate.ValueChanged += new System.EventHandler(this.todate_ValueChanged);
            // 
            // fromdate
            // 
            this.fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromdate.Location = new System.Drawing.Point(153, 4);
            this.fromdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fromdate.Name = "fromdate";
            this.fromdate.Size = new System.Drawing.Size(92, 20);
            this.fromdate.TabIndex = 2;
            // 
            // dokadbox
            // 
            this.dokadbox.FormattingEnabled = true;
            this.dokadbox.Location = new System.Drawing.Point(28, 27);
            this.dokadbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dokadbox.Name = "dokadbox";
            this.dokadbox.Size = new System.Drawing.Size(109, 21);
            this.dokadbox.TabIndex = 1;
            // 
            // skadbox
            // 
            this.skadbox.FormattingEnabled = true;
            this.skadbox.Location = new System.Drawing.Point(28, 2);
            this.skadbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.skadbox.Name = "skadbox";
            this.skadbox.Size = new System.Drawing.Size(109, 21);
            this.skadbox.TabIndex = 0;
            // 
            // cena_bag_box
            // 
            this.cena_bag_box.FormattingEnabled = true;
            this.cena_bag_box.Items.AddRange(new object[] {
            "Mały - 150zł",
            "Duży - 200zł"});
            this.cena_bag_box.Location = new System.Drawing.Point(443, 22);
            this.cena_bag_box.Margin = new System.Windows.Forms.Padding(2);
            this.cena_bag_box.Name = "cena_bag_box";
            this.cena_bag_box.Size = new System.Drawing.Size(109, 21);
            this.cena_bag_box.TabIndex = 6;
            // 
            // wyszlotow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "wyszlotow";
            this.Size = new System.Drawing.Size(586, 353);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loadbtn;
        private System.Windows.Forms.DateTimePicker todate;
        private System.Windows.Forms.DateTimePicker fromdate;
        private System.Windows.Forms.ComboBox dokadbox;
        private System.Windows.Forms.ComboBox skadbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cena_bag_box;
    }
}
