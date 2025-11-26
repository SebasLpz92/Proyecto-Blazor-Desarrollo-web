using System;
using System.Collections.Generic;
using System.Linq;
using ProyectoBlazor.Models;

namespace ProyectoBlazor.Services
{
    public class StudentState
    {
        public string? StudentName { get; private set; }

        private readonly Dictionary<string, (List<Course> courses, Dictionary<Guid, List<Grade>> grades)> _store;

        public StudentState()
        {
            _store = new Dictionary<string, (List<Course>, Dictionary<Guid, List<Grade>>)>(StringComparer.OrdinalIgnoreCase);

            // seed demo
            var c1 = new Course { Code = "MAT101", Name = "Cálculo I" };
            var c2 = new Course { Code = "FIS102", Name = "Física I" };
            var c3 = new Course { Code = "PROG200", Name = "Programación" };

            var g1 = new Grade { CourseId = c1.Id, Type = "Parcial", Value = 82.5m, Date = DateTime.UtcNow.AddDays(-40) };
            var g2 = new Grade { CourseId = c1.Id, Type = "Final", Value = 78.0m, Date = DateTime.UtcNow.AddDays(-5) };
            var g3 = new Grade { CourseId = c2.Id, Type = "Parcial", Value = 91.0m, Date = DateTime.UtcNow.AddDays(-30) };
            var g4 = new Grade { CourseId = c3.Id, Type = "Proyecto", Value = 95.5m, Date = DateTime.UtcNow.AddDays(-7) };

            var courseList = new List<Course> { c1, c2, c3 };
            var gradesDic = new Dictionary<Guid, List<Grade>>{
                { c1.Id, new List<Grade>{ g1, g2 } },
                { c2.Id, new List<Grade>{ g3 } },
                { c3.Id, new List<Grade>{ g4 } }
            };
            _store["demo student"] = (courseList, gradesDic);
        }

        public void Login(string studentName)
        {
            StudentName = studentName?.Trim();
            if (StudentName is null) return;
            if (!_store.ContainsKey(StudentName))
            {
                _store[StudentName] = (new List<Course>(), new Dictionary<Guid, List<Grade>>());
            }
        }

        public void Logout()
        {
            StudentName = null;
        }

        public (List<Course> courses, Dictionary<Guid, List<Grade>> grades) GetDataForCurrent()
        {
            if (StudentName is null) return (new List<Course>(), new Dictionary<Guid, List<Grade>>());
            return _store[StudentName];
        }

        public void AddGrade(Guid courseId, Grade grade)
        {
            if (StudentName is null) return;
            var (_, grades) = _store[StudentName];
            if (!grades.ContainsKey(courseId)) grades[courseId] = new List<Grade>();
            grades[courseId].Add(grade);
        }
    }
}
