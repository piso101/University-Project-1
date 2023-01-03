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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cena_bag_box = new System.Windows.Forms.ComboBox();
            this.loadbtn = new System.Windows.Forms.Button();
            this.todate = new System.Windows.Forms.DateTimePicker();
            this.fromdate = new System.Windows.Forms.DateTimePicker();
            this.dokadbox = new System.Windows.Forms.ComboBox();
            this.skadbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Aqua;
            this.dataGridView1.Location = new System.Drawing.Point(2, 61);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Cyan;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(582, 288);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cena_bag_box);
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
            // cena_bag_box
            // 
            this.cena_bag_box.FormattingEnabled = true;
            this.cena_bag_box.Items.AddRange(new object[] {
            "Mały - 150zł",
            "Duży - 200zł"});
            this.cena_bag_box.Location = new System.Drawing.Point(403, 22);
            this.cena_bag_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cena_bag_box.Name = "cena_bag_box";
            this.cena_bag_box.Size = new System.Drawing.Size(109, 21);
            this.cena_bag_box.TabIndex = 6;
            // 
            // loadbtn
            // 
            this.loadbtn.Location = new System.Drawing.Point(311, 6);
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
            this.todate.Location = new System.Drawing.Point(198, 25);
            this.todate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(92, 20);
            this.todate.TabIndex = 3;
            this.todate.ValueChanged += new System.EventHandler(this.todate_ValueChanged);
            // 
            // fromdate
            // 
            this.fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromdate.Location = new System.Drawing.Point(198, 4);
            this.fromdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fromdate.Name = "fromdate";
            this.fromdate.Size = new System.Drawing.Size(92, 20);
            this.fromdate.TabIndex = 2;
            this.fromdate.ValueChanged += new System.EventHandler(this.fromdate_ValueChanged);
            // 
            // dokadbox
            // 
            this.dokadbox.FormattingEnabled = true;
            this.dokadbox.Location = new System.Drawing.Point(73, 27);
            this.dokadbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dokadbox.Name = "dokadbox";
            this.dokadbox.Size = new System.Drawing.Size(109, 21);
            this.dokadbox.TabIndex = 1;
            this.dokadbox.SelectedIndexChanged += new System.EventHandler(this.dokadbox_SelectedIndexChanged);
            // 
            // skadbox
            // 
            this.skadbox.FormattingEnabled = true;
            this.skadbox.Location = new System.Drawing.Point(73, 2);
            this.skadbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.skadbox.Name = "skadbox";
            this.skadbox.Size = new System.Drawing.Size(109, 21);
            this.skadbox.TabIndex = 0;
            this.skadbox.SelectedIndexChanged += new System.EventHandler(this.skadbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Wybierz bagaż:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Skąd: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dokąd:";
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
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ComboBox cena_bag_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
