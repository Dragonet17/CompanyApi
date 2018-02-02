using System;
using System.Collections.Generic;
using System.Text;

namespace FL.Infrastructure.DTO.Employee
{
   public class EmployeeDTO
    {
        public string Name { get;  set; }
        public string Surname { get;  set; }
        public string CompanyPosition { get;  set; }
        public string Description { get;  set; }
        public string ContractType { get;  set; }
        public DateTime HiredAt { get;  set; }
    }
}
