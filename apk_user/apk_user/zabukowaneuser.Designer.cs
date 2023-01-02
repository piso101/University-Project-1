namespace apk_user
{
    partial class zabukowaneuser
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.projektDataSet = new apk_user.projektDataSet();
            this.zabukowaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zabukowaneTableAdapter = new apk_user.projektDataSetTableAdapters.zabukowaneTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zabukowaneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 2);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(776, 431);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // projektDataSet
            // 
            this.projektDataSet.DataSetName = "projektDataSet";
            this.projektDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zabukowaneBindingSource
            // 
            this.zabukowaneBindingSource.DataMember = "zabukowane";
            this.zabukowaneBindingSource.DataSource = this.projektDataSet;
            // 
            // zabukowaneTableAdapter
            // 
            this.zabukowaneTableAdapter.ClearBeforeFill = true;
            // 
            // zabukowaneuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "zabukowaneuser";
            this.Size = new System.Drawing.Size(782, 435);
            this.Load += new System.EventHandler(this.zabukowaneuser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zabukowaneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private projektDataSet projektDataSet;
        private System.Windows.Forms.BindingSource zabukowaneBindingSource;
        private projektDataSetTableAdapters.zabukowaneTableAdapter zabukowaneTableAdapter;
    }
}
