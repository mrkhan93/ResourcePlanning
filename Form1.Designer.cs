namespace ResourcePlanning
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtPid = new TextBox();
            txtPName = new TextBox();
            txtQty = new TextBox();
            lblpid = new Label();
            lblPName = new Label();
            lblQty = new Label();
            lblSply = new Label();
            txtSply = new TextBox();
            btnInsert = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnView = new Button();
            label1 = new Label();
            lblWarning = new Label();
            dataGridView1 = new DataGridView();
            timerRefresh = new System.Windows.Forms.Timer(components);
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtPid
            // 
            txtPid.Location = new Point(167, 65);
            txtPid.Name = "txtPid";
            txtPid.Size = new Size(100, 23);
            txtPid.TabIndex = 0;
            // 
            // txtPName
            // 
            txtPName.Location = new Point(167, 106);
            txtPName.Name = "txtPName";
            txtPName.Size = new Size(100, 23);
            txtPName.TabIndex = 1;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(167, 155);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(100, 23);
            txtQty.TabIndex = 2;
            // 
            // lblpid
            // 
            lblpid.AutoSize = true;
            lblpid.Location = new Point(49, 69);
            lblpid.Name = "lblpid";
            lblpid.Size = new Size(63, 15);
            lblpid.TabIndex = 3;
            lblpid.Text = "Product ID";
            // 
            // lblPName
            // 
            lblPName.AutoSize = true;
            lblPName.Location = new Point(49, 114);
            lblPName.Name = "lblPName";
            lblPName.Size = new Size(49, 15);
            lblPName.TabIndex = 4;
            lblPName.Text = "Product";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(49, 158);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(53, 15);
            lblQty.TabIndex = 5;
            lblQty.Text = "Quantity";
            // 
            // lblSply
            // 
            lblSply.AutoSize = true;
            lblSply.Location = new Point(49, 212);
            lblSply.Name = "lblSply";
            lblSply.Size = new Size(50, 15);
            lblSply.TabIndex = 7;
            lblSply.Text = "Supplier";
            // 
            // txtSply
            // 
            txtSply.Location = new Point(167, 209);
            txtSply.Name = "txtSply";
            txtSply.Size = new Size(100, 23);
            txtSply.TabIndex = 6;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(63, 266);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(83, 33);
            btnInsert.TabIndex = 8;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(184, 266);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(83, 33);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(63, 322);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(83, 33);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(334, 322);
            btnView.Name = "btnView";
            btnView.Size = new Size(83, 33);
            btnView.TabIndex = 11;
            btnView.Text = "VIEW";
            btnView.UseVisualStyleBackColor = true;
//            btnView.Click += btnView_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(257, 9);
            label1.MaximumSize = new Size(0, 20);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 12;
            label1.Text = "PRODUCT INFORMATION";
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Location = new Point(109, 19);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(0, 15);
            lblWarning.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(315, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(720, 384);
            dataGridView1.TabIndex = 14;
//            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick_1;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(184, 322);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(83, 33);
            btnRefresh.TabIndex = 15;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 450);
            Controls.Add(btnRefresh);
            Controls.Add(dataGridView1);
            Controls.Add(lblWarning);
            Controls.Add(label1);
            Controls.Add(btnView);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(lblSply);
            Controls.Add(txtSply);
            Controls.Add(lblQty);
            Controls.Add(lblPName);
            Controls.Add(lblpid);
            Controls.Add(txtQty);
            Controls.Add(txtPName);
            Controls.Add(txtPid);
            Name = "Form1";
            Text = "Resource Management System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPid;
        private TextBox txtPName;
        private TextBox txtQty;
        private Label lblpid;
        private Label lblPName;
        private Label lblQty;
        private Label lblSply;
        private TextBox txtSply;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnView;
        private Label label1;
        private Label lblWarning;
        private DataGridView dataGridView1;
        private System.Windows.Forms.Timer timerRefresh;
        private Button btnRefresh;
    }
}