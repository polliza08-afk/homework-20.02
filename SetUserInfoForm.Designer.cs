namespace homework
{
    partial class SetUserInfoForm
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
            txtPIB = new RichTextBox();
            label1 = new Label();
            txtPhone = new RichTextBox();
            label2 = new Label();
            txtAge = new RichTextBox();
            label3 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtPIB
            // 
            txtPIB.Location = new Point(12, 33);
            txtPIB.Name = "txtPIB";
            txtPIB.Size = new Size(492, 29);
            txtPIB.TabIndex = 0;
            txtPIB.Text = "";
            txtPIB.Click += txtPIB_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(37, 21);
            label1.TabIndex = 1;
            label1.Text = "ПІБ";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 156);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(492, 29);
            txtPhone.TabIndex = 0;
            txtPhone.Text = "";
            txtPhone.Click += txtPIB_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 132);
            label2.Name = "label2";
            label2.Size = new Size(140, 21);
            label2.TabIndex = 1;
            label2.Text = "Номер телефону";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(12, 93);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(492, 29);
            txtAge.TabIndex = 0;
            txtAge.Text = "";
            txtAge.Click += txtPIB_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 69);
            label3.Name = "label3";
            label3.Size = new Size(32, 21);
            label3.TabIndex = 1;
            label3.Text = "Вік";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            btnSave.Location = new Point(12, 204);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 54);
            btnSave.TabIndex = 2;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // SetUserInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 277);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAge);
            Controls.Add(txtPhone);
            Controls.Add(txtPIB);
            Name = "SetUserInfoForm";
            Text = "SetUserInfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtPIB;
        private Label label1;
        private RichTextBox txtPhone;
        private Label label2;
        private RichTextBox txtAge;
        private Label label3;
        private Button btnSave;
    }
}