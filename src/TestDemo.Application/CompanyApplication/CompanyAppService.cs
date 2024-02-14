using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDemo.Company;
using TestDemo.CompanyApplication.Dto;
using TestDemo.Department;
using TestDemo.DepartmentApplication;
using TestDemo.DepartmentApplication.Dto;

namespace TestDemo.CompanyApplication
{
    public class CompanyAppService : TestDemoApplicationModule, ICompanyAppService
    {
        private readonly IRepository<Departmentname> _companyRepository;
        public CompanyAppService(IRepository<Departmentname> companyRepository)
        {
            _companyRepository = companyRepository;
        }



        public List<CompanyDto> GetAllEmploye()
        {
            var company = (from d in _companyRepository.GetAll()
                              select new CompanyDto
                              {
                                  Id = d.Id,
                                  DepartmentName = d.DepartmentName,
                               
                                  // Add other properties as needed
                              }).ToList();

            return company;
        }

        public GetCompanyDto GetDepartmentById(EntityDto input)
        {
            var edit = _companyRepository.GetAll();
            var company = (from u in _companyRepository.GetAll()
                              where u.Id == input.Id
                              select new GetCompanyDto
                              {
                                  Id = u.Id,
                                  DepartmentName = u.DepartmentName,
                              
                              }).FirstOrDefault();
            //return edit;   
            return company;
        }

        public async Task CreateDepartment(CompanyDto input)
        {
            var company = input.MapTo<Departmentname>();
            await _companyRepository.InsertAsync(company);
        }



        public List<BindDepartmentIdDto> BindDepartmentIds()
        {
            var company = (
                from d in _companyRepository.GetAll()
                select new BindDepartmentIdDto
                {
                    Id = d.Id,
                    DepartmentName = d.DepartmentName
                })
                .ToList();

            return company;
        }

    }
}

