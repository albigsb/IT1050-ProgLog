namespace Lab_3_IT1050
{
    class Student
    {
        private string Name;
        private int Grade;
        private Instructor Teacher;


        public Student(string name, Instructor teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.Grade = 0;
        }

        public void SetGrade(int grade)
        {
            this.Grade = grade;
        }

        public void Print()
        {
            System.Console.WriteLine("My name is" +" "+ this.Name + ", and I am a student. ");
            System.Console.WriteLine("My grade is " + this.Grade + ".");
            this.Teacher.Print1();
        }


    }
}
