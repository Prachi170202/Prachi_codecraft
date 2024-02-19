using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo.Product
{
    public class Productname : FullAuditedEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
