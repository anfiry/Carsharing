namespace Carsharing.Forms
{
    partial class RegisterForm
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
            this.panelReg = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.dtpLicenseDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.labelLicenseDate = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.labeltxtPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.txtPatronymic = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.labelRegMain = new System.Windows.Forms.Label();
            this.panelReg.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelReg
            // 
            this.panelReg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelReg.BackColor = System.Drawing.Color.White;
            this.panelReg.Controls.Add(this.btnBack);
            this.panelReg.Controls.Add(this.btnRegister);
            this.panelReg.Controls.Add(this.dtpLicenseDate);
            this.panelReg.Controls.Add(this.dtpBirthDate);
            this.panelReg.Controls.Add(this.labelLicenseDate);
            this.panelReg.Controls.Add(this.labelBirthDate);
            this.panelReg.Controls.Add(this.labelConfirmPassword);
            this.panelReg.Controls.Add(this.txtConfirmPassword);
            this.panelReg.Controls.Add(this.labelPassword);
            this.panelReg.Controls.Add(this.txtPassword);
            this.panelReg.Controls.Add(this.labelLogin);
            this.panelReg.Controls.Add(this.txtLogin);
            this.panelReg.Controls.Add(this.labeltxtPhone);
            this.panelReg.Controls.Add(this.txtPhone);
            this.panelReg.Controls.Add(this.labelPatronymic);
            this.panelReg.Controls.Add(this.txtPatronymic);
            this.panelReg.Controls.Add(this.labelFirstName);
            this.panelReg.Controls.Add(this.txtFirstName);
            this.panelReg.Controls.Add(this.labelLastName);
            this.panelReg.Controls.Add(this.txtLastName);
            this.panelReg.Controls.Add(this.labelRegMain);
            this.panelReg.Location = new System.Drawing.Point(227, 48);
            this.panelReg.Name = "panelReg";
            this.panelReg.Size = new System.Drawing.Size(737, 885);
            this.panelReg.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnBack.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(315, 818);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(160, 33);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.btnRegister.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegister.Location = new System.Drawing.Point(249, 729);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(284, 54);
            this.btnRegister.TabIndex = 26;
            this.btnRegister.Text = "Зарегистрироваться";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // dtpLicenseDate
            // 
            this.dtpLicenseDate.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpLicenseDate.Location = new System.Drawing.Point(335, 652);
            this.dtpLicenseDate.Name = "dtpLicenseDate";
            this.dtpLicenseDate.Size = new System.Drawing.Size(238, 29);
            this.dtpLicenseDate.TabIndex = 25;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpBirthDate.Location = new System.Drawing.Point(335, 583);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(238, 29);
            this.dtpBirthDate.TabIndex = 1;
            // 
            // labelLicenseDate
            // 
            this.labelLicenseDate.AutoSize = true;
            this.labelLicenseDate.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLicenseDate.Location = new System.Drawing.Point(131, 656);
            this.labelLicenseDate.Name = "labelLicenseDate";
            this.labelLicenseDate.Size = new System.Drawing.Size(186, 23);
            this.labelLicenseDate.TabIndex = 24;
            this.labelLicenseDate.Text = "Дата выдачи прав";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBirthDate.Location = new System.Drawing.Point(158, 587);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(159, 23);
            this.labelBirthDate.TabIndex = 22;
            this.labelBirthDate.Text = "Дата рождения";
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConfirmPassword.Location = new System.Drawing.Point(131, 510);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(184, 23);
            this.labelConfirmPassword.TabIndex = 20;
            this.labelConfirmPassword.Text = "Повторите пароль";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(335, 506);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(238, 30);
            this.txtConfirmPassword.TabIndex = 19;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(233, 438);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(82, 23);
            this.labelPassword.TabIndex = 18;
            this.labelPassword.Text = "Пароль";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.Location = new System.Drawing.Point(335, 438);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(238, 30);
            this.txtPassword.TabIndex = 17;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(245, 377);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(70, 23);
            this.labelLogin.TabIndex = 16;
            this.labelLogin.Text = "Логин";
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.Location = new System.Drawing.Point(335, 370);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(238, 30);
            this.txtLogin.TabIndex = 15;
            // 
            // labeltxtPhone
            // 
            this.labeltxtPhone.AutoSize = true;
            this.labeltxtPhone.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltxtPhone.Location = new System.Drawing.Point(146, 309);
            this.labeltxtPhone.Name = "labeltxtPhone";
            this.labeltxtPhone.Size = new System.Drawing.Size(169, 23);
            this.labeltxtPhone.TabIndex = 14;
            this.labeltxtPhone.Text = "Номер телефона";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPhone.Location = new System.Drawing.Point(335, 305);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(238, 30);
            this.txtPhone.TabIndex = 13;
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatronymic.Location = new System.Drawing.Point(208, 243);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(107, 23);
            this.labelPatronymic.TabIndex = 12;
            this.labelPatronymic.Text = "Отчество*";
            // 
            // txtPatronymic
            // 
            this.txtPatronymic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPatronymic.Location = new System.Drawing.Point(335, 236);
            this.txtPatronymic.Name = "txtPatronymic";
            this.txtPatronymic.Size = new System.Drawing.Size(238, 30);
            this.txtPatronymic.TabIndex = 11;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstName.Location = new System.Drawing.Point(262, 175);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(53, 23);
            this.labelFirstName.TabIndex = 10;
            this.labelFirstName.Text = "Имя";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFirstName.Location = new System.Drawing.Point(335, 168);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(238, 30);
            this.txtFirstName.TabIndex = 9;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.Location = new System.Drawing.Point(217, 103);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(100, 23);
            this.labelLastName.TabIndex = 8;
            this.labelLastName.Text = "Фамилия";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLastName.Location = new System.Drawing.Point(335, 103);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(238, 30);
            this.txtLastName.TabIndex = 1;
            // 
            // labelRegMain
            // 
            this.labelRegMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRegMain.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegMain.Location = new System.Drawing.Point(0, 0);
            this.labelRegMain.Name = "labelRegMain";
            this.labelRegMain.Size = new System.Drawing.Size(737, 55);
            this.labelRegMain.TabIndex = 0;
            this.labelRegMain.Text = "Регистрация";
            this.labelRegMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1187, 999);
            this.Controls.Add(this.panelReg);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.panelReg.ResumeLayout(false);
            this.panelReg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelReg;
        private System.Windows.Forms.Label labelRegMain;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.TextBox txtPatronymic;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label labeltxtPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label labelLicenseDate;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.DateTimePicker dtpLicenseDate;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBack;
    }
}