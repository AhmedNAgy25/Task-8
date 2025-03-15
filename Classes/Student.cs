namespace Task8.Classes

{
    public class Student
    {
        public int Id { get; }
        public string Name { get; }
        public string Grade { get; }

        public Student(int id, string name, string grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }

        public Student(Student original)
        {
            Id = original.Id;
            Name = original.Name;
            Grade = original.Grade;
        }

    }
}