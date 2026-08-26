namespace Carsharing.Forms
{
    partial class LoginForm
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
            this.btnReg = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.labelLogMain = new System.Windows.Forms.Label();
            this.panelReg = new System.Windows.Forms.Panel();
            this.panelReg.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnReg.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReg.Location = new System.Drawing.Point(217, 315);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(160, 33);
            this.btnReg.TabIndex = 27;
            this.btnReg.Text = "Регистрация";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.btnLogin.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.Location = new System.Drawing.Point(192, 232);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(207, 49);
            this.btnLogin.TabIndex = 26;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(53, 157);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(82, 23);
            this.labelPassword.TabIndex = 18;
            this.labelPassword.Text = "Пароль";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.Location = new System.Drawing.Point(217, 153);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(293, 30);
            this.txtPassword.TabIndex = 17;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(58, 89);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(70, 23);
            this.labelLogin.TabIndex = 16;
            this.labelLogin.Text = "Логин";
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.Location = new System.Drawing.Point(217, 85);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(293, 30);
            this.txtLogin.TabIndex = 15;
            // 
            // labelLogMain
            // 
            this.labelLogMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelLogMain.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogMain.Location = new System.Drawing.Point(0, 0);
            this.labelLogMain.Name = "labelLogMain";
            this.labelLogMain.Size = new System.Drawing.Size(569, 55);
            this.labelLogMain.TabIndex = 0;
            this.labelLogMain.Text = "Вход";
            this.labelLogMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelReg
            // 
            this.panelReg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelReg.BackColor = System.Drawing.Color.White;
            this.panelReg.Controls.Add(this.btnReg);
            this.panelReg.Controls.Add(this.btnLogin);
            this.panelReg.Controls.Add(this.labelPassword);
            this.panelReg.Controls.Add(this.txtPassword);
            this.panelReg.Controls.Add(this.labelLogin);
            this.panelReg.Controls.Add(this.txtLogin);
            this.panelReg.Controls.Add(this.labelLogMain);
            this.panelReg.Location = new System.Drawing.Point(261, 179);
            this.panelReg.Name = "panelReg";
            this.panelReg.Size = new System.Drawing.Size(569, 386);
            this.panelReg.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1090, 760);
            this.Controls.Add(this.panelReg);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.panelReg.ResumeLayout(false);
            this.panelReg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label labelLogMain;
        private System.Windows.Forms.Panel panelReg;
    }
}