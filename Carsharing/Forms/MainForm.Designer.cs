namespace Carsharing.Forms
{
    partial class MainForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnFines2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnManageClients = new System.Windows.Forms.Button();
            this.btnManageCars = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnFines = new System.Windows.Forms.Button();
            this.btnRentCar = new System.Windows.Forms.Button();
            this.btnRentals = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.btnFines2);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btnManageClients);
            this.panelMenu.Controls.Add(this.btnManageCars);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.btnFines);
            this.panelMenu.Controls.Add(this.btnRentCar);
            this.panelMenu.Controls.Add(this.btnRentals);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(294, 741);
            this.panelMenu.TabIndex = 1;
            // 
            // btnFines2
            // 
            this.btnFines2.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFines2.Location = new System.Drawing.Point(30, 363);
            this.btnFines2.Name = "btnFines2";
            this.btnFines2.Size = new System.Drawing.Size(234, 50);
            this.btnFines2.TabIndex = 11;
            this.btnFines2.Text = "Штрафы";
            this.btnFines2.UseVisualStyleBackColor = true;
            this.btnFines2.Click += new System.EventHandler(this.btnFines2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 546);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 195);
            this.panel1.TabIndex = 10;
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProfile.Location = new System.Drawing.Point(30, 31);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(234, 50);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Мой профиль";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(30, 115);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(234, 50);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Выход";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnManageClients
            // 
            this.btnManageClients.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnManageClients.Location = new System.Drawing.Point(30, 455);
            this.btnManageClients.Name = "btnManageClients";
            this.btnManageClients.Size = new System.Drawing.Size(234, 50);
            this.btnManageClients.TabIndex = 9;
            this.btnManageClients.Text = "Клиенты";
            this.btnManageClients.UseVisualStyleBackColor = true;
            this.btnManageClients.Click += new System.EventHandler(this.btnManageClients_Click);
            // 
            // btnManageCars
            // 
            this.btnManageCars.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnManageCars.Location = new System.Drawing.Point(30, 184);
            this.btnManageCars.Name = "btnManageCars";
            this.btnManageCars.Size = new System.Drawing.Size(234, 50);
            this.btnManageCars.TabIndex = 8;
            this.btnManageCars.Text = "Машины";
            this.btnManageCars.UseVisualStyleBackColor = true;
            this.btnManageCars.Click += new System.EventHandler(this.btnManageCars_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHome.Location = new System.Drawing.Point(30, 99);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(234, 50);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Главная";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // btnFines
            // 
            this.btnFines.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFines.Location = new System.Drawing.Point(30, 363);
            this.btnFines.Name = "btnFines";
            this.btnFines.Size = new System.Drawing.Size(234, 50);
            this.btnFines.TabIndex = 6;
            this.btnFines.Text = "Штрафы";
            this.btnFines.UseVisualStyleBackColor = true;
            this.btnFines.Click += new System.EventHandler(this.btnFines_Click);
            // 
            // btnRentCar
            // 
            this.btnRentCar.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRentCar.Location = new System.Drawing.Point(30, 184);
            this.btnRentCar.Name = "btnRentCar";
            this.btnRentCar.Size = new System.Drawing.Size(234, 50);
            this.btnRentCar.TabIndex = 5;
            this.btnRentCar.Text = "Арендовать машину";
            this.btnRentCar.UseVisualStyleBackColor = true;
            this.btnRentCar.Click += new System.EventHandler(this.btnRentCar_Click);
            // 
            // btnRentals
            // 
            this.btnRentals.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRentals.Location = new System.Drawing.Point(30, 275);
            this.btnRentals.Name = "btnRentals";
            this.btnRentals.Size = new System.Drawing.Size(234, 50);
            this.btnRentals.TabIndex = 3;
            this.btnRentals.Text = "Мои аренды";
            this.btnRentals.UseVisualStyleBackColor = true;
            this.btnRentals.Click += new System.EventHandler(this.btnMyRentals_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(294, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(871, 741);
            this.panelContent.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1165, 741);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnRentals;
        private System.Windows.Forms.Button btnRentCar;
        private System.Windows.Forms.Button btnFines;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnManageCars;
        private System.Windows.Forms.Button btnManageClients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFines2;
    }
}