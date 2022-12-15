using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BohatecTest121222
{
    public partial class FormEditing : Form
    {
        SqlRepository sqlRepository = new SqlRepository();

        Form1 form1 = new Form1();
        public FormEditing()
        {
            InitializeComponent();
        }
        public void LoadInput(string id, string firstname, string lastname, string email, string phone, DateTime birthday)
        {
            labelId.Text = id;
            textBoxFirstname.Text = firstname;
            textBoxLastname.Text = lastname;
            textBoxEmail.Text = email;
            textBoxPhone.Text = phone;
            dateTimePickerBirthday.Value = birthday;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            sqlRepository.EditExistingRecord(labelId.Text, textBoxFirstname.Text, textBoxLastname.Text, textBoxEmail.Text, textBoxPhone.Text, Convert.ToDateTime(dateTimePickerBirthday.Value));
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
