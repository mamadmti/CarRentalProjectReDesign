using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MyProject.Domain.Entities;

namespace CarRentalWebApiReDesign.Domain.Context
{
    public class Brand: BaseEntity
    {

        [Required]
        public string BrandName { get; set; }

        public ICollection<Car> Cars { get; set; }

    }
}
