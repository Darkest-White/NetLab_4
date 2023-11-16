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
    public partial class FormSubject : Form
    {
        public Subject Subject { get; }
        public FormSubject(Subject subject)
        {
            InitializeComponent();
            Subject = subject;
            textBoxTitle.Text = Subject.Title;
            numericUpDownLectures.Value = Subject.Lectures;
            numericUpDownPractices.Value = Subject.Practices;
            numericUpDownLaboratoryWorks.Value = Subject.LaboratoryWorks;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Subject.Title = textBoxTitle.Text;
            Subject.Lectures = (int)numericUpDownLectures.Value;
            Subject.Practices = (int)numericUpDownPractices.Value;
            Subject.LaboratoryWorks = (int)numericUpDownLaboratoryWorks.Value;
        }
    }
}
