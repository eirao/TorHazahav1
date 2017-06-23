namespace TorHazahav
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tOR_HAZAHAVDataSet3 = new TorHazahav.TOR_HAZAHAVDataSet3();
            this.findProgramsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.findProgramsListTableAdapter = new TorHazahav.TOR_HAZAHAVDataSet3TableAdapters.FindProgramsListTableAdapter();
            this.מספרתוכניתDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.שםתוכניתDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.סוגDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.תאריךהתחלהDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.תאריךסיוםDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.מתאםDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOR_HAZAHAVDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findProgramsListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.מספרתוכניתDataGridViewTextBoxColumn,
            this.שםתוכניתDataGridViewTextBoxColumn,
            this.סוגDataGridViewTextBoxColumn,
            this.תאריךהתחלהDataGridViewTextBoxColumn,
            this.תאריךסיוםDataGridViewTextBoxColumn,
            this.מתאםDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.findProgramsListBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(40, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 184);
            this.dataGridView1.TabIndex = 0;
            // 
            // tOR_HAZAHAVDataSet3
            // 
            this.tOR_HAZAHAVDataSet3.DataSetName = "TOR_HAZAHAVDataSet3";
            this.tOR_HAZAHAVDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // findProgramsListBindingSource
            // 
            this.findProgramsListBindingSource.DataMember = "FindProgramsList";
            this.findProgramsListBindingSource.DataSource = this.tOR_HAZAHAVDataSet3;
            // 
            // findProgramsListTableAdapter
            // 
            this.findProgramsListTableAdapter.ClearBeforeFill = true;
            // 
            // מספרתוכניתDataGridViewTextBoxColumn
            // 
            this.מספרתוכניתDataGridViewTextBoxColumn.DataPropertyName = "מספר תוכנית";
            this.מספרתוכניתDataGridViewTextBoxColumn.HeaderText = "מספר תוכנית";
            this.מספרתוכניתDataGridViewTextBoxColumn.Name = "מספרתוכניתDataGridViewTextBoxColumn";
            this.מספרתוכניתDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // שםתוכניתDataGridViewTextBoxColumn
            // 
            this.שםתוכניתDataGridViewTextBoxColumn.DataPropertyName = "שם תוכנית";
            this.שםתוכניתDataGridViewTextBoxColumn.HeaderText = "שם תוכנית";
            this.שםתוכניתDataGridViewTextBoxColumn.Name = "שםתוכניתDataGridViewTextBoxColumn";
            this.שםתוכניתDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // סוגDataGridViewTextBoxColumn
            // 
            this.סוגDataGridViewTextBoxColumn.DataPropertyName = "סוג";
            this.סוגDataGridViewTextBoxColumn.HeaderText = "סוג";
            this.סוגDataGridViewTextBoxColumn.Name = "סוגDataGridViewTextBoxColumn";
            this.סוגDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // תאריךהתחלהDataGridViewTextBoxColumn
            // 
            this.תאריךהתחלהDataGridViewTextBoxColumn.DataPropertyName = "תאריך התחלה";
            this.תאריךהתחלהDataGridViewTextBoxColumn.HeaderText = "תאריך התחלה";
            this.תאריךהתחלהDataGridViewTextBoxColumn.Name = "תאריךהתחלהDataGridViewTextBoxColumn";
            this.תאריךהתחלהDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // תאריךסיוםDataGridViewTextBoxColumn
            // 
            this.תאריךסיוםDataGridViewTextBoxColumn.DataPropertyName = "תאריך סיום";
            this.תאריךסיוםDataGridViewTextBoxColumn.HeaderText = "תאריך סיום";
            this.תאריךסיוםDataGridViewTextBoxColumn.Name = "תאריךסיוםDataGridViewTextBoxColumn";
            this.תאריךסיוםDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // מתאםDataGridViewTextBoxColumn
            // 
            this.מתאםDataGridViewTextBoxColumn.DataPropertyName = "מתאם";
            this.מתאםDataGridViewTextBoxColumn.HeaderText = "מתאם";
            this.מתאםDataGridViewTextBoxColumn.Name = "מתאםDataGridViewTextBoxColumn";
            this.מתאםDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 415);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOR_HAZAHAVDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findProgramsListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn מספרתוכניתDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn שםתוכניתDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn סוגDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn תאריךהתחלהDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn תאריךסיוםDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn מתאםDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource findProgramsListBindingSource;
        private TOR_HAZAHAVDataSet3 tOR_HAZAHAVDataSet3;
        private TOR_HAZAHAVDataSet3TableAdapters.FindProgramsListTableAdapter findProgramsListTableAdapter;
    }
}