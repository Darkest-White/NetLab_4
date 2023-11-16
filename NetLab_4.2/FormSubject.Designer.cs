namespace NetLab_4._2
{
    partial class FormSubject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.numericUpDownLectures = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPractices = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLaboratoryWorks = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLectures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPractices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLaboratoryWorks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Объём лекций:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Объём практик:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Объём лабораторных работ:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(196, 169);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(170, 25);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitle.TabIndex = 7;
            // 
            // numericUpDownLectures
            // 
            this.numericUpDownLectures.Location = new System.Drawing.Point(169, 61);
            this.numericUpDownLectures.Name = "numericUpDownLectures";
            this.numericUpDownLectures.Size = new System.Drawing.Size(101, 20);
            this.numericUpDownLectures.TabIndex = 9;
            // 
            // numericUpDownPractices
            // 
            this.numericUpDownPractices.Location = new System.Drawing.Point(169, 96);
            this.numericUpDownPractices.Name = "numericUpDownPractices";
            this.numericUpDownPractices.Size = new System.Drawing.Size(101, 20);
            this.numericUpDownPractices.TabIndex = 10;
            // 
            // numericUpDownLaboratoryWorks
            // 
            this.numericUpDownLaboratoryWorks.Location = new System.Drawing.Point(169, 131);
            this.numericUpDownLaboratoryWorks.Name = "numericUpDownLaboratoryWorks";
            this.numericUpDownLaboratoryWorks.Size = new System.Drawing.Size(101, 20);
            this.numericUpDownLaboratoryWorks.TabIndex = 11;
            // 
            // FormSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 204);
            this.Controls.Add(this.numericUpDownLaboratoryWorks);
            this.Controls.Add(this.numericUpDownPractices);
            this.Controls.Add(this.numericUpDownLectures);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSubject";
            this.Text = "Предмет";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLectures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPractices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLaboratoryWorks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.NumericUpDown numericUpDownLectures;
        private System.Windows.Forms.NumericUpDown numericUpDownPractices;
        private System.Windows.Forms.NumericUpDown numericUpDownLaboratoryWorks;
    }
}