using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDemo.Department;

namespace TestDemo.DepartmentApplication.Dto
{
    [AutoMapTo(typeof(ITdepartment))]
    public class DepartmentDto : EntityDto
    {

        public string DepartmentName { get; set; }
        public int EmployeeCount { get; set; }
        public bool IsActive { get; set; }
    }
}
