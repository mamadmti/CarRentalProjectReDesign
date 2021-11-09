using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MyProject.Domain.Entities;

namespace CarRentalWebApiReDesign.Domain.Context
{
    public class Rent: BaseEntity
    {


        // ارتباط با جدول یوزرز
        public virtual User Users { get; set; }
        [Required]
        public long UsersId { get; set; }

        //ارتباط با جدول ماشین ها
        public virtual Car Cars { get; set; }
        [Required]
        public long CarsId { get; set; }


    }
}
