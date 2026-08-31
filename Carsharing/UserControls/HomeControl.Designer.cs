namespace Carsharing.UserControls
{
    partial class HomeControl
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
            this.lblRentalInfo = new System.Windows.Forms.Label();
            this.dgvRental = new System.Windows.Forms.DataGridView();
            this.dgvFines = new System.Windows.Forms.DataGridView();
            this.lblFines = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFines)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWelcome
            // 
            this.panelWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.panelWelcome.Controls.Add(this.lblWelcome);
            this.panelWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWelcome.Location = new System.Drawing.Point(0, 0);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(1143, 96);
            this.panelWelcome.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.Location = new System.Drawing.Point(459, 40);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(216, 28);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Добро пожаловать";
            // 
            // lblRentalInfo
            // 
            this.lblRentalInfo.AutoSize = true;
            this.lblRentalInfo.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRentalInfo.Location = new System.Drawing.Point(73, 150);
            this.lblRentalInfo.Name = "lblRentalInfo";
            this.lblRentalInfo.Size = new System.Drawing.Size(153, 21);
            this.lblRentalInfo.TabIndex = 1;
            this.lblRentalInfo.Text = "Активная аренда";
            // 
            // dgvRental
            // 
            this.dgvRental.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRental.BackgroundColor = System.Drawing.Color.White;
            this.dgvRental.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRental.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRental.EnableHeadersVisualStyles = false;
            this.dgvRental.Location = new System.Drawing.Point(0, 0);
            this.dgvRental.Name = "dgvRental";
            this.dgvRental.RowHeadersVisible = false;
            this.dgvRental.RowHeadersWidth = 51;
            this.dgvRental.RowTemplate.Height = 24;
            this.dgvRental.Size = new System.Drawing.Size(1038, 161);
            this.dgvRental.TabIndex = 2;
            // 
            // dgvFines
            // 
            this.dgvFines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFines.BackgroundColor = System.Drawing.Color.White;
            this.dgvFines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFines.EnableHeadersVisualStyles = false;
            this.dgvFines.Location = new System.Drawing.Point(0, 0);
            this.dgvFines.Name = "dgvFines";
            this.dgvFines.RowHeadersVisible = false;
            this.dgvFines.RowHeadersWidth = 51;
            this.dgvFines.RowTemplate.Height = 24;
            this.dgvFines.Size = new System.Drawing.Size(1038, 161);
            this.dgvFines.TabIndex = 4;
            // 
            // lblFines
            // 
            this.lblFines.AutoSize = true;
            this.lblFines.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFines.Location = new System.Drawing.Point(73, 424);
            this.lblFines.Name = "lblFines";
            this.lblFines.Size = new System.Drawing.Size(82, 21);
            this.lblFines.TabIndex = 3;
            this.lblFines.Text = "Штрафы";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvRental);
            this.panel1.Location = new System.Drawing.Point(62, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 161);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvFines);
            this.panel2.Location = new System.Drawing.Point(62, 483);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 161);
            this.panel2.TabIndex = 6;
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFines);
            this.Controls.Add(this.lblRentalInfo);
            this.Controls.Add(this.panelWelcome);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(1143, 868);
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFines)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRentalInfo;
        private System.Windows.Forms.DataGridView dgvRental;
        private System.Windows.Forms.DataGridView dgvFines;
        private System.Windows.Forms.Label lblFines;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
