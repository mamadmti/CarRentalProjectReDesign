using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using MyProject.Domain.Entities;

namespace CarRentalWebApiReDesign.Domain.Context
{
    public class User: BaseEntity
    {

        [Required]
        public string UserName { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool IsAdmin { get; set; }

        public ICollection<Rent> Rents { get; set; }

    }
}
