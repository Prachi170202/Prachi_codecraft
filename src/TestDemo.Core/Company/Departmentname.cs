using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo.Company
{
    public class Departmentname : FullAuditedEntity
    {
        public virtual string DepartmentName { get; set; }
    }
}
