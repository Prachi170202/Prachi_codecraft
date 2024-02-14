using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDemo.CompanyApplication.Dto;
using TestDemo.DepartmentApplication.Dto;

namespace TestDemo.CompanyApplication
{
    public interface ICompanyAppService : IApplicationService
    {
        List<CompanyDto> GetAllEmploye();
        GetCompanyDto GetDepartmentById(EntityDto input);
        Task CreateDepartment(CompanyDto input);
        List<BindDepartmentIdDto> BindDepartmentIds();
    }
}
