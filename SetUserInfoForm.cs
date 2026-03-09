using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework
{
    public partial class SetUserInfoForm : Form
    {
        public SetUserInfoForm()
        {
            InitializeComponent();
        }

        private void txtPIB_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPIB.Text))
            {
                MessageBox.Show("Будь ласка, введіть ПІБ");
                txtPIB.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Будь ласка, введіть номер телефону");
                txtPhone.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Будь ласка, введіть вік");
                txtAge.Focus();
                return;
            }

            int age;
            if (!int.TryParse(txtAge.Text, out age) || age <= 0)
            {
                MessageBox.Show("Вік повинен бути числом більше 0");
                txtAge.Focus();
                return;
            }

            MessageBox.Show("Дані збережені!");
        }
    }
}
