using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace SchoolAdmin.Data
{
    public class PhotoGalleryHeader
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter function name")]
        public string? FunctionName { get; set; }
        public string? FunctionDescription { get; set; }
        public int SubscriberId { get; set; }
        public bool IsStatus { get; set; } = true;
        public int CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

    }
}
