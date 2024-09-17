namespace Assignment1
{
    public partial class frnMain : Form
    {
        public frnMain()
        {
            InitializeComponent();
        }
        const double HOURLY_RATE = 10.50;



        private void clear_Click(object sender, EventArgs e)
        {
            summaryLabel.Text = "";
            fnameTextBox.Text = "";
            lnameTextBox.Text = "";
            workTextBox.Text = "";
        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(workTextBox.Text) < 0)
                {
                    throw new Exception("negative");
                }
                string combinedText = $"{fnameTextBox.Text} {lnameTextBox.Text} worked {int.Parse(workTextBox.Text)} hours at ${HOURLY_RATE} an hour for a total of ${int.Parse(workTextBox.Text) * HOURLY_RATE}";
                summaryLabel.Text = combinedText;
                summaryLabel.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                summaryLabel.Text = "Please Enter a Valid number";
                summaryLabel.ForeColor = Color.Red;
            }
        }

        private void lnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void fnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
