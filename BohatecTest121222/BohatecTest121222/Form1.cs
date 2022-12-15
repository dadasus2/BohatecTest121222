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
    public partial class Form1 : Form
    {
        List<Employee> employees;
        SqlRepository sqlRepository = new SqlRepository();
        public Form1()
        {
            InitializeComponent();
            employees = sqlRepository.GetEmployees();
            LoadEmployees();
        }
        public void LoadEmployees()
        {
            listView1.Items.Clear();
            foreach (Employee employee in employees)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] {
                    employee.Id.ToString(),
                    employee.Firstname.ToString(),
                    employee.Lastname.ToString(),
                    employee.Email.ToString(),
                    employee.Phone.ToString(),
                    employee.Birthday.ToString("dd.MM.yyyy")
                });
                listView1.Items.Add(listViewItem);
                listView1.Refresh();
            }
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormAdding formAdding = new FormAdding();
            formAdding.Show();
        }

        private void buttonEditRecord_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nebyl vybrán řádek!");
            }
            else
            {
                this.Hide();

                FormEditing formEditing = new FormEditing();
                formEditing.Show();

                var clickedRow = listView1.SelectedItems[0];

                var id = clickedRow.SubItems[0].Text;
                var firstname = clickedRow.SubItems[1].Text;
                var lastname = clickedRow.SubItems[2].Text;
                var email = clickedRow.SubItems[3].Text;
                var phone = clickedRow.SubItems[4].Text;
                var birthday = clickedRow.SubItems[5].Text;

                formEditing.LoadInput(id, firstname, lastname, email, phone, Convert.ToDateTime(birthday));
            }
        }

        private void buttonDeleteRecord_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nebyl vybrán řádek!");
            }
            else
            {
                var clickedRow = listView1.SelectedItems[0];

                var idValue = clickedRow.SubItems[0].Text;

                sqlRepository.DeleteSelectedEmployee(idValue);
                listView1.SelectedItems[0].Remove();
            }
        }
    }
}
