using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryFacultative;

namespace NetLab_4._2
{
    public partial class FormStudent : Form
    {
        public Student Student { get; }

        public FormStudent(Student student)
        {
            InitializeComponent();
            Student = student;
            textBoxFirstName.Text = Student.FirstName;
            textBoxMiddleName.Text = Student.MiddleName;
            textBoxLastName.Text = Student.LastName;

            textBoxStreet.Text = Student.Adress.Street;
            textBoxHouse.Text = Student.Adress.House;
            textBoxFlat.Text = Student.Adress.Flat;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Student.FirstName = textBoxFirstName.Text;
            Student.MiddleName = textBoxMiddleName.Text;
            Student.LastName = textBoxLastName.Text;

            Student.Adress.Street = textBoxStreet.Text;
            Student.Adress.House = textBoxHouse.Text;
            Student.Adress.Flat = textBoxFlat.Text;
        }
    }
}
