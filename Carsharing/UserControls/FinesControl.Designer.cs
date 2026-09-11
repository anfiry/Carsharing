namespace Carsharing.UserControls
{
    partial class FinesControl
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
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvFines = new System.Windows.Forms.DataGridView();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnPayFine = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timerProcessing = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFines)).BeginInit();
            this.panelWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(207, 120);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(160, 24);
            this.cmbFilter.TabIndex = 70;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.BackColor = System.Drawing.Color.White;
            this.lblFilter.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilter.Location = new System.Drawing.Point(92, 120);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(76, 22);
            this.lblFilter.TabIndex = 66;
            this.lblFilter.Text = "Фильтр";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvFines);
            this.panel1.Location = new System.Drawing.Point(24, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 158);
            this.panel1.TabIndex = 68;
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
            this.dgvFines.SelectionChanged += new System.EventHandler(this.dgvFines_SelectionChanged);
            // 
            // panelWelcome
            // 
            this.panelWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.panelWelcome.Controls.Add(this.lblWelcome);
            this.panelWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWelcome.Location = new System.Drawing.Point(0, 0);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(1114, 96);
            this.panelWelcome.TabIndex = 67;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.Location = new System.Drawing.Point(493, 37);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(108, 28);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Штрафы";
            // 
            // btnPayFine
            // 
            this.btnPayFine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPayFine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.btnPayFine.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPayFine.Location = new System.Drawing.Point(603, 820);
            this.btnPayFine.Name = "btnPayFine";
            this.btnPayFine.Size = new System.Drawing.Size(230, 54);
            this.btnPayFine.TabIndex = 88;
            this.btnPayFine.Text = "Оплатить";
            this.btnPayFine.UseVisualStyleBackColor = false;
            this.btnPayFine.Click += new System.EventHandler(this.btnPayFine_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.btnRefresh.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.Location = new System.Drawing.Point(308, 820);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(218, 54);
            this.btnRefresh.TabIndex = 62;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(436, 696);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(259, 45);
            this.progressBar.TabIndex = 89;
            // 
            // FinesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnPayFine);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelWelcome);
            this.Name = "FinesControl";
            this.Size = new System.Drawing.Size(1114, 888);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFines)).EndInit();
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvFines;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnPayFine;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timerProcessing;
    }
}
