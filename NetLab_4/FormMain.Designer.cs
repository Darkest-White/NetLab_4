namespace NetLab_4
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studyPlanstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudyPlantoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editStudyPlantoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.subjectsToolStripMenuItem,
            this.studyPlanstoolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientToolStripMenuItem,
            this.editClientToolStripMenuItem});
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.studentsToolStripMenuItem.Text = "Студенты";
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addClientToolStripMenuItem.Text = "Добавить";
            this.addClientToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // editClientToolStripMenuItem
            // 
            this.editClientToolStripMenuItem.Name = "editClientToolStripMenuItem";
            this.editClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editClientToolStripMenuItem.Text = "Редактировать";
            this.editClientToolStripMenuItem.Click += new System.EventHandler(this.editStudentToolStripMenuItem_Click);
            // 
            // subjectsToolStripMenuItem
            // 
            this.subjectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRoomToolStripMenuItem,
            this.editRoomToolStripMenuItem});
            this.subjectsToolStripMenuItem.Name = "subjectsToolStripMenuItem";
            this.subjectsToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.subjectsToolStripMenuItem.Text = "Предметы";
            // 
            // addRoomToolStripMenuItem
            // 
            this.addRoomToolStripMenuItem.Name = "addRoomToolStripMenuItem";
            this.addRoomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addRoomToolStripMenuItem.Text = "Добавить";
            this.addRoomToolStripMenuItem.Click += new System.EventHandler(this.addSubjectToolStripMenuItem_Click);
            // 
            // editRoomToolStripMenuItem
            // 
            this.editRoomToolStripMenuItem.Name = "editRoomToolStripMenuItem";
            this.editRoomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editRoomToolStripMenuItem.Text = "Редактировать";
            this.editRoomToolStripMenuItem.Click += new System.EventHandler(this.editSubjectToolStripMenuItem_Click);
            // 
            // studyPlanstoolStripMenuItem
            // 
            this.studyPlanstoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudyPlantoolStripMenuItem1,
            this.editStudyPlantoolStripMenuItem2});
            this.studyPlanstoolStripMenuItem.Name = "studyPlanstoolStripMenuItem";
            this.studyPlanstoolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.studyPlanstoolStripMenuItem.Text = "Учебные планы";
            // 
            // addStudyPlantoolStripMenuItem1
            // 
            this.addStudyPlantoolStripMenuItem1.Name = "addStudyPlantoolStripMenuItem1";
            this.addStudyPlantoolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.addStudyPlantoolStripMenuItem1.Text = "Добавить";
            // 
            // editStudyPlantoolStripMenuItem2
            // 
            this.editStudyPlantoolStripMenuItem2.Name = "editStudyPlantoolStripMenuItem2";
            this.editStudyPlantoolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.editStudyPlantoolStripMenuItem2.Text = "Редактировать";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 267);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Отель";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studyPlanstoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudyPlantoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editStudyPlantoolStripMenuItem2;
    }
}