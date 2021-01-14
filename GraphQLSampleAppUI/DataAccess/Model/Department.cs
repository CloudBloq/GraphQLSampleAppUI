using System.Collections.Generic;


namespace GraphQLSampleAppUI.DataAccess.Model
{
    public class Department
    {       
        public int DepartmentId { get; set; }

        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public override string ToString()
        {
            return $"DepartmentId: {DepartmentId},\n" +
                $"Name: {Name}\n";
        }
    }
}
