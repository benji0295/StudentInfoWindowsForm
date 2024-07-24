using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public MonthOfAdmission AdmissionMonth { get; set; }
        public string Grade { get; set; }
        public Form2()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            monthComboBox.DataSource = Enum.GetValues(typeof(MonthOfAdmission));
            gradeComboBox.Items.AddRange(new string[] { "A", "B", "C", "D", "F" });
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                StudentID = int.Parse(studentIDBox.Text);
                FirstName = firstNameBox.Text;
                LastName = lastNameBox.Text;
                Address = addressBox.Text;
                AdmissionMonth = (MonthOfAdmission)monthComboBox.SelectedItem;
                Grade = gradeComboBox.SelectedItem.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error entering student information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}
