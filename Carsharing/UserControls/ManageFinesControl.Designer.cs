namespace Carsharing.UserControls
{
    partial class ManageFinesControl
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
            this.dgvFines = new System.Windows.Forms.DataGridView();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblFineType = new System.Windows.Forms.Label();
            this.lblRental = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.cmbRental = new System.Windows.Forms.ComboBox();
            this.cmbFineType = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnAddFine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFines)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelWelcome.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvFines.MultiSelect = false;
            this.dgvFines.Name = "dgvFines";
            this.dgvFines.RowHeadersVisible = false;
            this.dgvFines.RowHeadersWidth = 51;
            this.dgvFines.RowTemplate.Height = 24;
            this.dgvFines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFines.Size = new System.Drawing.Size(1081, 158);
            this.dgvFines.TabIndex = 3;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.Location = new System.Drawing.Point(503, 37);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(108, 28);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Штрафы";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.btnRefresh.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.Location = new System.Drawing.Point(336, 881);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(207, 49);
            this.btnRefresh.TabIndex = 61;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvFines);
            this.panel1.Location = new System.Drawing.Point(24, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 158);
            this.panel1.TabIndex = 58;
            // 
            // panelWelcome
            // 
            this.panelWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.panelWelcome.Controls.Add(this.lblWelcome);
            this.panelWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWelcome.Location = new System.Drawing.Point(0, 0);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(1135, 96);
            this.panelWelcome.TabIndex = 48;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.BackColor = System.Drawing.Color.White;
            this.lblClient.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClient.Location = new System.Drawing.Point(57, 48);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(75, 22);
            this.lblClient.TabIndex = 29;
            this.lblClient.Text = "Клиент";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.White;
            this.lblAmount.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAmount.Location = new System.Drawing.Point(63, 262);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(69, 22);
            this.lblAmount.TabIndex = 35;
            this.lblAmount.Text = "Сумма";
            // 
            // lblFineType
            // 
            this.lblFineType.AutoSize = true;
            this.lblFineType.BackColor = System.Drawing.Color.White;
            this.lblFineType.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFineType.Location = new System.Drawing.Point(14, 192);
            this.lblFineType.Name = "lblFineType";
            this.lblFineType.Size = new System.Drawing.Size(118, 22);
            this.lblFineType.TabIndex = 37;
            this.lblFineType.Text = "Тип штрафа";
            // 
            // lblRental
            // 
            this.lblRental.AutoSize = true;
            this.lblRental.BackColor = System.Drawing.Color.White;
            this.lblRental.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRental.Location = new System.Drawing.Point(59, 117);
            this.lblRental.Name = "lblRental";
            this.lblRental.Size = new System.Drawing.Size(73, 22);
            this.lblRental.TabIndex = 39;
            this.lblRental.Text = "Аренда";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.BackColor = System.Drawing.Color.White;
            this.lblFilter.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilter.Location = new System.Drawing.Point(92, 117);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(76, 22);
            this.lblFilter.TabIndex = 41;
            this.lblFilter.Text = "Фильтр";
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Все",
            "Неоплаченные",
            "Оплаченные"});
            this.cmbFilter.Location = new System.Drawing.Point(207, 117);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(160, 24);
            this.cmbFilter.TabIndex = 63;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.cmbClient);
            this.groupBox1.Controls.Add(this.cmbRental);
            this.groupBox1.Controls.Add(this.cmbFineType);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.lblClient);
            this.groupBox1.Controls.Add(this.lblFineType);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Controls.Add(this.lblRental);
            this.groupBox1.Location = new System.Drawing.Point(24, 531);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 380);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Назначить штраф";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDescription.Location = new System.Drawing.Point(170, 328);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(483, 27);
            this.txtDescription.TabIndex = 66;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAmount.Location = new System.Drawing.Point(170, 262);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(483, 27);
            this.txtAmount.TabIndex = 67;
            // 
            // cmbClient
            // 
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(170, 48);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(483, 24);
            this.cmbClient.TabIndex = 66;
            // 
            // cmbRental
            // 
            this.cmbRental.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRental.FormattingEnabled = true;
            this.cmbRental.Location = new System.Drawing.Point(170, 115);
            this.cmbRental.Name = "cmbRental";
            this.cmbRental.Size = new System.Drawing.Size(483, 24);
            this.cmbRental.TabIndex = 67;
            // 
            // cmbFineType
            // 
            this.cmbFineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFineType.FormattingEnabled = true;
            this.cmbFineType.Location = new System.Drawing.Point(170, 190);
            this.cmbFineType.Name = "cmbFineType";
            this.cmbFineType.Size = new System.Drawing.Size(483, 24);
            this.cmbFineType.TabIndex = 68;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.White;
            this.lblDescription.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription.Location = new System.Drawing.Point(37, 328);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(95, 22);
            this.lblDescription.TabIndex = 40;
            this.lblDescription.Text = "Описание";
            // 
            // btnAddFine
            // 
            this.btnAddFine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddFine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.btnAddFine.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddFine.Location = new System.Drawing.Point(610, 881);
            this.btnAddFine.Name = "btnAddFine";
            this.btnAddFine.Size = new System.Drawing.Size(207, 49);
            this.btnAddFine.TabIndex = 65;
            this.btnAddFine.Text = "Сохранить";
            this.btnAddFine.UseVisualStyleBackColor = false;
            this.btnAddFine.Click += new System.EventHandler(this.btnAddFine_Click);
            // 
            // ManageFinesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAddFine);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelWelcome);
            this.Name = "ManageFinesControl";
            this.Size = new System.Drawing.Size(1135, 902);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFines)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFines;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblFineType;
        private System.Windows.Forms.Label lblRental;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.ComboBox cmbRental;
        private System.Windows.Forms.ComboBox cmbFineType;
        private System.Windows.Forms.Button btnAddFine;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAmount;
    }
}
