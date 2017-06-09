namespace TorHazahav
{
    partial class Form1
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
            this.strId = new System.Windows.Forms.TextBox();
            this.strFName = new System.Windows.Forms.TextBox();
            this.strLName = new System.Windows.Forms.TextBox();
            this.checkFemale = new System.Windows.Forms.RadioButton();
            this.checkMale = new System.Windows.Forms.RadioButton();
            this.dateofBirth = new System.Windows.Forms.DateTimePicker();
            this.phoneNumH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.emailAdd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.maritalStatus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cityName = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.neighbName = new System.Windows.Forms.ComboBox();
            this.streetName = new System.Windows.Forms.TextBox();
            this.houseNum = new System.Windows.Forms.TextBox();
            this.apartNum = new System.Windows.Forms.TextBox();
            this.postCode = new System.Windows.Forms.TextBox();
            this.phoneNumM = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.areaCodeH = new System.Windows.Forms.ComboBox();
            this.areaCodeM = new System.Windows.Forms.ComboBox();
            this.strComments = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // strId
            // 
            this.strId.Location = new System.Drawing.Point(598, 174);
            this.strId.Name = "strId";
            this.strId.Size = new System.Drawing.Size(100, 20);
            this.strId.TabIndex = 0;
            // 
            // strFName
            // 
            this.strFName.Location = new System.Drawing.Point(598, 200);
            this.strFName.Name = "strFName";
            this.strFName.Size = new System.Drawing.Size(100, 20);
            this.strFName.TabIndex = 1;
            // 
            // strLName
            // 
            this.strLName.Location = new System.Drawing.Point(598, 233);
            this.strLName.Name = "strLName";
            this.strLName.Size = new System.Drawing.Size(100, 20);
            this.strLName.TabIndex = 2;
            // 
            // checkFemale
            // 
            this.checkFemale.AutoSize = true;
            this.checkFemale.Location = new System.Drawing.Point(350, 172);
            this.checkFemale.Name = "checkFemale";
            this.checkFemale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkFemale.Size = new System.Drawing.Size(51, 17);
            this.checkFemale.TabIndex = 3;
            this.checkFemale.TabStop = true;
            this.checkFemale.Text = "נקבה";
            this.checkFemale.UseVisualStyleBackColor = true;
            // 
            // checkMale
            // 
            this.checkMale.AutoSize = true;
            this.checkMale.Location = new System.Drawing.Point(407, 172);
            this.checkMale.Name = "checkMale";
            this.checkMale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkMale.Size = new System.Drawing.Size(43, 17);
            this.checkMale.TabIndex = 4;
            this.checkMale.TabStop = true;
            this.checkMale.Text = "זכר";
            this.checkMale.UseVisualStyleBackColor = true;
            // 
            // dateofBirth
            // 
            this.dateofBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateofBirth.Location = new System.Drawing.Point(350, 233);
            this.dateofBirth.Name = "dateofBirth";
            this.dateofBirth.Size = new System.Drawing.Size(98, 20);
            this.dateofBirth.TabIndex = 5;
            // 
            // phoneNumH
            // 
            this.phoneNumH.Location = new System.Drawing.Point(541, 298);
            this.phoneNumH.MaxLength = 8;
            this.phoneNumH.Name = "phoneNumH";
            this.phoneNumH.Size = new System.Drawing.Size(137, 20);
            this.phoneNumH.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(721, 207);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "שם פרטי:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(709, 239);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "שם משפחה:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(750, 177);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ת.ז:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 174);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "מין:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 240);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "תאריך לידה:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(690, 386);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "דואר אלקטרוני:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 299);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "עיר:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(709, 300);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "טלפון בבית:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(713, 345);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "טלפון נייד:";
            // 
            // emailAdd
            // 
            this.emailAdd.Location = new System.Drawing.Point(474, 382);
            this.emailAdd.Name = "emailAdd";
            this.emailAdd.Size = new System.Drawing.Size(204, 20);
            this.emailAdd.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(458, 208);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "מצב משפחתי:";
            // 
            // maritalStatus
            // 
            this.maritalStatus.FormattingEnabled = true;
            this.maritalStatus.Items.AddRange(new object[] {
            "רווק/ה",
            "נשוי/ה",
            "אלמן/ה",
            "גרוש/ה"});
            this.maritalStatus.Location = new System.Drawing.Point(327, 200);
            this.maritalStatus.Name = "maritalStatus";
            this.maritalStatus.Size = new System.Drawing.Size(121, 21);
            this.maritalStatus.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.Location = new System.Drawing.Point(685, 131);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(98, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "פרטים אישיים";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.Location = new System.Drawing.Point(675, 97);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(133, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "הוספת מקבל שירות";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(231, 90);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 23;
            this.saveButton.Text = "שמור";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(150, 90);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 24;
            this.cancelButton.Text = "ביטול";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.Location = new System.Drawing.Point(675, 268);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(104, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "פרטי התקשרות";
            // 
            // cityName
            // 
            this.cityName.FormattingEnabled = true;
            this.cityName.Items.AddRange(new object[] {
            "רמת השרון"});
            this.cityName.Location = new System.Drawing.Point(231, 295);
            this.cityName.Name = "cityName";
            this.cityName.Size = new System.Drawing.Size(121, 21);
            this.cityName.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(172, 296);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "שכונה:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(378, 347);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "רחוב:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(365, 386);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "מס\' בית:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(231, 389);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "דירה:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(106, 351);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "מיקוד:";
            // 
            // neighbName
            // 
            this.neighbName.FormattingEnabled = true;
            this.neighbName.Items.AddRange(new object[] {
            "אלון",
            "הדר",
            "מורשה",
            "נווה גן",
            "נווה מגן"});
            this.neighbName.Location = new System.Drawing.Point(38, 294);
            this.neighbName.Name = "neighbName";
            this.neighbName.Size = new System.Drawing.Size(121, 21);
            this.neighbName.TabIndex = 32;
            // 
            // streetName
            // 
            this.streetName.Location = new System.Drawing.Point(172, 344);
            this.streetName.Name = "streetName";
            this.streetName.Size = new System.Drawing.Size(180, 20);
            this.streetName.TabIndex = 33;
            // 
            // houseNum
            // 
            this.houseNum.Location = new System.Drawing.Point(299, 383);
            this.houseNum.Name = "houseNum";
            this.houseNum.Size = new System.Drawing.Size(53, 20);
            this.houseNum.TabIndex = 34;
            // 
            // apartNum
            // 
            this.apartNum.Location = new System.Drawing.Point(172, 382);
            this.apartNum.Name = "apartNum";
            this.apartNum.Size = new System.Drawing.Size(53, 20);
            this.apartNum.TabIndex = 35;
            // 
            // postCode
            // 
            this.postCode.Location = new System.Drawing.Point(38, 344);
            this.postCode.MaxLength = 8;
            this.postCode.Name = "postCode";
            this.postCode.Size = new System.Drawing.Size(62, 20);
            this.postCode.TabIndex = 36;
            // 
            // phoneNumM
            // 
            this.phoneNumM.Location = new System.Drawing.Point(541, 344);
            this.phoneNumM.MaxLength = 8;
            this.phoneNumM.Name = "phoneNumM";
            this.phoneNumM.Size = new System.Drawing.Size(137, 20);
            this.phoneNumM.TabIndex = 37;
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(69, 90);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 38;
            this.nextButton.Text = "הבא";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // areaCodeH
            // 
            this.areaCodeH.FormattingEnabled = true;
            this.areaCodeH.Items.AddRange(new object[] {
            "03",
            "071",
            "072",
            "073",
            "074",
            "075",
            "076",
            "077",
            "078",
            "079",
            "",
            "",
            ""});
            this.areaCodeH.Location = new System.Drawing.Point(476, 298);
            this.areaCodeH.Name = "areaCodeH";
            this.areaCodeH.Size = new System.Drawing.Size(53, 21);
            this.areaCodeH.TabIndex = 39;
            // 
            // areaCodeM
            // 
            this.areaCodeM.FormattingEnabled = true;
            this.areaCodeM.Items.AddRange(new object[] {
            "050",
            "051",
            "052",
            "053",
            "054",
            "055",
            "056",
            "058"});
            this.areaCodeM.Location = new System.Drawing.Point(476, 343);
            this.areaCodeM.Name = "areaCodeM";
            this.areaCodeM.Size = new System.Drawing.Size(53, 21);
            this.areaCodeM.TabIndex = 40;
            // 
            // strComments
            // 
            this.strComments.Location = new System.Drawing.Point(474, 457);
            this.strComments.Name = "strComments";
            this.strComments.Size = new System.Drawing.Size(200, 20);
            this.strComments.TabIndex = 41;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(737, 464);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label19.Size = new System.Drawing.Size(42, 13);
            this.label19.TabIndex = 42;
            this.label19.Text = "הערות:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(385, 61);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 13);
            this.label20.TabIndex = 43;
            this.label20.Text = "שירן שירן";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.strComments);
            this.Controls.Add(this.areaCodeM);
            this.Controls.Add(this.areaCodeH);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.phoneNumM);
            this.Controls.Add(this.postCode);
            this.Controls.Add(this.apartNum);
            this.Controls.Add(this.houseNum);
            this.Controls.Add(this.streetName);
            this.Controls.Add(this.neighbName);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cityName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.maritalStatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.emailAdd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneNumH);
            this.Controls.Add(this.dateofBirth);
            this.Controls.Add(this.checkMale);
            this.Controls.Add(this.checkFemale);
            this.Controls.Add(this.strLName);
            this.Controls.Add(this.strFName);
            this.Controls.Add(this.strId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox strId;
        private System.Windows.Forms.TextBox strFName;
        private System.Windows.Forms.TextBox strLName;
        private System.Windows.Forms.RadioButton checkFemale;
        private System.Windows.Forms.RadioButton checkMale;
        private System.Windows.Forms.DateTimePicker dateofBirth;
        private System.Windows.Forms.TextBox phoneNumH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox emailAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox maritalStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cityName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox neighbName;
        private System.Windows.Forms.TextBox streetName;
        private System.Windows.Forms.TextBox houseNum;
        private System.Windows.Forms.TextBox apartNum;
        private System.Windows.Forms.TextBox postCode;
        private System.Windows.Forms.TextBox phoneNumM;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.ComboBox areaCodeH;
        private System.Windows.Forms.ComboBox areaCodeM;
        private System.Windows.Forms.TextBox strComments;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}

