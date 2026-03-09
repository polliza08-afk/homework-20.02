namespace homework
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
            btnSetInfo = new Button();
            SuspendLayout();
            // 
            // btnSetInfo
            // 
            btnSetInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSetInfo.Location = new Point(120, 91);
            btnSetInfo.Name = "btnSetInfo";
            btnSetInfo.Size = new Size(121, 73);
            btnSetInfo.TabIndex = 0;
            btnSetInfo.Text = "Вказати інформацію";
            btnSetInfo.UseVisualStyleBackColor = true;
            btnSetInfo.Click += btnSetInfo_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 266);
            Controls.Add(btnSetInfo);
            Name = "MainForm";
            Text = "Інформація";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSetInfo;
    }
}
