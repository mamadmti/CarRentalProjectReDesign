using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Domain.ViewModel
{
    public class BrandDto
    {
        public long? Id { get; set; }
        public string BrandName { get; set; }
        public long UserId { get; set; }
    }
}
