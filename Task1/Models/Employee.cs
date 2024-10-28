namespace Task1.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalId { get; set; }
        public string Nationality { get; set; }
        public string MaritalStatus { get; set; }
        public string PersonalPhotoUrl { get; set; }
        public DateTime EntryDate { get; set; }
        public string Password { get; set; }


        public int DeptId { get; set; }
        public Department Department { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
