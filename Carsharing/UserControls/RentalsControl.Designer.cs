namespace Carsharing.UserControls
{
    partial class RentalsControl
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRentals = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelWelcome.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWelcome
            // 
            this.panelWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.panelWelcome.Controls.Add(this.lblTitle);
            this.panelWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWelcome.Location = new System.Drawing.Point(0, 0);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(1149, 96);
            this.panelWelcome.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(512, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(98, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Аренды";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvRentals);
            this.panel1.Location = new System.Drawing.Point(35, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 256);
            this.panel1.TabIndex = 10;
            // 
            // dgvRentals
            // 
            this.dgvRentals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRentals.BackgroundColor = System.Drawing.Color.White;
            this.dgvRentals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRentals.EnableHeadersVisualStyles = false;
            this.dgvRentals.Location = new System.Drawing.Point(0, 0);
            this.dgvRentals.Name = "dgvRentals";
            this.dgvRentals.RowHeadersVisible = false;
            this.dgvRentals.RowHeadersWidth = 51;
            this.dgvRentals.RowTemplate.Height = 24;
            this.dgvRentals.Size = new System.Drawing.Size(1088, 256);
            this.dgvRentals.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.btnRefresh.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.Location = new System.Drawing.Point(462, 703);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(207, 49);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "Перезагрузить";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // RentalsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panelWelcome);
            this.Controls.Add(this.panel1);
            this.Name = "RentalsControl";
            this.Size = new System.Drawing.Size(1149, 839);
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRentals;
        private System.Windows.Forms.Button btnRefresh;
    }
}
