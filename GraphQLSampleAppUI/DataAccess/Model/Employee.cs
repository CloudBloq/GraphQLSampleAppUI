
namespace GraphQLSampleAppUI.DataAccess.Model
{
    public class Employee
    {       
        public int EmployeeId { get; set; }
        
        public string Name { get; set; }
       
        public string Email { get; set; }
        
        public int Age { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        public override string ToString()
        {
            return $"EmployeeId: {EmployeeId},\n" +
                $"Name: {Name},\n" +
                $"Email: {Email},\n" +
                $"Age: {Age},\n" +
                $"DepartmentId: {DepartmentId},\n" +
                $"Department:[ {Department.ToString()}]\n";           
        }
    }
}
