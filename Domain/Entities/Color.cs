using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MyProject.Domain.Entities;

namespace CarRentalWebApiReDesign.Domain.Context
{
    public class Color: BaseEntity
    {

        [Required]
        public string ColorName { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
