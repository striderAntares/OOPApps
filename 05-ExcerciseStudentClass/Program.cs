using _05_ExcerciseStudentClass;

Student student1 = new Student()
{
    
    Name = Console.ReadLine(),
    Surname = Console.ReadLine(),
    Birthdate = Convert.ToDateTime(Console.ReadLine())

};

student1.PrintInfoStudent();