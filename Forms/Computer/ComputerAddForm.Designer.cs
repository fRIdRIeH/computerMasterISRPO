namespace ComputerMaster.Forms.Computer
{
    partial class ComputerAddForm
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
            btn = new Button();
            modelInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            processorInput = new TextBox();
            label3 = new Label();
            ramInput = new TextBox();
            label4 = new Label();
            hddInput = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            descriptionInput = new TextBox();
            priceInput = new NumericUpDown();
            amountInput = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)priceInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountInput).BeginInit();
            SuspendLayout();
            // 
            // btn
            // 
            btn.Location = new Point(36, 521);
            btn.Name = "btn";
            btn.Size = new Size(297, 47);
            btn.TabIndex = 0;
            btn.Text = "button1";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // modelInput
            // 
            modelInput.Location = new Point(36, 48);
            modelInput.Name = "modelInput";
            modelInput.Size = new Size(297, 33);
            modelInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 20);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 2;
            label1.Text = "Модель";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 84);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 4;
            label2.Text = "Процессор";
            // 
            // processorInput
            // 
            processorInput.Location = new Point(36, 112);
            processorInput.Name = "processorInput";
            processorInput.Size = new Size(297, 33);
            processorInput.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 148);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 6;
            label3.Text = "ОЗУ";
            // 
            // ramInput
            // 
            ramInput.Location = new Point(36, 176);
            ramInput.Name = "ramInput";
            ramInput.Size = new Size(297, 33);
            ramInput.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 212);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 8;
            label4.Text = "ПЗУ";
            // 
            // hddInput
            // 
            hddInput.Location = new Point(36, 240);
            hddInput.Name = "hddInput";
            hddInput.Size = new Size(297, 33);
            hddInput.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 276);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 10;
            label5.Text = "Цена";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 340);
            label6.Name = "label6";
            label6.Size = new Size(121, 25);
            label6.TabIndex = 12;
            label6.Text = "Количество";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 404);
            label7.Name = "label7";
            label7.Size = new Size(103, 25);
            label7.TabIndex = 14;
            label7.Text = "Описание";
            // 
            // descriptionInput
            // 
            descriptionInput.Location = new Point(36, 432);
            descriptionInput.Name = "descriptionInput";
            descriptionInput.Size = new Size(297, 33);
            descriptionInput.TabIndex = 13;
            // 
            // priceInput
            // 
            priceInput.Location = new Point(36, 304);
            priceInput.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            priceInput.Name = "priceInput";
            priceInput.Size = new Size(297, 33);
            priceInput.TabIndex = 15;
            // 
            // amountInput
            // 
            amountInput.Location = new Point(36, 368);
            amountInput.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            amountInput.Name = "amountInput";
            amountInput.Size = new Size(297, 33);
            amountInput.TabIndex = 16;
            // 
            // ComputerAddForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 580);
            Controls.Add(amountInput);
            Controls.Add(priceInput);
            Controls.Add(label7);
            Controls.Add(descriptionInput);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(hddInput);
            Controls.Add(label3);
            Controls.Add(ramInput);
            Controls.Add(label2);
            Controls.Add(processorInput);
            Controls.Add(label1);
            Controls.Add(modelInput);
            Controls.Add(btn);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "ComputerAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ComputerAddForm";
            ((System.ComponentModel.ISupportInitialize)priceInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn;
        private TextBox modelInput;
        private Label label1;
        private Label label2;
        private TextBox processorInput;
        private Label label3;
        private TextBox ramInput;
        private Label label4;
        private TextBox hddInput;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox descriptionInput;
        private NumericUpDown priceInput;
        private NumericUpDown amountInput;
    }
}