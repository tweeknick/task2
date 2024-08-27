namespace WinFormsApp6
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
            txtBox = new TextBox();
            checkPal = new Button();
            label = new Label();
            SuspendLayout();
            // 
            // txtBox
            // 
            txtBox.Font = new Font("Times New Roman", 9F);
            txtBox.Location = new Point(101, 115);
            txtBox.Multiline = true;
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(166, 29);
            txtBox.TabIndex = 0;
            // 
            // checkPal
            // 
            checkPal.Cursor = Cursors.Hand;
            checkPal.Font = new Font("Times New Roman", 9F);
            checkPal.Location = new Point(147, 150);
            checkPal.Name = "checkPal";
            checkPal.Size = new Size(79, 26);
            checkPal.TabIndex = 1;
            checkPal.Text = "Перевірити";
            checkPal.UseVisualStyleBackColor = true;
            checkPal.Click += checkPal_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Times New Roman", 9F);
            label.Location = new Point(101, 196);
            label.Name = "label";
            label.Size = new Size(35, 15);
            label.TabIndex = 2;
            label.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 228, 121);
            ClientSize = new Size(347, 336);
            Controls.Add(label);
            Controls.Add(checkPal);
            Controls.Add(txtBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox;
        private Button checkPal;
        private Label label;
    }
}
