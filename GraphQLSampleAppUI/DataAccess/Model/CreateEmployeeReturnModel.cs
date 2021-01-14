using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLSampleAppUI.DataAccess.Model
{
    public class CreateEmployeeReturnModel
    {
        public int DepartmentId { get; set; }

        public string Name { get; set; }

        public int EmployeeId { get; set; }
    }
}
