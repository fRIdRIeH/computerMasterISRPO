namespace ComputerMaster.Forms.Commission
{
    partial class CommissionAddForm
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
            label1 = new Label();
            btnAddOrEdit = new Button();
            modelInput = new TextBox();
            label2 = new Label();
            dateInput = new DateTimePicker();
            label3 = new Label();
            priceInput = new NumericUpDown();
            clientNameInput = new TextBox();
            label4 = new Label();
            clientTelephoneInput = new TextBox();
            label5 = new Label();
            clientAddressInput = new TextBox();
            label6 = new Label();
            label7 = new Label();
            noteInput = new TextBox();
            label8 = new Label();
            statusInput = new ComboBox();
            dataGridViewComputers = new DataGridView();
            label9 = new Label();
            label10 = new Label();
            dataGridViewClients = new DataGridView();
            btnPreview = new Button();
            ((System.ComponentModel.ISupportInitialize)priceInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewComputers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(230, 25);
            label1.TabIndex = 0;
            label1.Text = "Наименование модели";
            // 
            // btnAddOrEdit
            // 
            btnAddOrEdit.Location = new Point(12, 693);
            btnAddOrEdit.Name = "btnAddOrEdit";
            btnAddOrEdit.Size = new Size(300, 66);
            btnAddOrEdit.TabIndex = 1;
            btnAddOrEdit.Text = "button1";
            btnAddOrEdit.UseVisualStyleBackColor = true;
            btnAddOrEdit.Click += btnAddOrEdit_Click;
            // 
            // modelInput
            // 
            modelInput.Location = new Point(12, 37);
            modelInput.Name = "modelInput";
            modelInput.Size = new Size(300, 33);
            modelInput.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(247, 25);
            label2.TabIndex = 3;
            label2.Text = "Дата оформления заказа";
            // 
            // dateInput
            // 
            dateInput.Location = new Point(12, 101);
            dateInput.Name = "dateInput";
            dateInput.Size = new Size(300, 33);
            dateInput.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(177, 25);
            label3.TabIndex = 5;
            label3.Text = "Стоимость заказа";
            // 
            // priceInput
            // 
            priceInput.Location = new Point(12, 165);
            priceInput.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            priceInput.Name = "priceInput";
            priceInput.Size = new Size(300, 33);
            priceInput.TabIndex = 6;
            // 
            // clientNameInput
            // 
            clientNameInput.Location = new Point(12, 229);
            clientNameInput.Name = "clientNameInput";
            clientNameInput.Size = new Size(300, 33);
            clientNameInput.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 201);
            label4.Name = "label4";
            label4.Size = new Size(133, 25);
            label4.TabIndex = 7;
            label4.Text = "Имя клиента";
            // 
            // clientTelephoneInput
            // 
            clientTelephoneInput.Location = new Point(12, 293);
            clientTelephoneInput.Name = "clientTelephoneInput";
            clientTelephoneInput.Size = new Size(300, 33);
            clientTelephoneInput.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 265);
            label5.Name = "label5";
            label5.Size = new Size(171, 25);
            label5.TabIndex = 9;
            label5.Text = "Телефон клиента";
            // 
            // clientAddressInput
            // 
            clientAddressInput.Location = new Point(12, 357);
            clientAddressInput.Name = "clientAddressInput";
            clientAddressInput.Size = new Size(300, 33);
            clientAddressInput.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 329);
            label6.Name = "label6";
            label6.Size = new Size(149, 25);
            label6.TabIndex = 11;
            label6.Text = "Адрес клиента";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 393);
            label7.Name = "label7";
            label7.Size = new Size(135, 25);
            label7.TabIndex = 13;
            label7.Text = "Статус заказа";
            // 
            // noteInput
            // 
            noteInput.Location = new Point(12, 485);
            noteInput.Name = "noteInput";
            noteInput.Size = new Size(300, 33);
            noteInput.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 457);
            label8.Name = "label8";
            label8.Size = new Size(131, 25);
            label8.TabIndex = 15;
            label8.Text = "Примечание";
            // 
            // statusInput
            // 
            statusInput.FormattingEnabled = true;
            statusInput.Location = new Point(12, 421);
            statusInput.Name = "statusInput";
            statusInput.Size = new Size(300, 33);
            statusInput.TabIndex = 17;
            // 
            // dataGridViewComputers
            // 
            dataGridViewComputers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewComputers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewComputers.Location = new Point(373, 37);
            dataGridViewComputers.Name = "dataGridViewComputers";
            dataGridViewComputers.Size = new Size(899, 225);
            dataGridViewComputers.TabIndex = 18;
            dataGridViewComputers.CellClick += dataGridViewComputers_CellClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(373, 9);
            label9.Name = "label9";
            label9.Size = new Size(199, 25);
            label9.TabIndex = 19;
            label9.Text = "Выбор компьютера";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(373, 265);
            label10.Name = "label10";
            label10.Size = new Size(155, 25);
            label10.TabIndex = 21;
            label10.Text = "Выбор клиента";
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Location = new Point(373, 293);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.Size = new Size(899, 225);
            dataGridViewClients.TabIndex = 20;
            dataGridViewClients.CellClick += dataGridViewClients_CellClick;
            // 
            // btnPreview
            // 
            btnPreview.Location = new Point(972, 524);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(300, 66);
            btnPreview.TabIndex = 22;
            btnPreview.Text = "Предпросмотр";
            btnPreview.UseVisualStyleBackColor = true;
            btnPreview.Click += btnPreview_Click;
            // 
            // CommissionAddForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 761);
            Controls.Add(btnPreview);
            Controls.Add(label10);
            Controls.Add(dataGridViewClients);
            Controls.Add(label9);
            Controls.Add(dataGridViewComputers);
            Controls.Add(statusInput);
            Controls.Add(noteInput);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(clientAddressInput);
            Controls.Add(label6);
            Controls.Add(clientTelephoneInput);
            Controls.Add(label5);
            Controls.Add(clientNameInput);
            Controls.Add(label4);
            Controls.Add(priceInput);
            Controls.Add(label3);
            Controls.Add(dateInput);
            Controls.Add(label2);
            Controls.Add(modelInput);
            Controls.Add(btnAddOrEdit);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "CommissionAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CommissionAddForm";
            ((System.ComponentModel.ISupportInitialize)priceInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewComputers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAddOrEdit;
        private TextBox modelInput;
        private Label label2;
        private DateTimePicker dateInput;
        private Label label3;
        private NumericUpDown priceInput;
        private TextBox clientNameInput;
        private Label label4;
        private TextBox clientTelephoneInput;
        private Label label5;
        private TextBox clientAddressInput;
        private Label label6;
        private Label label7;
        private TextBox noteInput;
        private Label label8;
        private ComboBox statusInput;
        private DataGridView dataGridViewComputers;
        private Label label9;
        private Label label10;
        private DataGridView dataGridViewClients;
        private Button btnPreview;
    }
}