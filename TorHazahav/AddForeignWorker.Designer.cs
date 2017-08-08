namespace TorHazahav
{
    partial class AddForeignWorker
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
            this.strLName = new System.Windows.Forms.TextBox();
            this.strFName = new System.Windows.Forms.TextBox();
            this.areaCodeM = new System.Windows.Forms.ComboBox();
            this.phoneNumM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cityName = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.streetName = new System.Windows.Forms.TextBox();
            this.houseNum = new System.Windows.Forms.TextBox();
            this.apartNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 27);
            this.button2.TabIndex = 95;
            this.button2.Text = "שמירה";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(37, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 27);
            this.button3.TabIndex = 94;
            this.button3.Text = "ביטול";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // strLName
            // 
            this.strLName.Location = new System.Drawing.Point(37, 94);
            this.strLName.Multiline = true;
            this.strLName.Name = "strLName";
            this.strLName.Size = new System.Drawing.Size(230, 20);
            this.strLName.TabIndex = 81;
            // 
            // strFName
            // 
            this.strFName.Location = new System.Drawing.Point(37, 58);
            this.strFName.Name = "strFName";
            this.strFName.Size = new System.Drawing.Size(230, 20);
            this.strFName.TabIndex = 80;
            // 
            // areaCodeM
            // 
            this.areaCodeM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.areaCodeM.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.areaCodeM.FormattingEnabled = true;
            this.areaCodeM.ItemHeight = 14;
            this.areaCodeM.Items.AddRange(new object[] {
            "050",
            "051",
            "052",
            "053",
            "054",
            "055",
            "056",
            "058"});
            this.areaCodeM.Location = new System.Drawing.Point(103, 126);
            this.areaCodeM.Name = "areaCodeM";
            this.areaCodeM.Size = new System.Drawing.Size(53, 20);
            this.areaCodeM.TabIndex = 79;
            // 
            // phoneNumM
            // 
            this.phoneNumM.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.phoneNumM.Location = new System.Drawing.Point(162, 126);
            this.phoneNumM.MaxLength = 8;
            this.phoneNumM.Multiline = true;
            this.phoneNumM.Name = "phoneNumM";
            this.phoneNumM.Size = new System.Drawing.Size(105, 20);
            this.phoneNumM.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(285, 126);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 76;
            this.label9.Text = "טלפון נייד:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(273, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 73;
            this.label1.Text = "שם משפחה:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(290, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 72;
            this.label3.Text = "שם פרטי:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(139, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 71;
            this.label2.Text = "הוספת עובד זר";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(323, 159);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 82;
            this.label7.Text = "עיר:";
            // 
            // cityName
            // 
            this.cityName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cityName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cityName.FormattingEnabled = true;
            this.cityName.ItemHeight = 14;
            this.cityName.Items.AddRange(new object[] {
            "רמת השרון"});
            this.cityName.Location = new System.Drawing.Point(37, 156);
            this.cityName.Name = "cityName";
            this.cityName.Size = new System.Drawing.Size(230, 20);
            this.cityName.TabIndex = 83;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(314, 194);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(39, 17);
            this.label15.TabIndex = 85;
            this.label15.Text = "רחוב:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(295, 228);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label16.Size = new System.Drawing.Size(58, 17);
            this.label16.TabIndex = 86;
            this.label16.Text = "מס\' בית:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(103, 228);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label17.Size = new System.Drawing.Size(38, 17);
            this.label17.TabIndex = 87;
            this.label17.Text = "דירה:";
            // 
            // streetName
            // 
            this.streetName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.streetName.Location = new System.Drawing.Point(37, 191);
            this.streetName.Multiline = true;
            this.streetName.Name = "streetName";
            this.streetName.Size = new System.Drawing.Size(230, 20);
            this.streetName.TabIndex = 90;
            // 
            // houseNum
            // 
            this.houseNum.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.houseNum.Location = new System.Drawing.Point(214, 225);
            this.houseNum.Multiline = true;
            this.houseNum.Name = "houseNum";
            this.houseNum.Size = new System.Drawing.Size(53, 20);
            this.houseNum.TabIndex = 91;
            // 
            // apartNum
            // 
            this.apartNum.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.apartNum.Location = new System.Drawing.Point(37, 225);
            this.apartNum.Multiline = true;
            this.apartNum.Name = "apartNum";
            this.apartNum.Size = new System.Drawing.Size(53, 20);
            this.apartNum.TabIndex = 92;
            // 
            // AddForeignWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 381);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.apartNum);
            this.Controls.Add(this.houseNum);
            this.Controls.Add(this.streetName);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cityName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.strLName);
            this.Controls.Add(this.strFName);
            this.Controls.Add(this.areaCodeM);
            this.Controls.Add(this.phoneNumM);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddForeignWorker";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "AddForeignWorker";
            this.Load += new System.EventHandler(this.AddForeignWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox strLName;
        private System.Windows.Forms.TextBox strFName;
        private System.Windows.Forms.ComboBox areaCodeM;
        private System.Windows.Forms.TextBox phoneNumM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cityName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox streetName;
        private System.Windows.Forms.TextBox houseNum;
        private System.Windows.Forms.TextBox apartNum;
    }
}