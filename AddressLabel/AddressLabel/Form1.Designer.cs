namespace AddressLabel
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
            ExitButton = new Button();
            SubmitButton = new Button();
            ClearButton = new Button();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(669, 377);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(119, 61);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "&Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(544, 377);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(119, 61);
            SubmitButton.TabIndex = 1;
            SubmitButton.Text = "&Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(419, 377);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(119, 61);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClearButton);
            Controls.Add(SubmitButton);
            Controls.Add(ExitButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button ExitButton;
        private Button SubmitButton;
        private Button ClearButton;
    }
}
