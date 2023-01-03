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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cena_bag_box = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.loadbtn = new System.Windows.Forms.Button();
            this.todate = new System.Windows.Forms.DateTimePicker();
            this.fromdate = new System.Windows.Forms.DateTimePicker();
            this.dokadbox = new System.Windows.Forms.ComboBox();
            this.skadbox = new System.Windows.Forms.ComboBox();
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Cyan;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 354);
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
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 66);
            this.panel1.TabIndex = 2;
            // 
            // cena_bag_box
            // 
            this.cena_bag_box.FormattingEnabled = true;
            this.cena_bag_box.Items.AddRange(new object[] {
            "Mały - 150zł",
            "Duży - 200zł"});
            this.cena_bag_box.Location = new System.Drawing.Point(591, 19);
            this.cena_bag_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cena_bag_box.Name = "cena_bag_box";
            this.cena_bag_box.Size = new System.Drawing.Size(144, 24);
            this.cena_bag_box.TabIndex = 6;
            this.cena_bag_box.SelectedIndexChanged += new System.EventHandler(this.cena_bag_box_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Zabukuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loadbtn
            // 
            this.loadbtn.Location = new System.Drawing.Point(349, 7);
            this.loadbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(96, 46);
            this.loadbtn.TabIndex = 4;
            this.loadbtn.Text = "Wyszukaj";
            this.loadbtn.UseVisualStyleBackColor = true;
            this.loadbtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // todate
            // 
            this.todate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.todate.Location = new System.Drawing.Point(204, 31);
            this.todate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(121, 22);
            this.todate.TabIndex = 3;
            this.todate.ValueChanged += new System.EventHandler(this.todate_ValueChanged);
            // 
            // fromdate
            // 
            this.fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromdate.Location = new System.Drawing.Point(204, 5);
            this.fromdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fromdate.Name = "fromdate";
            this.fromdate.Size = new System.Drawing.Size(121, 22);
            this.fromdate.TabIndex = 2;
            // 
            // dokadbox
            // 
            this.dokadbox.FormattingEnabled = true;
            this.dokadbox.Location = new System.Drawing.Point(37, 33);
            this.dokadbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dokadbox.Name = "dokadbox";
            this.dokadbox.Size = new System.Drawing.Size(144, 24);
            this.dokadbox.TabIndex = 1;
            // 
            // skadbox
            // 
            this.skadbox.FormattingEnabled = true;
            this.skadbox.Location = new System.Drawing.Point(37, 2);
            this.skadbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.skadbox.Name = "skadbox";
            this.skadbox.Size = new System.Drawing.Size(144, 24);
            this.skadbox.TabIndex = 0;
            // 
            // wyszlotow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "wyszlotow";
            this.Size = new System.Drawing.Size(781, 434);
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
