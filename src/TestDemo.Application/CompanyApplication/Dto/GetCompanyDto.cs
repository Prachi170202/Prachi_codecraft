using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDemo.Company;
using TestDemo.Department;

namespace TestDemo.CompanyApplication.Dto
{
    [AutoMapTo(typeof(Departmentname))]
    public class GetCompanyDto:EntityDto
    {
        public string DepartmentName { get; set; }

    }
}
