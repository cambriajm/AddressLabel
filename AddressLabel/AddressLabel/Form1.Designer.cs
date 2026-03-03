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
            components = new System.ComponentModel.Container();
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
            TopMenuStrip = new ContextMenuStrip(components);
            helpToolStripMenuItem = new ToolStripMenuItem();
            broskiToolStripMenuItem = new ToolStripMenuItem();
            TopMenuStrip.SuspendLayout();
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
            NameTextbox.Location = new Point(117, 42);
            NameTextbox.Name = "NameTextbox";
            NameTextbox.Size = new Size(251, 27);
            NameTextbox.TabIndex = 3;
            NameTextbox.TextChanged += Name_TextChanged;
            // 
            // LastNameTextbox
            // 
            LastNameTextbox.Location = new Point(117, 81);
            LastNameTextbox.Name = "LastNameTextbox";
            LastNameTextbox.Size = new Size(251, 27);
            LastNameTextbox.TabIndex = 4;
            // 
            // CityTextbox
            // 
            CityTextbox.Location = new Point(117, 180);
            CityTextbox.Name = "CityTextbox";
            CityTextbox.Size = new Size(251, 27);
            CityTextbox.TabIndex = 6;
            // 
            // StreetTextbox
            // 
            StreetTextbox.Location = new Point(117, 135);
            StreetTextbox.Name = "StreetTextbox";
            StreetTextbox.Size = new Size(251, 27);
            StreetTextbox.TabIndex = 5;
            // 
            // StateTextbox
            // 
            StateTextbox.Location = new Point(117, 229);
            StateTextbox.Name = "StateTextbox";
            StateTextbox.Size = new Size(251, 27);
            StateTextbox.TabIndex = 7;
            // 
            // ZipTextbox
            // 
            ZipTextbox.Location = new Point(117, 276);
            ZipTextbox.Name = "ZipTextbox";
            ZipTextbox.Size = new Size(251, 27);
            ZipTextbox.TabIndex = 8;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(12, 45);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(80, 20);
            FirstNameLabel.TabIndex = 9;
            FirstNameLabel.Text = "First Name";
            FirstNameLabel.Click += label1_Click;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(12, 88);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(79, 20);
            LastNameLabel.TabIndex = 10;
            LastNameLabel.Text = "Last Name";
            LastNameLabel.Click += label2_Click;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(12, 179);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(34, 20);
            CityLabel.TabIndex = 12;
            CityLabel.Text = "City";
            CityLabel.Click += label3_Click;
            // 
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Location = new Point(12, 134);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(105, 20);
            StreetLabel.TabIndex = 11;
            StreetLabel.Text = "Street Address";
            StreetLabel.Click += label4_Click;
            // 
            // ZipLabel
            // 
            ZipLabel.AutoSize = true;
            ZipLabel.Location = new Point(12, 275);
            ZipLabel.Name = "ZipLabel";
            ZipLabel.Size = new Size(70, 20);
            ZipLabel.TabIndex = 14;
            ZipLabel.Text = "Zip Code";
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.Location = new Point(12, 228);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(43, 20);
            StateLabel.TabIndex = 13;
            StateLabel.Text = "State";
            StateLabel.Click += label6_Click;
            // 
            // Label
            // 
            Label.Cursor = Cursors.Hand;
            Label.Font = new Font("Wingdings", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 2);
            Label.Location = new Point(397, 32);
            Label.Name = "Label";
            Label.Size = new Size(391, 310);
            Label.TabIndex = 15;
            Label.Click += Label_Click;
            // 
            // TopMenuStrip
            // 
            TopMenuStrip.AllowDrop = true;
            TopMenuStrip.ImageScalingSize = new Size(20, 20);
            TopMenuStrip.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem, broskiToolStripMenuItem });
            TopMenuStrip.Name = "contextMenuStrip1";
            TopMenuStrip.Size = new Size(119, 52);
            TopMenuStrip.Text = "Menu";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(118, 24);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // broskiToolStripMenuItem
            // 
            broskiToolStripMenuItem.Name = "broskiToolStripMenuItem";
            broskiToolStripMenuItem.Size = new Size(118, 24);
            broskiToolStripMenuItem.Text = "&Broski";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Label);
            Controls.Add(ZipLabel);
            Controls.Add(StateLabel);
            Controls.Add(CityLabel);
            Controls.Add(StreetLabel);
            Controls.Add(LastNameLabel);
            Controls.Add(FirstNameLabel);
            Controls.Add(ZipTextbox);
            Controls.Add(StateTextbox);
            Controls.Add(CityTextbox);
            Controls.Add(StreetTextbox);
            Controls.Add(LastNameTextbox);
            Controls.Add(NameTextbox);
            Controls.Add(ClearButton);
            Controls.Add(SubmitButton);
            Controls.Add(ExitButton);
            Cursor = Cursors.No;
            Name = "Form1";
            Text = "Form1";
            TopMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private ContextMenuStrip TopMenuStrip;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem broskiToolStripMenuItem;
    }
}
