using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDemo.Company;
using TestDemo.Department;

namespace TestDemo.DepartmentApplication.Dto
{
    [AutoMapFrom(typeof(Departmentname))]
    public class BindDepartmentIdDto:EntityDto
    {
        public string DepartmentName { get; set; }
    }
}
