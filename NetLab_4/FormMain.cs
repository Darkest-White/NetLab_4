using System;
using System.Windows.Forms;
using ClassLibraryFacultatives;
using NetLab_4;

namespace NetLab_4
{
    public partial class FormMain : Form
    {
        private Student _student;
        private Subject _subject;
        public FormMain()
        {
            InitializeComponent();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _student = new Student();
            FormStudent formStudent = new FormStudent(_student);
            if (formStudent.ShowDialog() == DialogResult.OK)
            {
                _student = formStudent.Student;
            }
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStudent formStudent = new FormStudent(_student);
            if (formStudent.ShowDialog() == DialogResult.OK)
            {
                _student = formStudent.Student;
            }
        }

        private void addSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _subject = new Subject();
            FormSubject formSubject = new FormSubject(_subject);
            if (formSubject.ShowDialog() == DialogResult.OK)
            {
                _subject = formSubject.Subject;
            }
        }

        private void editSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSubject formSubject = new FormSubject(_subject);
            if (formSubject.ShowDialog() == DialogResult.OK)
            {
                _subject = formSubject.Subject;
            }
        }
    }
}