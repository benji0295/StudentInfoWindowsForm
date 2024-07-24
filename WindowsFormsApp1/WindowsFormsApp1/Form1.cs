using System;
using System.Collections;
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
    struct Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public MonthOfAdmission AdmissionMonth { get; set; }
        public string Grade { get; set; }
    }
    public partial class Form1 : Form
    {
        ArrayList students = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            InitializeStartingData();
            RefreshDataGridView();
        }

        private void InitializeStartingData()
        {
            students.Add(new Student { StudentID = 12345, FirstName = "John", LastName = "Doe", Address = "123 Main St", AdmissionMonth = MonthOfAdmission.January, Grade = "A" });
            students.Add(new Student { StudentID = 23456, FirstName = "Jane", LastName = "Smith", Address = "456 Elm St", AdmissionMonth = MonthOfAdmission.February, Grade = "B" });
            students.Add(new Student { StudentID = 34567, FirstName = "Bob", LastName = "Jones", Address = "789 Oak St", AdmissionMonth = MonthOfAdmission.March, Grade = "C" });
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    Student student = new Student
                    {
                        StudentID = form2.StudentID,
                        FirstName = form2.FirstName,
                        LastName = form2.LastName,
                        Address = form2.Address,
                        AdmissionMonth = form2.AdmissionMonth,
                        Grade = form2.Grade,
                    };

                    students.Add(student);
                    RefreshDataGridView();
                }
            }
        }

        private void RefreshDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                students.RemoveAt(dataGridView1.SelectedRows[0].Index);
                RefreshDataGridView();
            }
        }
    }
}
