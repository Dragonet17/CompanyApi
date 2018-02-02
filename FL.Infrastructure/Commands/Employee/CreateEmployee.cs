using System;

namespace FL.Infrastructure.Commands.Employee
{
   public class CreateEmployee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CompanyPosition { get; set; }
        public string Description { get; set; }
        public string ContractType { get; set; }
        public DateTime HiredAt { get; set; }
    }
}
