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
            NameTextbox = new TextBox();
            LastNameTextbox = new TextBox();
            CityTextbox = new TextBox();
            StreetTextbox = new TextBox();
            StateTextbox = new TextBox();
            ZipTextbox = new TextBox();
            FirstNameLabel = new Label();
            LastNameLabel = new Label();
            CityLabel = new Label();
            StreetLabel = new Label();
            ZipLabel = new Label();
            StateLabel = new Label();
            Label = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
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
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(419, 377);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(119, 61);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // NameTextbox
            // 
            NameTextbox.Location = new Point(114, 26);
            NameTextbox.Name = "NameTextbox";
            NameTextbox.Size = new Size(251, 27);
            NameTextbox.TabIndex = 3;
            NameTextbox.TextChanged += Name_TextChanged;
            // 
            // LastNameTextbox
            // 
            LastNameTextbox.Location = new Point(114, 65);
            LastNameTextbox.Name = "LastNameTextbox";
            LastNameTextbox.Size = new Size(251, 27);
            LastNameTextbox.TabIndex = 4;
            // 
            // CityTextbox
            // 
            CityTextbox.Location = new Point(114, 164);
            CityTextbox.Name = "CityTextbox";
            CityTextbox.Size = new Size(251, 27);
            CityTextbox.TabIndex = 6;
            // 
            // StreetTextbox
            // 
            StreetTextbox.Location = new Point(114, 119);
            StreetTextbox.Name = "StreetTextbox";
            StreetTextbox.Size = new Size(251, 27);
            StreetTextbox.TabIndex = 5;
            // 
            // StateTextbox
            // 
            StateTextbox.Location = new Point(114, 213);
            StateTextbox.Name = "StateTextbox";
            StateTextbox.Size = new Size(251, 27);
            StateTextbox.TabIndex = 7;
            // 
            // ZipTextbox
            // 
            ZipTextbox.Location = new Point(114, 260);
            ZipTextbox.Name = "ZipTextbox";
            ZipTextbox.Size = new Size(251, 27);
            ZipTextbox.TabIndex = 8;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(9, 29);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(80, 20);
            FirstNameLabel.TabIndex = 9;
            FirstNameLabel.Text = "First Name";
            FirstNameLabel.Click += label1_Click;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(9, 72);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(79, 20);
            LastNameLabel.TabIndex = 10;
            LastNameLabel.Text = "Last Name";
            LastNameLabel.Click += label2_Click;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(9, 163);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(34, 20);
            CityLabel.TabIndex = 12;
            CityLabel.Text = "City";
            CityLabel.Click += label3_Click;
            // 
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Location = new Point(9, 118);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(105, 20);
            StreetLabel.TabIndex = 11;
            StreetLabel.Text = "Street Address";
            StreetLabel.Click += label4_Click;
            // 
            // ZipLabel
            // 
            ZipLabel.AutoSize = true;
            ZipLabel.Location = new Point(9, 259);
            ZipLabel.Name = "ZipLabel";
            ZipLabel.Size = new Size(70, 20);
            ZipLabel.TabIndex = 14;
            ZipLabel.Text = "Zip Code";
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.Location = new Point(9, 212);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(43, 20);
            StateLabel.TabIndex = 13;
            StateLabel.Text = "State";
            StateLabel.Click += label6_Click;
            // 
            // Label
            // 
            Label.Cursor = Cursors.Hand;
            Label.Font = new Font("Courier New", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label.Location = new Point(397, 32);
            Label.Name = "Label";
            Label.Size = new Size(391, 310);
            Label.TabIndex = 15;
            Label.Click += Label_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(NameTextbox);
            groupBox1.Controls.Add(LastNameTextbox);
            groupBox1.Controls.Add(ZipLabel);
            groupBox1.Controls.Add(StreetTextbox);
            groupBox1.Controls.Add(StateLabel);
            groupBox1.Controls.Add(CityTextbox);
            groupBox1.Controls.Add(CityLabel);
            groupBox1.Controls.Add(StateTextbox);
            groupBox1.Controls.Add(StreetLabel);
            groupBox1.Controls.Add(ZipTextbox);
            groupBox1.Controls.Add(LastNameLabel);
            groupBox1.Controls.Add(FirstNameLabel);
            groupBox1.Location = new Point(12, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(390, 298);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 450);
            Controls.Add(groupBox1);
            Controls.Add(Label);
            Controls.Add(ClearButton);
            Controls.Add(SubmitButton);
            Controls.Add(ExitButton);
            Cursor = Cursors.Hand;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private Button ExitButton;
        private Button SubmitButton;
        private Button ClearButton;
        private TextBox NameTextbox;
        private TextBox LastNameTextbox;
        private TextBox CityTextbox;
        private TextBox StreetTextbox;
        private TextBox StateTextbox;
        private TextBox ZipTextbox;
        private Label FirstNameLabel;
        private Label LastNameLabel;
        private Label CityLabel;
        private Label StreetLabel;
        private Label ZipLabel;
        private Label StateLabel;
        private Label Label;
        private GroupBox groupBox1;
    }
}
