// StudentTracking.ConsoleApp/Program.cs
using System;
using StudentTracking.Business.Abstract; // Eklediğimiz namespace
using StudentTracking.Business.Concrete; // Eklediğimiz namespace

namespace StudentTracking.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudentService studentService = new StudentService();

            studentService.ShowMenu(); // ShowMenu metodunu çağırarak menüyü gösterir ve kullanıcıdan giriş bekler.
        }
    }
}
