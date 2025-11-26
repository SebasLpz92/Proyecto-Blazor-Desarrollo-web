using System;

namespace ProyectoBlazor.Models
{
    public class Course
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Code { get; set; } = "";
        public string Name { get; set; } = "";
    }
}
