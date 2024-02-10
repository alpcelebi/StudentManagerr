// Business/Abstract/IStudentService.cs
namespace StudentTracking.Business.Abstract
{
    public interface IStudentService
    {
        void AddStudent(Entities.Student student);
        System.Collections.Generic.List<Entities.Student> GetAllStudents();
        void ShowMenu(); // ShowMenu metodunu burada tanımlayın
    }
}
