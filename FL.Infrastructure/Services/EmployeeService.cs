using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using FL.Infrastructure.Factories.Interfaces;
using FL.Infrastructure.Repositories.Interfaces;
using FL.Infrastructure.Services.Interfaces;

namespace FL.Infrastructure.Services
{
   public class EmployeeService : IEmployeeService
   {
       private readonly IEmpoyeeRepository _empoyeeRepository;
        private readonly IMapper _mapper;
        private readonly IEmployeeFactory _emailFactory;
        public EmployeeService(IEmpoyeeRepository empoyeeRepository,IMapper mapper, IEmployeeFactory employeeFactory)
        {
            _empoyeeRepository = empoyeeRepository;
            _mapper = mapper;
            _emailFactory = employeeFactory;
        }
        //_mapper.Map<IEnumerable<CompanyDto>>(company);
    }
}
