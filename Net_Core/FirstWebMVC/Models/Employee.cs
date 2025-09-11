namespace FirstWebMVC.Models 
{
    // Lớp cha Person
    public class Person
    {
        public string PersonId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }  
    }

    // Lớp con Employee kế thừa Person
    public class Employee : Person
    {
        public string EmployeeId { get; set; }
        public int Age { get; set; }
    }
}
