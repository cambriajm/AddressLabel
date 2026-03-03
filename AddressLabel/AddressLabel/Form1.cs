namespace AddressLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetDefaults();
        }

        void SetDefaults()
        {
            NameTextbox.Text = "";
            LastNameTextbox.Text = "";
            StreetTextbox.Text = "";
            StateTextbox.Text = "";
            CityTextbox.Text = "";
            ZipTextbox.Text = "";

            SubmitButton.Enabled = true;
        }





        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }


        private bool ValidateFields()
        {
            bool valid = false;
            string message = "";

            if (ZipTextbox.Text == "")
            {
                message = "Zip Code is required\n" + message;

            }

            if (StateTextbox.Text == "")
            {
                message = "State is required\n" + message;
                StateTextbox.Focus();
            }

            if (StreetTextbox.Text == "")
            {
                message = "Street Address is required\n" + message;
                StreetTextbox.Focus();
            }

            if (LastNameTextbox.Text == "")
            {
                message = "Last Name is required";
                LastNameTextbox.Focus();
            }

            if (NameTextbox.Text == "")
            {
                message = "First name is required\n" + message;
                NameTextbox.Focus();
            }
            if (message != "")
            {
                MessageBox.Show(message);
            }
            return true;

        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {


            {
                Label.Text = NameTextbox.Text + LastNameTextbox.Text +
                    StreetTextbox.Text + CityTextbox.Text
                    + StateTextbox.Text + ZipTextbox.Text;




                SubmitButton.Enabled = true;
            }

        }



        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void Label_Click(object sender, EventArgs e)
        {

        }

        private void Label_CursorChanged(object sender, EventArgs e)
        {

        }

        private void Label_CursorChanged_1(object sender, EventArgs e)
        {

        }
    }
}
