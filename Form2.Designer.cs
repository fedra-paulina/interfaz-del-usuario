namespace interfaz_del_usuario
{
    partial class Form2
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
            this.REGISTERBTN = new System.Windows.Forms.Button();
            this.userTxtBox = new System.Windows.Forms.TextBox();
            this.pswTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.USER = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // REGISTERBTN
            // 
            this.REGISTERBTN.Location = new System.Drawing.Point(325, 276);
            this.REGISTERBTN.Name = "REGISTERBTN";
            this.REGISTERBTN.Size = new System.Drawing.Size(128, 59);
            this.REGISTERBTN.TabIndex = 11;
            this.REGISTERBTN.Text = "REGISTER";
            this.REGISTERBTN.UseVisualStyleBackColor = true;
            // 
            // userTxtBox
            // 
            this.userTxtBox.Location = new System.Drawing.Point(278, 55);
            this.userTxtBox.Name = "userTxtBox";
            this.userTxtBox.Size = new System.Drawing.Size(228, 20);
            this.userTxtBox.TabIndex = 9;
            // 
            // pswTxtBox
            // 
            this.pswTxtBox.Location = new System.Drawing.Point(278, 138);
            this.pswTxtBox.Name = "pswTxtBox";
            this.pswTxtBox.Size = new System.Drawing.Size(227, 20);
            this.pswTxtBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "PASSWORD";
            // 
            // USER
            // 
            this.USER.AutoSize = true;
            this.USER.Location = new System.Drawing.Point(366, 25);
            this.USER.Name = "USER";
            this.USER.Size = new System.Drawing.Size(37, 13);
            this.USER.TabIndex = 6;
            this.USER.Text = "USER";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.REGISTERBTN);
            this.Controls.Add(this.userTxtBox);
            this.Controls.Add(this.pswTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.USER);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button REGISTERBTN;
        private System.Windows.Forms.TextBox userTxtBox;
        private System.Windows.Forms.TextBox pswTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label USER;
    }
}