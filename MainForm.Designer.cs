namespace ComputerMaster
{
    partial class MainForm
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
            btnGoToClientListForm = new Button();
            btnGoToComputerListForm = new Button();
            btnGoToCommissionListForm = new Button();
            SuspendLayout();
            // 
            // btnGoToClientListForm
            // 
            btnGoToClientListForm.Location = new Point(74, 107);
            btnGoToClientListForm.Name = "btnGoToClientListForm";
            btnGoToClientListForm.Size = new Size(246, 42);
            btnGoToClientListForm.TabIndex = 0;
            btnGoToClientListForm.Text = "Клиенты";
            btnGoToClientListForm.UseVisualStyleBackColor = true;
            // 
            // btnGoToComputerListForm
            // 
            btnGoToComputerListForm.Location = new Point(74, 200);
            btnGoToComputerListForm.Name = "btnGoToComputerListForm";
            btnGoToComputerListForm.Size = new Size(246, 42);
            btnGoToComputerListForm.TabIndex = 1;
            btnGoToComputerListForm.Text = "Компьютеры";
            btnGoToComputerListForm.UseVisualStyleBackColor = true;
            // 
            // btnGoToCommissionListForm
            // 
            btnGoToCommissionListForm.Location = new Point(74, 291);
            btnGoToCommissionListForm.Name = "btnGoToCommissionListForm";
            btnGoToCommissionListForm.Size = new Size(246, 42);
            btnGoToCommissionListForm.TabIndex = 2;
            btnGoToCommissionListForm.Text = "Заказы";
            btnGoToCommissionListForm.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 498);
            Controls.Add(btnGoToCommissionListForm);
            Controls.Add(btnGoToComputerListForm);
            Controls.Add(btnGoToClientListForm);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 5, 5, 5);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главное меню";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGoToClientListForm;
        private Button btnGoToComputerListForm;
        private Button btnGoToCommissionListForm;
    }
}
