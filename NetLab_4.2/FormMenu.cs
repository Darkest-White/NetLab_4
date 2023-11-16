using ClassLibraryFacultative;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetLab_4._2
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void addStudentToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            _student = new Student();
            FormStudent formStudent = new FormStudent(_student);
            if (formStudent.ShowDialog() == DialogResult.OK)
            {
                _student = formStudent.Student;
            }
        }

        private void editStudentToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FormStudent formStudent = new FormStudent(_student);
            if (formStudent.ShowDialog() == DialogResult.OK)
            {
                _student = formStudent.Student;
            }
        }

        private void addSubjectToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            _subject = new Subject();
            FormSubject formSubject = new FormSubject(_subject);
            if (formSubject.ShowDialog() == DialogResult.OK)
            {
                _subject = formSubject.Subject;
            }
        }

        private void editSubjectToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            FormSubject formSubject = new FormSubject(_subject);
            if (formSubject.ShowDialog() == DialogResult.OK)
            {
                _subject = formSubject.Subject;
            }
        }
    }
}
