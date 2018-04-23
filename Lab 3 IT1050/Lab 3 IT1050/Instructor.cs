namespace Lab_3_IT1050
{
    class Instructor
    {
        private string Name;
        private string CourseName;


        public Instructor(string name, string courseName)
        {
            this.Name = name;
            this.CourseName = courseName;
        }

        public void SetStudentGrade(Student student, int grade)
        {
            student.SetGrade(grade);
        }

        public void Print()
        {
            System.Console.WriteLine("Hi, I'm Professor " + this.Name + ".");
            System.Console.WriteLine("The class I teach is " + this.CourseName + ".");
        }

        public void Print1()
        {
            System.Console.WriteLine("My Professor is" +" "+ this.Name + ".");
            System.Console.WriteLine("He's my " + this.CourseName + " teacher.");
        }



    }
}
