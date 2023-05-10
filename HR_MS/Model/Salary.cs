﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace HR_MS.Model
{
    public class Salary
    {
        [Key]
        public int ID { get; set; }

        public string type { get; set; }
        public string amt { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }


    }

}
