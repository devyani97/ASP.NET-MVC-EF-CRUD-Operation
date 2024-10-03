using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP.NET_MVC_EF_CRUD_Operation.Models
{
    public class Employee
    {
        [Key]
        [Required]
        [DisplayName("EMP ID")]
        public int ID { get; set; }

        [Required]
        [DisplayName("EMP NAME")]
        public string Name { get; set; }
        
        [Required]
        [DisplayName("EMP DEPARTMENT")]
        public string Department { get; set; }

        [Required]
        [DisplayName("EMP SALARY")]
        public int Salary { get; set; }
    }
}