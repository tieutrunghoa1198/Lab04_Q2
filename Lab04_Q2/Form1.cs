using Lab04_Q2.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Lab04_Q2
{
    public partial class Form1 : Form
    {
        private List<EmployeeTable> employees;
        private PeFall21B5Context asd;
        public Form1()
        {
            employees = new List<EmployeeTable>();
            
            InitializeComponent();
            getAll();
        }

        private void getAll()
        {
            employees.Clear();
            var asd = new PeFall21B5Context();
            asd.Employees.ToList().ForEach(e =>
            {
                Console.WriteLine(e.Dob.ToString("dd/MM/yyyy"));
                employees.Add(new EmployeeTable()
                {
                    Id = e.Id,
                    Name = e.Name,
                    Sex = e.Sex,
                    Dob = e.Dob.ToString("dd/MM/yyyy").Replace("-", "/"),
                    Position = e.Position
                });
            });
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = employees;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var employeeId = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            idtext.Text = employeeId;
            nametext.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            dateTimePicker1.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());
            comboBox1.SelectedIndex = comboBox1.FindString(dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
            var male = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            if (male.Equals("Male"))
            {
                maleradio.Checked = true;
            } else femaleradio.Checked = true;
        }

        private void refresh()
        {
            idtext.Text = "";
            nametext.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = 0;
            maleradio.Checked = false;
            femaleradio.Checked = false;
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            var asd = new PeFall21B5Context();
            string sex = "";
            string selected = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            string position = comboBox1.SelectedText;
            if (maleradio.Checked)
            {
                sex = "Male";
            } else sex = "Female";

            try
            {
                asd.Employees.Add(new Employee()
                {
                    Name = nametext.Text,
                    Dob = dateTimePicker1.Value,
                    Sex = sex,
                    Position = selected
                });
                asd.SaveChanges();
                getAll();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            var asd = new PeFall21B5Context();
            string sex = "";
            string selected = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            string position = comboBox1.SelectedText;
            if (maleradio.Checked)
            {
                sex = "Male";
            }
            else sex = "Female";

            try
            {
                asd.Entry<Employee>(new Employee()
                {
                    Id = Int32.Parse(idtext.Text),
                    Name = nametext.Text,
                    Dob = dateTimePicker1.Value,
                    Sex = sex,
                    Position = selected
                }).State = EntityState.Modified;
                asd.SaveChanges();
                getAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}