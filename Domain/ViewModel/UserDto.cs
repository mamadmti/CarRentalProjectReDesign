using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Domain.ViewModel
{
    public class UserDto
    {
        public long? Id { get; set; }
        public string NationalCode { get; set; }
        public string UserName { get; set; }
        
    }
}
