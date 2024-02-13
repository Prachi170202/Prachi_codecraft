    using Abp.Application.Services.Dto;
    using Abp.Domain.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TestDemo.DepartmentApplication.Dto;
    using TestDemo.Department;
    using Abp.AutoMapper;

    namespace TestDemo.DepartmentApplication
    {
        public class DepartmentAppService : TestDemoApplicationModule , IDepartmentAppService
        {
            private readonly IRepository<ITdepartment> _departmentRepository;
            public DepartmentAppService(IRepository<ITdepartment> departmentRepository)
            {
                _departmentRepository = departmentRepository;
            }

            public List<DepartmentDto> GetAllEmploye()
            {
                var department = (from d in _departmentRepository.GetAll()
                                  select new DepartmentDto
                                  {
                                      Id = d.Id,
                                      DepartmentName = d.DepartmentName,
                                      EmployeeCount = d.EmployeeCount,
                                      IsActive = d.IsActive,
                                      // Add other properties as needed
                                  }).ToList();

                return department;
            }

            public GetDepartmentDto GetDepartmentById(EntityDto input)
            {
                var edit = _departmentRepository.GetAll();
                var department = (from u in _departmentRepository.GetAll()
                                  where u.Id == input.Id
                                  select new GetDepartmentDto
                                  {
                                      Id = u.Id,
                                      DepartmentName = u.DepartmentName,
                                      EmployeeCount = u.EmployeeCount,
                                      IsActive = u.IsActive,
                                  }).FirstOrDefault();
                //return edit;   
                return department;
            }

            public async Task CreateDepartment(DepartmentDto input)
            {
                var department = input.MapTo<ITdepartment>();
                await _departmentRepository.InsertAsync(department);
            }

            public async Task UpdateDepartment(DepartmentDto input)
            {
                var department = await _departmentRepository.GetAsync(input.Id);
                department.DepartmentName = input.DepartmentName;
                department.EmployeeCount = input.EmployeeCount;
                department.IsActive = input.IsActive;
                await _departmentRepository.UpdateAsync(department);
            }

            public async Task Delete(EntityDto input)
            {
                await _departmentRepository.DeleteAsync(input.Id);
            }

           public async Task ToggleDepartmentActive(EntityDto input)
       {
              var department = await _departmentRepository.GetAsync(input.Id);
              if (department != null)
              {
                department.IsActive = !department.IsActive; // Toggle the IsActive status
                await _departmentRepository.UpdateAsync(department);
              }
        }
      
        }
    }
