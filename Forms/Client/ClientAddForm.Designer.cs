namespace ComputerMaster.Forms.Client
{
    partial class ClientAddForm
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
            btnAdd = new Button();
            label1 = new Label();
            surnameInput = new TextBox();
            nameInput = new TextBox();
            label2 = new Label();
            patronimycInput = new TextBox();
            label3 = new Label();
            emailInput = new TextBox();
            label4 = new Label();
            telephoneInput = new TextBox();
            label5 = new Label();
            addressInput = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(51, 461);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(302, 49);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "button1";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 37);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 1;
            label1.Text = "Фамилия клиента";
            // 
            // surnameInput
            // 
            surnameInput.Location = new Point(51, 65);
            surnameInput.Name = "surnameInput";
            surnameInput.Size = new Size(302, 33);
            surnameInput.TabIndex = 2;
            // 
            // nameInput
            // 
            nameInput.Location = new Point(51, 129);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(302, 33);
            nameInput.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 101);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 3;
            label2.Text = "Имя клиента";
            // 
            // patronimycInput
            // 
            patronimycInput.Location = new Point(51, 193);
            patronimycInput.Name = "patronimycInput";
            patronimycInput.Size = new Size(302, 33);
            patronimycInput.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 165);
            label3.Name = "label3";
            label3.Size = new Size(177, 25);
            label3.TabIndex = 5;
            label3.Text = "Отчество клиента";
            // 
            // emailInput
            // 
            emailInput.Location = new Point(51, 257);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(302, 33);
            emailInput.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 229);
            label4.Name = "label4";
            label4.Size = new Size(149, 25);
            label4.TabIndex = 7;
            label4.Text = "Почта клиента";
            // 
            // telephoneInput
            // 
            telephoneInput.Location = new Point(51, 321);
            telephoneInput.Name = "telephoneInput";
            telephoneInput.Size = new Size(302, 33);
            telephoneInput.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 293);
            label5.Name = "label5";
            label5.Size = new Size(171, 25);
            label5.TabIndex = 9;
            label5.Text = "Телефон клиента";
            // 
            // addressInput
            // 
            addressInput.Location = new Point(51, 385);
            addressInput.Name = "addressInput";
            addressInput.Size = new Size(302, 33);
            addressInput.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 357);
            label6.Name = "label6";
            label6.Size = new Size(149, 25);
            label6.TabIndex = 11;
            label6.Text = "Адрес клиента";
            // 
            // ClientAddForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 522);
            Controls.Add(addressInput);
            Controls.Add(label6);
            Controls.Add(telephoneInput);
            Controls.Add(label5);
            Controls.Add(emailInput);
            Controls.Add(label4);
            Controls.Add(patronimycInput);
            Controls.Add(label3);
            Controls.Add(nameInput);
            Controls.Add(label2);
            Controls.Add(surnameInput);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "ClientAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientAddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label label1;
        private TextBox surnameInput;
        private TextBox nameInput;
        private Label label2;
        private TextBox patronimycInput;
        private Label label3;
        private TextBox emailInput;
        private Label label4;
        private TextBox telephoneInput;
        private Label label5;
        private TextBox addressInput;
        private Label label6;
    }
}