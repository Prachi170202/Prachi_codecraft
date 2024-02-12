using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDemo.DepartmentApplication.Dto;

namespace TestDemo.DepartmentApplication
{
    public interface IDepartmentAppService : IApplicationService
    {
        List<DepartmentDto> GetAllEmploye();
        GetDepartmentDto GetDepartmentById(EntityDto input);
        Task CreateDepartment(DepartmentDto input);
        Task UpdateDepartment(DepartmentDto input);
        Task Delete(EntityDto input);
        Task ToggleDepartmentActive(EntityDto input);
    }
}
