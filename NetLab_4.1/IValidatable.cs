using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFacultative
{
    interface IValidatable
    {
        bool IsValid { get; }
    }

    public class Adress
    {
        /// <summary>
        /// Улица
        /// </summary>
        public string Street { get; set; } = "000000";

        /// <summary>
        /// Дом
        /// </summary>
        public string House { get; set; } = "00";

        /// <summary>
        /// Квартира
        /// </summary>
        public string Flat { get; set; } = "0";

        public override string ToString()
        {
            return $"{Street} {House} {Flat}";
        }
    }

    public class Student : IValidatable
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; } = "";

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; } = "";

        /// <summary>
        /// Отчество
        /// </summary>
        public string MiddleName { get; set; } = "";

        /// <summary>
        /// Адрес
        /// </summary>
        public Adress Adress { get; set; } = new Adress();

        public bool IsValid
        {
            get
            {
                if (string.IsNullOrWhiteSpace(FirstName)) return false;
                if (string.IsNullOrWhiteSpace(MiddleName)) return false;
                if (string.IsNullOrWhiteSpace(LastName)) return false;
                if (Adress == null) return false;
                return true;
            }
        }

        public Student()
        {

        }

        public Student(string firstName, string lastName, string middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }

        public override string ToString()
        {
            return $"Фамилия: {LastName}\r\nИмя: {FirstName}\r\nОтчество: {MiddleName}\r\nАдрес: {Adress}\r\n";
        }
    }

    public class Subject : IValidatable
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Title { get; set; } = "";

        /// <summary>
        /// Лекции
        /// </summary>
        public int Lectures { get; set; } = 1;

        /// <summary>
        /// Практики
        /// </summary>
        public int Practices { get; set; } = 1;

        /// <summary>
        /// Лабораторные работы
        /// </summary>
        public int LaboratoryWorks { get; set; } = 1;

        public bool IsValid
        {
            get
            {
                if (Lectures < 1) return false;
                if (Practices < 1) return false;
                if (LaboratoryWorks < 1) return false;
                return true;
            }
        }

        public Subject()
        {

        }

        public Subject(string title, int lectures, int practices, int laboratoryWorks)
        {
            Title = title;
            Lectures = lectures;
            Practices = practices;
            LaboratoryWorks = laboratoryWorks;
        }

        public override string ToString()
        {
            return
                $"Идентификатор: {Title}\r\nКатегория: {Lectures}\r\nСтоимость в сутки:{Practices}\r\nКоличество мест:{LaboratoryWorks}\r\n";
        }
    }

    public class StudyPlan
    {
        /// <summary>
        /// Студент
        /// </summary>
        public Student Student { get; set; }

        /// <summary>
        /// Предмет
        /// </summary>
        public Subject Subject { get; set; }

        /// <summary>
        /// Оценка
        /// </summary>
        public int Mark { get; set; }

        public bool IsValid
        {
            get
            {
                if (Student == null) return false;
                if (Subject == null) return false;
                return true;
            }
        }

        public StudyPlan()
        {

        }

        public StudyPlan(Student student, Subject subject, int mark)
        {
            Student = student;
            Subject = subject;
            Mark = mark;
        }

        public override string ToString()
        {
            return $"Студент - {Student}\r\nПредмет - {Subject}\r\nОценка: {Mark}\r\n";
        }
    }
}
