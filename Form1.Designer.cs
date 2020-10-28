namespace interfaz_del_usuario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.USER = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pswTxtBox = new System.Windows.Forms.TextBox();
            this.userTxtBox = new System.Windows.Forms.TextBox();
            this.LOGINBTN = new System.Windows.Forms.Button();
            this.REGISTERBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // USER
            // 
            this.USER.AutoSize = true;
            this.USER.Location = new System.Drawing.Point(322, 23);
            this.USER.Name = "USER";
            this.USER.Size = new System.Drawing.Size(37, 13);
            this.USER.TabIndex = 0;
            this.USER.Text = "USER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PASSWORD";
            // 
            // pswTxtBox
            // 
            this.pswTxtBox.Location = new System.Drawing.Point(234, 136);
            this.pswTxtBox.Name = "pswTxtBox";
            this.pswTxtBox.Size = new System.Drawing.Size(227, 20);
            this.pswTxtBox.TabIndex = 2;
            this.pswTxtBox.TextChanged += new System.EventHandler(this.pswTxtBox_TextChanged);
            // 
            // userTxtBox
            // 
            this.userTxtBox.Location = new System.Drawing.Point(234, 53);
            this.userTxtBox.Name = "userTxtBox";
            this.userTxtBox.Size = new System.Drawing.Size(228, 20);
            this.userTxtBox.TabIndex = 3;
            this.userTxtBox.TextChanged += new System.EventHandler(this.userTxtBox_TextChanged);
            // 
            // LOGINBTN
            // 
            this.LOGINBTN.Location = new System.Drawing.Point(282, 193);
            this.LOGINBTN.Name = "LOGINBTN";
            this.LOGINBTN.Size = new System.Drawing.Size(128, 56);
            this.LOGINBTN.TabIndex = 4;
            this.LOGINBTN.Text = "LOGIN";
            this.LOGINBTN.UseVisualStyleBackColor = true;
            this.LOGINBTN.Click += new System.EventHandler(this.LOGINBTN_Click);
            // 
            // REGISTERBTN
            // 
            this.REGISTERBTN.Location = new System.Drawing.Point(281, 274);
            this.REGISTERBTN.Name = "REGISTERBTN";
            this.REGISTERBTN.Size = new System.Drawing.Size(128, 59);
            this.REGISTERBTN.TabIndex = 5;
            this.REGISTERBTN.Text = "REGISTER";
            this.REGISTERBTN.UseVisualStyleBackColor = true;
            this.REGISTERBTN.Click += new System.EventHandler(this.REGISTERBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.REGISTERBTN);
            this.Controls.Add(this.LOGINBTN);
            this.Controls.Add(this.userTxtBox);
            this.Controls.Add(this.pswTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.USER);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label USER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pswTxtBox;
        private System.Windows.Forms.TextBox userTxtBox;
        private System.Windows.Forms.Button LOGINBTN;
        private System.Windows.Forms.Button REGISTERBTN;
    }
}

