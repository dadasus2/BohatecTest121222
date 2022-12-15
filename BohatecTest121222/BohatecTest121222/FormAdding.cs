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
    public partial class FormAdding : Form
    {
        SqlRepository sqlRepository = new SqlRepository();
        public FormAdding()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            sqlRepository.AddNewRecord(textBoxFirstname.Text, textBoxLastname.Text, textBoxEmail.Text, textBoxPhone.Text, dateTimePickerBirthday.Value);
            
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
