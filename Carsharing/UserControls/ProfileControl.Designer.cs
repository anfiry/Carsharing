namespace Carsharing.UserControls
{
    partial class ProfileControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtExperience = new System.Windows.Forms.TextBox();
            this.lblExperience = new System.Windows.Forms.Label();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPatronymic = new System.Windows.Forms.TextBox();
            this.lblPatronymic = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWelcome
            // 
            this.panelWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.panelWelcome.Controls.Add(this.lblWelcome);
            this.panelWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWelcome.Location = new System.Drawing.Point(0, 0);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(1175, 96);
            this.panelWelcome.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.Location = new System.Drawing.Point(486, 40);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(162, 28);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Мой профиль";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.White;
            this.lblLastName.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastName.Location = new System.Drawing.Point(103, 242);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(92, 22);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Фамилия";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLastName.Location = new System.Drawing.Point(215, 241);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(224, 27);
            this.txtLastName.TabIndex = 3;
            // 
            // txtExperience
            // 
            this.txtExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtExperience.Location = new System.Drawing.Point(215, 659);
            this.txtExperience.Name = "txtExperience";
            this.txtExperience.Size = new System.Drawing.Size(224, 27);
            this.txtExperience.TabIndex = 5;
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.BackColor = System.Drawing.Color.White;
            this.lblExperience.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExperience.Location = new System.Drawing.Point(134, 660);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(56, 22);
            this.lblExperience.TabIndex = 4;
            this.lblExperience.Text = "Стаж";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBirthDate.Location = new System.Drawing.Point(215, 571);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(224, 27);
            this.txtBirthDate.TabIndex = 7;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.BackColor = System.Drawing.Color.White;
            this.lblBirthDate.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBirthDate.Location = new System.Drawing.Point(49, 572);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(142, 22);
            this.lblBirthDate.TabIndex = 6;
            this.lblBirthDate.Text = "Дата рождения";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPhone.Location = new System.Drawing.Point(215, 486);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(224, 27);
            this.txtPhone.TabIndex = 9;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.White;
            this.lblPhone.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhone.Location = new System.Drawing.Point(106, 487);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(85, 22);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Телефон";
            // 
            // txtPatronymic
            // 
            this.txtPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPatronymic.Location = new System.Drawing.Point(215, 395);
            this.txtPatronymic.Name = "txtPatronymic";
            this.txtPatronymic.Size = new System.Drawing.Size(224, 27);
            this.txtPatronymic.TabIndex = 11;
            // 
            // lblPatronymic
            // 
            this.lblPatronymic.AutoSize = true;
            this.lblPatronymic.BackColor = System.Drawing.Color.White;
            this.lblPatronymic.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPatronymic.Location = new System.Drawing.Point(106, 396);
            this.lblPatronymic.Name = "lblPatronymic";
            this.lblPatronymic.Size = new System.Drawing.Size(88, 22);
            this.lblPatronymic.TabIndex = 10;
            this.lblPatronymic.Text = "Отчество";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFirstName.Location = new System.Drawing.Point(215, 313);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(224, 27);
            this.txtFirstName.TabIndex = 13;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.White;
            this.lblFirstName.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstName.Location = new System.Drawing.Point(140, 314);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(48, 22);
            this.lblFirstName.TabIndex = 12;
            this.lblFirstName.Text = "Имя";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.Location = new System.Drawing.Point(215, 170);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(224, 27);
            this.txtLogin.TabIndex = 15;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.White;
            this.lblLogin.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.Location = new System.Drawing.Point(124, 171);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(64, 22);
            this.lblLogin.TabIndex = 14;
            this.lblLogin.Text = "Логин";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.btnSave.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(480, 774);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(207, 49);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtPatronymic);
            this.Controls.Add(this.lblPatronymic);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.txtExperience);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.panelWelcome);
            this.Name = "ProfileControl";
            this.Size = new System.Drawing.Size(1175, 884);
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtExperience;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPatronymic;
        private System.Windows.Forms.Label lblPatronymic;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnSave;
    }
}
