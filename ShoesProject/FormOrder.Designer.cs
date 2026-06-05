namespace ShoesProject
{
    partial class FormOrder
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelTop = new Panel();
            lblUserName = new Label();
            btn_logout = new Button();
            dgvOrders = new DataGridView();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(lblUserName);
            panelTop.Controls.Add(btn_logout);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(0, 0, 0, 10);
            panelTop.Size = new Size(982, 40);
            panelTop.TabIndex = 3;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Dock = DockStyle.Right;
            lblUserName.Location = new Point(756, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(50, 20);
            lblUserName.TabIndex = 6;
            lblUserName.Text = "label1";
            lblUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.MediumSpringGreen;
            btn_logout.Dock = DockStyle.Right;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Location = new Point(806, 0);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(176, 30);
            btn_logout.TabIndex = 5;
            btn_logout.Text = "Выйти";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.Anchor = AnchorStyles.Left;
            dgvOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOrders.BackgroundColor = Color.White;
            dgvOrders.BorderStyle = BorderStyle.None;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOrders.DefaultCellStyle = dataGridViewCellStyle1;
            dgvOrders.Location = new Point(0, 46);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(982, 607);
            dgvOrders.TabIndex = 4;
            dgvOrders.CellContentClick += dgvProducts_CellContentClick;
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(dgvOrders);
            Controls.Add(panelTop);
            Name = "FormOrder";
            Text = "FormOrder";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label lblUserName;
        private Button btn_logout;
        private DataGridView dgvOrders;
    }
}