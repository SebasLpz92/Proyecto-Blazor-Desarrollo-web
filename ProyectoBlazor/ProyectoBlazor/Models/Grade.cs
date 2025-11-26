using System;

namespace ProyectoBlazor.Models
{
    public class Grade
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid CourseId { get; set; }
        public string Type { get; set; } = "Parcial";
        public decimal Value { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public string? Notes { get; set; }
    }
}
