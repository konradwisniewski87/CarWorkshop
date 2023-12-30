using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Application.CarWorkshop
{
    public class CarWorkshopDTO
    {
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; } = default!;

        [Required(ErrorMessage = "Pease insert description")]//force an error message my content
        public string? Description { get; set; }
        public string? About { get; set; }

        [StringLength(15, MinimumLength = 6)]
        public string? PhoneNumber { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }

        public string? PostCode { get; set; }

        public string? EncodedName { get; set; }
    }
}
