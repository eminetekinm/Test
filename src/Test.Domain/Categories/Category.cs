using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Test.Categories
{
    public class Category : FullAuditedAggregateRoot<int>
    {
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
