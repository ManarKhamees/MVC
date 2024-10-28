﻿namespace Task1.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Description { get; set; }
        public string ImportanceLevel { get; set; }


        public int EmployeeId { get; set; }
        public Employee AssignedEmployee { get; set; }

    }
}