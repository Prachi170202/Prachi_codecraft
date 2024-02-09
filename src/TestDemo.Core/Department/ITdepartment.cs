using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo.Department
{
    public class ITdepartment: FullAuditedEntity
    {
        public virtual string DepartmentName { get; set; }
        public virtual int EmployeeCount { get; set; }
        public bool IsActive { get; set; }
    }
}
