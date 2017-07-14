namespace TorHazahav
{
    partial class NeedSpecialActivity
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qualificationfalse = new System.Windows.Forms.RadioButton();
            this.qualificationTrue = new System.Windows.Forms.RadioButton();
            this.entitledDiscountTl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.specialPName_str = new System.Windows.Forms.ComboBox();
            this.specialPDetails_str = new System.Windows.Forms.ComboBox();
            this.specialPType_str = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 27);
            this.button2.TabIndex = 118;
            this.button2.Text = "שמירה";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(62, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 27);
            this.button3.TabIndex = 117;
            this.button3.Text = "ביטול";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(317, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 98;
            this.label1.Text = "פירוט:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(328, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 97;
            this.label3.Text = "שם:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(101, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 96;
            this.label2.Text = "צורך בפעילות מתואמת";
            // 
            // qualificationfalse
            // 
            this.qualificationfalse.AutoSize = true;
            this.qualificationfalse.Location = new System.Drawing.Point(129, 194);
            this.qualificationfalse.Name = "qualificationfalse";
            this.qualificationfalse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.qualificationfalse.Size = new System.Drawing.Size(40, 17);
            this.qualificationfalse.TabIndex = 124;
            this.qualificationfalse.TabStop = true;
            this.qualificationfalse.Text = "לא";
            this.qualificationfalse.UseVisualStyleBackColor = true;
            // 
            // qualificationTrue
            // 
            this.qualificationTrue.AutoSize = true;
            this.qualificationTrue.Location = new System.Drawing.Point(186, 194);
            this.qualificationTrue.Name = "qualificationTrue";
            this.qualificationTrue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.qualificationTrue.Size = new System.Drawing.Size(37, 17);
            this.qualificationTrue.TabIndex = 123;
            this.qualificationTrue.TabStop = true;
            this.qualificationTrue.Text = "כן";
            this.qualificationTrue.UseVisualStyleBackColor = true;
            // 
            // entitledDiscountTl
            // 
            this.entitledDiscountTl.AutoSize = true;
            this.entitledDiscountTl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.entitledDiscountTl.Location = new System.Drawing.Point(251, 194);
            this.entitledDiscountTl.Name = "entitledDiscountTl";
            this.entitledDiscountTl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.entitledDiscountTl.Size = new System.Drawing.Size(107, 17);
            this.entitledDiscountTl.TabIndex = 122;
            this.entitledDiscountTl.Text = "כישורים מיוחדים:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(328, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 126;
            this.label4.Text = "סוג:";
            // 
            // specialPName_str
            // 
            this.specialPName_str.FormattingEnabled = true;
            this.specialPName_str.Items.AddRange(new object[] {
            "תוכנית בינדורית",
            "קבוצת תמיכה",
            "פעילויות פנאי",
            "תמיכה טכנולוגית",
            "התנדבות"});
            this.specialPName_str.Location = new System.Drawing.Point(101, 61);
            this.specialPName_str.Name = "specialPName_str";
            this.specialPName_str.Size = new System.Drawing.Size(180, 21);
            this.specialPName_str.TabIndex = 127;
            // 
            // specialPDetails_str
            // 
            this.specialPDetails_str.FormattingEnabled = true;
            this.specialPDetails_str.Items.AddRange(new object[] {
            "חוגים",
            "לימודים",
            "סמארטפון",
            "מחשב",
            "תחום",
            "הכשרה"});
            this.specialPDetails_str.Location = new System.Drawing.Point(101, 102);
            this.specialPDetails_str.Name = "specialPDetails_str";
            this.specialPDetails_str.Size = new System.Drawing.Size(180, 21);
            this.specialPDetails_str.TabIndex = 128;
            // 
            // specialPType_str
            // 
            this.specialPType_str.FormattingEnabled = true;
            this.specialPType_str.Items.AddRange(new object[] {
            "מרותקי בית",
            "פעילות חוץ"});
            this.specialPType_str.Location = new System.Drawing.Point(101, 145);
            this.specialPType_str.Name = "specialPType_str";
            this.specialPType_str.Size = new System.Drawing.Size(180, 21);
            this.specialPType_str.TabIndex = 129;
            // 
            // NeedSpecialActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 381);
            this.Controls.Add(this.specialPType_str);
            this.Controls.Add(this.specialPDetails_str);
            this.Controls.Add(this.specialPName_str);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.qualificationfalse);
            this.Controls.Add(this.qualificationTrue);
            this.Controls.Add(this.entitledDiscountTl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "NeedSpecialActivity";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "NeedSpecialActivity";
            this.Load += new System.EventHandler(this.NeedSpecialActivity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton qualificationfalse;
        private System.Windows.Forms.RadioButton qualificationTrue;
        private System.Windows.Forms.Label entitledDiscountTl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox specialPName_str;
        private System.Windows.Forms.ComboBox specialPDetails_str;
        private System.Windows.Forms.ComboBox specialPType_str;
    }
}