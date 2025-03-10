namespace ComputerMaster.Forms.Commission
{
    partial class CommissionListForm
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
            btnRefresh = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dataGridViewCommission = new DataGridView();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCommission).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(746, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(126, 40);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Обновить";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(276, 509);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(161, 40);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(144, 509);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 40);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridViewCommission
            // 
            dataGridViewCommission.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCommission.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCommission.Location = new Point(12, 58);
            dataGridViewCommission.Name = "dataGridViewCommission";
            dataGridViewCommission.Size = new Size(860, 445);
            dataGridViewCommission.TabIndex = 6;
            dataGridViewCommission.CellClick += dataGridViewCommission_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 509);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 40);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // CommissionListForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(btnRefresh);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(dataGridViewCommission);
            Controls.Add(btnAdd);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "CommissionListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список заказов";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCommission).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefresh;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dataGridViewCommission;
        private Button btnAdd;
    }
}