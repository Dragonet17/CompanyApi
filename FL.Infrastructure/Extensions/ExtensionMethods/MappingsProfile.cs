using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using FL.Core.Domain;
using FL.Infrastructure.DTO.Employee;

namespace FL.Infrastructure.Extensions.ExtensionMethods
{
    class MappingsProfile:Profile
    {
        public MappingsProfile()
        {
            CreateMap<Employee, EmployeeDTO>()
                .ReverseMap();
            //CreateMap<Company, CompanyDto>()
            //    .ReverseMap();
        }
    }
}
