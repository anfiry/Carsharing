namespace Carsharing.UserControls
{
    partial class ManageCarsControl
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbParking = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblParking = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbFuelType = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.txtStateNumber = new System.Windows.Forms.TextBox();
            this.lblStateNumber = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.panelWelcome.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.btnDelete.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(853, 809);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(223, 49);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.btnSave.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(853, 897);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(223, 49);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvCars);
            this.panel1.Location = new System.Drawing.Point(34, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 250);
            this.panel1.TabIndex = 51;
            // 
            // dgvCars
            // 
            this.dgvCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCars.BackgroundColor = System.Drawing.Color.White;
            this.dgvCars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCars.EnableHeadersVisualStyles = false;
            this.dgvCars.Location = new System.Drawing.Point(0, 0);
            this.dgvCars.MultiSelect = false;
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.RowHeadersVisible = false;
            this.dgvCars.RowHeadersWidth = 51;
            this.dgvCars.RowTemplate.Height = 24;
            this.dgvCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCars.Size = new System.Drawing.Size(1112, 250);
            this.dgvCars.TabIndex = 3;
            this.dgvCars.SelectionChanged += new System.EventHandler(this.dgvCars_SelectionChanged);
            // 
            // panelWelcome
            // 
            this.panelWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.panelWelcome.Controls.Add(this.lblWelcome);
            this.panelWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWelcome.Location = new System.Drawing.Point(0, 0);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(1167, 96);
            this.panelWelcome.TabIndex = 49;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.Location = new System.Drawing.Point(519, 37);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(112, 28);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Машины";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.btnRefresh.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.Location = new System.Drawing.Point(867, 502);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(190, 44);
            this.btnRefresh.TabIndex = 54;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.cmbParking);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblParking);
            this.groupBox1.Controls.Add(this.cmbColor);
            this.groupBox1.Controls.Add(this.cmbFuelType);
            this.groupBox1.Controls.Add(this.lblColor);
            this.groupBox1.Controls.Add(this.lblFuelType);
            this.groupBox1.Controls.Add(this.nudPrice);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.nudYear);
            this.groupBox1.Controls.Add(this.cmbModel);
            this.groupBox1.Controls.Add(this.cmbBrand);
            this.groupBox1.Controls.Add(this.txtStateNumber);
            this.groupBox1.Controls.Add(this.lblStateNumber);
            this.groupBox1.Controls.Add(this.lblModel);
            this.groupBox1.Controls.Add(this.lblYear);
            this.groupBox1.Controls.Add(this.lblBrand);
            this.groupBox1.Location = new System.Drawing.Point(34, 498);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 567);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о машине";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(167, 529);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(485, 26);
            this.cmbStatus.TabIndex = 84;
            // 
            // cmbParking
            // 
            this.cmbParking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbParking.FormattingEnabled = true;
            this.cmbParking.Location = new System.Drawing.Point(167, 471);
            this.cmbParking.Name = "cmbParking";
            this.cmbParking.Size = new System.Drawing.Size(485, 26);
            this.cmbParking.TabIndex = 83;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(57, 531);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(69, 22);
            this.lblStatus.TabIndex = 81;
            this.lblStatus.Text = "Статус";
            // 
            // lblParking
            // 
            this.lblParking.AutoSize = true;
            this.lblParking.BackColor = System.Drawing.Color.White;
            this.lblParking.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblParking.Location = new System.Drawing.Point(38, 471);
            this.lblParking.Name = "lblParking";
            this.lblParking.Size = new System.Drawing.Size(94, 22);
            this.lblParking.TabIndex = 82;
            this.lblParking.Text = "Парковка";
            // 
            // cmbColor
            // 
            this.cmbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(167, 406);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(485, 26);
            this.cmbColor.TabIndex = 80;
            this.cmbColor.TextChanged += new System.EventHandler(this.EnableSaveIfEditing);
            // 
            // cmbFuelType
            // 
            this.cmbFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbFuelType.FormattingEnabled = true;
            this.cmbFuelType.Location = new System.Drawing.Point(167, 348);
            this.cmbFuelType.Name = "cmbFuelType";
            this.cmbFuelType.Size = new System.Drawing.Size(485, 26);
            this.cmbFuelType.TabIndex = 79;
            this.cmbFuelType.TextChanged += new System.EventHandler(this.EnableSaveIfEditing);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.White;
            this.lblColor.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblColor.Location = new System.Drawing.Point(76, 407);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(53, 22);
            this.lblColor.TabIndex = 77;
            this.lblColor.Text = "Цвет";
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.BackColor = System.Drawing.Color.White;
            this.lblFuelType.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFuelType.Location = new System.Drawing.Point(49, 350);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(83, 22);
            this.lblFuelType.TabIndex = 78;
            this.lblFuelType.Text = "Топливо";
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudPrice.Location = new System.Drawing.Point(167, 286);
            this.nudPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(485, 27);
            this.nudPrice.TabIndex = 76;
            this.nudPrice.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPrice.ValueChanged += new System.EventHandler(this.EnableSaveIfEditing);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(37, 288);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(95, 22);
            this.lblPrice.TabIndex = 75;
            this.lblPrice.Text = "Цена/мин";
            // 
            // nudYear
            // 
            this.nudYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudYear.Location = new System.Drawing.Point(167, 221);
            this.nudYear.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(485, 27);
            this.nudYear.TabIndex = 74;
            this.nudYear.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudYear.ValueChanged += new System.EventHandler(this.EnableSaveIfEditing);
            // 
            // cmbModel
            // 
            this.cmbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(167, 163);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(485, 26);
            this.cmbModel.TabIndex = 72;
            this.cmbModel.TextChanged += new System.EventHandler(this.EnableSaveIfEditing);
            // 
            // cmbBrand
            // 
            this.cmbBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(167, 105);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(485, 26);
            this.cmbBrand.TabIndex = 71;
            this.cmbBrand.TextChanged += new System.EventHandler(this.EnableSaveIfEditing);
            // 
            // txtStateNumber
            // 
            this.txtStateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStateNumber.Location = new System.Drawing.Point(167, 47);
            this.txtStateNumber.Name = "txtStateNumber";
            this.txtStateNumber.Size = new System.Drawing.Size(486, 27);
            this.txtStateNumber.TabIndex = 70;
            this.txtStateNumber.TextChanged += new System.EventHandler(this.EnableSaveIfEditing);
            // 
            // lblStateNumber
            // 
            this.lblStateNumber.AutoSize = true;
            this.lblStateNumber.BackColor = System.Drawing.Color.White;
            this.lblStateNumber.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStateNumber.Location = new System.Drawing.Point(37, 49);
            this.lblStateNumber.Name = "lblStateNumber";
            this.lblStateNumber.Size = new System.Drawing.Size(90, 22);
            this.lblStateNumber.TabIndex = 29;
            this.lblStateNumber.Text = "Госномер";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.BackColor = System.Drawing.Color.White;
            this.lblModel.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblModel.Location = new System.Drawing.Point(57, 166);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(75, 22);
            this.lblModel.TabIndex = 37;
            this.lblModel.Text = "Модель";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.White;
            this.lblYear.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYear.Location = new System.Drawing.Point(87, 225);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(40, 22);
            this.lblYear.TabIndex = 35;
            this.lblYear.Text = "Год";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.BackColor = System.Drawing.Color.White;
            this.lblBrand.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBrand.Location = new System.Drawing.Point(64, 107);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(63, 22);
            this.lblBrand.TabIndex = 39;
            this.lblBrand.Text = "Бренд";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.btnAdd.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(853, 716);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(223, 49);
            this.btnAdd.TabIndex = 67;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ManageCarsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelWelcome);
            this.Controls.Add(this.btnRefresh);
            this.Name = "ManageCarsControl";
            this.Size = new System.Drawing.Size(1167, 901);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStateNumber;
        private System.Windows.Forms.Label lblStateNumber;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbParking;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblParking;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbFuelType;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.Button btnAdd;
    }
}
