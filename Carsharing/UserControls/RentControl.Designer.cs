namespace Carsharing.UserControls
{
    partial class RentControl
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
            this.components = new System.ComponentModel.Container();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.lblActiveRental = new System.Windows.Forms.Label();
            this.cmbParking = new System.Windows.Forms.ComboBox();
            this.lblParkings = new System.Windows.Forms.Label();
            this.listParkings = new System.Windows.Forms.ListBox();
            this.lblParking = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblCurrentCost = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timerProcessing = new System.Windows.Forms.Timer(this.components);
            this.timerCost = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelchoose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelWelcome.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCars
            // 
            this.dgvCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCars.BackgroundColor = System.Drawing.Color.White;
            this.dgvCars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCars.EnableHeadersVisualStyles = false;
            this.dgvCars.Location = new System.Drawing.Point(0, 0);
            this.dgvCars.MultiSelect = false;
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.RowHeadersVisible = false;
            this.dgvCars.RowHeadersWidth = 51;
            this.dgvCars.RowTemplate.Height = 24;
            this.dgvCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCars.Size = new System.Drawing.Size(1142, 236);
            this.dgvCars.TabIndex = 3;
            this.dgvCars.SelectionChanged += new System.EventHandler(this.dgvCars_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvCars);
            this.panel1.Location = new System.Drawing.Point(24, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 236);
            this.panel1.TabIndex = 92;
            // 
            // panelWelcome
            // 
            this.panelWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.panelWelcome.Controls.Add(this.lblWelcome);
            this.panelWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWelcome.Location = new System.Drawing.Point(0, 0);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(1197, 96);
            this.panelWelcome.TabIndex = 91;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.Location = new System.Drawing.Point(485, 38);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(236, 28);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Арендовать машину";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.btnRefresh.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.Location = new System.Drawing.Point(336, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(207, 49);
            this.btnRefresh.TabIndex = 89;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAction
            // 
            this.btnAction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.btnAction.Enabled = false;
            this.btnAction.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAction.Location = new System.Drawing.Point(14, 15);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(282, 49);
            this.btnAction.TabIndex = 94;
            this.btnAction.Text = "Начать аренду";
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // lblActiveRental
            // 
            this.lblActiveRental.AutoSize = true;
            this.lblActiveRental.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblActiveRental.Location = new System.Drawing.Point(65, 493);
            this.lblActiveRental.Name = "lblActiveRental";
            this.lblActiveRental.Size = new System.Drawing.Size(221, 23);
            this.lblActiveRental.TabIndex = 95;
            this.lblActiveRental.Text = "Нет активной аренды";
            // 
            // cmbParking
            // 
            this.cmbParking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbParking.FormattingEnabled = true;
            this.cmbParking.Location = new System.Drawing.Point(675, 618);
            this.cmbParking.Name = "cmbParking";
            this.cmbParking.Size = new System.Drawing.Size(505, 28);
            this.cmbParking.TabIndex = 96;
            this.cmbParking.Visible = false;
            // 
            // lblParkings
            // 
            this.lblParkings.AutoSize = true;
            this.lblParkings.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblParkings.Location = new System.Drawing.Point(56, 583);
            this.lblParkings.Name = "lblParkings";
            this.lblParkings.Size = new System.Drawing.Size(459, 23);
            this.lblParkings.TabIndex = 97;
            this.lblParkings.Text = "Доступные парковки для завершения аренды:";
            this.lblParkings.Visible = false;
            // 
            // listParkings
            // 
            this.listParkings.FormattingEnabled = true;
            this.listParkings.ItemHeight = 16;
            this.listParkings.Location = new System.Drawing.Point(55, 627);
            this.listParkings.Name = "listParkings";
            this.listParkings.Size = new System.Drawing.Size(460, 196);
            this.listParkings.TabIndex = 98;
            this.listParkings.Visible = false;
            // 
            // lblParking
            // 
            this.lblParking.AutoSize = true;
            this.lblParking.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblParking.Location = new System.Drawing.Point(671, 574);
            this.lblParking.Name = "lblParking";
            this.lblParking.Size = new System.Drawing.Size(509, 23);
            this.lblParking.TabIndex = 99;
            this.lblParking.Text = "Для завершения аренды необходимо выбрать адрес";
            this.lblParking.Visible = false;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStartTime.Location = new System.Drawing.Point(671, 493);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(88, 23);
            this.lblStartTime.TabIndex = 100;
            this.lblStartTime.Text = "Начало:";
            this.lblStartTime.Visible = false;
            // 
            // lblCurrentCost
            // 
            this.lblCurrentCost.AutoSize = true;
            this.lblCurrentCost.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentCost.Location = new System.Drawing.Point(1016, 493);
            this.lblCurrentCost.Name = "lblCurrentCost";
            this.lblCurrentCost.Size = new System.Drawing.Size(203, 23);
            this.lblCurrentCost.TabIndex = 101;
            this.lblCurrentCost.Text = "Текущая стоимость:";
            this.lblCurrentCost.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 19);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(317, 40);
            this.progressBar.TabIndex = 102;
            this.progressBar.Visible = false;
            // 
            // timerProcessing
            // 
            this.timerProcessing.Tick += new System.EventHandler(this.timerProcessing_Tick);
            // 
            // timerCost
            // 
            this.timerCost.Tick += new System.EventHandler(this.timerCost_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnAction);
            this.panel2.Location = new System.Drawing.Point(24, 947);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 75);
            this.panel2.TabIndex = 103;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.progressBar);
            this.panel3.Location = new System.Drawing.Point(467, 829);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 62);
            this.panel3.TabIndex = 104;
            // 
            // labelchoose
            // 
            this.labelchoose.AutoSize = true;
            this.labelchoose.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelchoose.Location = new System.Drawing.Point(65, 109);
            this.labelchoose.Name = "labelchoose";
            this.labelchoose.Size = new System.Drawing.Size(186, 23);
            this.labelchoose.TabIndex = 105;
            this.labelchoose.Text = "Выберите машину";
            // 
            // RentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelchoose);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblCurrentCost);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblParking);
            this.Controls.Add(this.listParkings);
            this.Controls.Add(this.lblParkings);
            this.Controls.Add(this.cmbParking);
            this.Controls.Add(this.lblActiveRental);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelWelcome);
            this.Name = "RentControl";
            this.Size = new System.Drawing.Size(1197, 996);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label lblActiveRental;
        private System.Windows.Forms.ComboBox cmbParking;
        private System.Windows.Forms.Label lblParkings;
        private System.Windows.Forms.ListBox listParkings;
        private System.Windows.Forms.Label lblParking;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblCurrentCost;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timerProcessing;
        private System.Windows.Forms.Timer timerCost;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelchoose;
    }
}
