using ClassLibraryFacultatives;

namespace ClassLibraryFacultatives
{
    /// <summary>
    /// Номер
    /// </summary>
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
        /// Лабораторные
        /// </summary>
        public int LaboratoryWorks { get; set; } = 1;

        public bool IsValid
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Title)) return false;
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
                $"Название: {Title}\r\nЛекции: {Lectures}\r\nПрактики:{Practices}\r\nЛабораторные:{LaboratoryWorks}\r\n";
        }
    }
}
