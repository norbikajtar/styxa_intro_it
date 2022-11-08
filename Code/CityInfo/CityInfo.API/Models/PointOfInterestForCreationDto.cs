using System.ComponentModel.DataAnnotations;

namespace CityInfo.API.Models
{
    public class PointOfInterestForCreationDto
    {
        [MaxLength(200)]
        public string Description { get; set; }

        [Required(ErrorMessage = "The Name field is required, please provide it!")]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
