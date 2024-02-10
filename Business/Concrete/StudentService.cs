// Business/Concrete/StudentService.cs
using System;

namespace StudentTracking.Business.Concrete
{
    public class StudentService : Abstract.IStudentService
    {
        private System.Collections.Generic.List<Entities.Student> _students = new System.Collections.Generic.List<Entities.Student>();

        public void AddStudent(Entities.Student student)
        {
            Console.Write("Öğrenci ID: ");
            string userInputId = Console.ReadLine();

            int studentId;
            while (!int.TryParse(userInputId, out studentId))
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                Console.Write("Öğrenci ID: ");
                userInputId = Console.ReadLine();
            }

            student.Id = studentId;

            Console.Write("Öğrenci Adı: ");
            student.Name = Console.ReadLine();

            Console.Write("Öğrenci Yaşı: ");
            string userInputAge = Console.ReadLine();

            int studentAge;
            while (!int.TryParse(userInputAge, out studentAge))
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                Console.Write("Öğrenci Yaşı: ");
                userInputAge = Console.ReadLine();
            }

            student.Age = studentAge;

            _students.Add(student);
            Console.WriteLine($"{student.Name} isimli öğrenci başarıyla eklendi.");
        }

        public System.Collections.Generic.List<Entities.Student> GetAllStudents()
        {
            return _students;
        }

        public void ShowMenu()
        {
            Console.WriteLine("1. Yeni Öğrenci Ekle");
            Console.WriteLine("2. Tüm Öğrencileri Göster");
            Console.WriteLine("3. Çıkış");
            Console.Write("Seçiminizi yapın (1, 2 veya 3): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Entities.Student newStudent = new Entities.Student();
                    AddStudent(newStudent);
                    ShowMenu();
                    break;
                case "2":
                    ShowAllStudents();
                    ShowMenu();
                    break;
                case "3":
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;
                default:
                    Console.WriteLine("Geçersiz seçenek. Lütfen 1, 2 veya 3 girin.");
                    ShowMenu();
                    break;
            }
        }

        private void ShowAllStudents()
        {
            Console.WriteLine("\nTüm Öğrenciler:");
            foreach (var student in _students)
            {
                Console.WriteLine($"ID: {student.Id}, Adı: {student.Name}, Yaşı: {student.Age}");
            }
        }
    }
}
