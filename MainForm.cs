namespace homework
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSetInfo_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Тут буде відкриватися нова форма!");

            SetUserInfoForm setUserInfoForm = new SetUserInfoForm();
            setUserInfoForm.ShowDialog();
        }
    }
}
