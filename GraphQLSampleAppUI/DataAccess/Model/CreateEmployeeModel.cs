using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLSampleAppUI.DataAccess.Model
{
    public class CreateEmployeeModel
    {
        [Required]        
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string DepartmentName { get; set; }

        [Required]
        [Range(minimum: 20, maximum: 50)]
        public int Age { get; set; }



    }
}
