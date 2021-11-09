using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MyProject.Domain.Entities;
using MyProject.Domain.Enums;

namespace CarRentalWebApiReDesign.Domain.Context
{
    public class Car: BaseEntity
    {

        [Required]
        public string PlateNum { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string EngineModel { get; set; }
        [Required]
        public DateTime ManufactorDate { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool AvailabilityForRent { get; set; }




        /// ارتباط با جدول برند
        public virtual Brand Brands { get; set; }
        [Required]
        public long BrandsId { get; set; }
        //ارتباط با جدول رنگ ها
        public virtual Color Colors { get; set; }
        [Required]
        public long ColorsId { get; set; }

        public GearboxType GearboxType { get; set; }

        public ICollection<Rent> Rents { get; set; }

    }
}
