namespace TorHazahav
{
    partial class VolunteersList
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
            this.tOR_HAZAHAVDataSet = new TorHazahav.TOR_HAZAHAVDataSet();
            this.tORHAZAHAVDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.volunteerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tOR_HAZAHAVDataSet4 = new TorHazahav.TOR_HAZAHAVDataSet4();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.volunteerTableAdapter = new TorHazahav.TOR_HAZAHAVDataSet4TableAdapters.volunteerTableAdapter();
            this.enddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tOR_HAZAHAVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tORHAZAHAVDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volunteerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOR_HAZAHAVDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // tOR_HAZAHAVDataSet
            // 
            this.tOR_HAZAHAVDataSet.DataSetName = "TOR_HAZAHAVDataSet";
            this.tOR_HAZAHAVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tORHAZAHAVDataSetBindingSource
            // 
            this.tORHAZAHAVDataSetBindingSource.DataSource = this.tOR_HAZAHAVDataSet;
            this.tORHAZAHAVDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enddateDataGridViewTextBoxColumn,
            this.startdateDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.volunteerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(53, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // volunteerBindingSource
            // 
            this.volunteerBindingSource.DataMember = "volunteer";
            this.volunteerBindingSource.DataSource = this.tOR_HAZAHAVDataSet4;
            // 
            // tOR_HAZAHAVDataSet4
            // 
            this.tOR_HAZAHAVDataSet4.DataSetName = "TOR_HAZAHAVDataSet4";
            this.tOR_HAZAHAVDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(714, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // volunteerTableAdapter
            // 
            this.volunteerTableAdapter.ClearBeforeFill = true;
            // 
            // enddateDataGridViewTextBoxColumn
            // 
            this.enddateDataGridViewTextBoxColumn.DataPropertyName = "end_date";
            this.enddateDataGridViewTextBoxColumn.HeaderText = "תאריך סיום התנדבות";
            this.enddateDataGridViewTextBoxColumn.Name = "enddateDataGridViewTextBoxColumn";
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "start_date";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "תאירך תחילת התנדבות";
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "שם משפחה";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "שם פרטי";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "מספר מתנדב";
            this.iDDataGridViewTextBoxColumn.HeaderText = "מספר מתנדב";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // VolunteersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 261);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VolunteersList";
            this.Text = "VolunteersList";
            this.Load += new System.EventHandler(this.VolunteersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tOR_HAZAHAVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tORHAZAHAVDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volunteerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOR_HAZAHAVDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TOR_HAZAHAVDataSet tOR_HAZAHAVDataSet;
        private System.Windows.Forms.BindingSource tORHAZAHAVDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TOR_HAZAHAVDataSet4 tOR_HAZAHAVDataSet4;
        private System.Windows.Forms.BindingSource volunteerBindingSource;
        private TOR_HAZAHAVDataSet4TableAdapters.volunteerTableAdapter volunteerTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    }
}