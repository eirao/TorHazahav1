namespace TorHazahav
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.strUser = new System.Windows.Forms.TextBox();
            this.strPassword = new System.Windows.Forms.TextBox();
            this.enter_bttn = new System.Windows.Forms.Button();
            this.exit_bttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(157, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(559, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 81;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(570, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 32);
            this.label6.TabIndex = 82;
            this.label6.Text = "שם משתמש:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(628, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 32);
            this.label1.TabIndex = 83;
            this.label1.Text = "סיסמא:";
            // 
            // strUser
            // 
            this.strUser.Location = new System.Drawing.Point(383, 236);
            this.strUser.Name = "strUser";
            this.strUser.Size = new System.Drawing.Size(151, 20);
            this.strUser.TabIndex = 84;
            // 
            // strPassword
            // 
            this.strPassword.Location = new System.Drawing.Point(383, 304);
            this.strPassword.Name = "strPassword";
            this.strPassword.Size = new System.Drawing.Size(151, 20);
            this.strPassword.TabIndex = 85;
            // 
            // enter_bttn
            // 
            this.enter_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.enter_bttn.Location = new System.Drawing.Point(466, 370);
            this.enter_bttn.Name = "enter_bttn";
            this.enter_bttn.Size = new System.Drawing.Size(108, 34);
            this.enter_bttn.TabIndex = 86;
            this.enter_bttn.Text = "כניסה";
            this.enter_bttn.UseVisualStyleBackColor = true;
            this.enter_bttn.Click += new System.EventHandler(this.enter_bttn_Click);
            // 
            // exit_bttn
            // 
            this.exit_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.exit_bttn.Location = new System.Drawing.Point(335, 370);
            this.exit_bttn.Name = "exit_bttn";
            this.exit_bttn.Size = new System.Drawing.Size(108, 34);
            this.exit_bttn.TabIndex = 87;
            this.exit_bttn.Text = "יציאה";
            this.exit_bttn.UseVisualStyleBackColor = true;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.exit_bttn);
            this.Controls.Add(this.enter_bttn);
            this.Controls.Add(this.strPassword);
            this.Controls.Add(this.strUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Name = "LoginScreen";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "מסך כניסה";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox strUser;
        private System.Windows.Forms.TextBox strPassword;
        private System.Windows.Forms.Button enter_bttn;
        private System.Windows.Forms.Button exit_bttn;
    }
}