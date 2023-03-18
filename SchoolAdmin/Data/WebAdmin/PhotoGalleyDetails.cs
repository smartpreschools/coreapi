using System.ComponentModel.DataAnnotations;

namespace SchoolAdmin.Data
{
    public class PhotoGalleyDetails
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please select function")]
        public string? FunctionId { get; set; }
        [Required(ErrorMessage = "Please enter photo name")]
        public string? ImageName { get; set; }
        public int ImageOrder { get; set; }
        public string? ImageDescription { get; set; }
        public string? ImageUrl { get; set; }
        public int SubscriberId { get; set; }
        public bool Status { get; set; } = true;
        public int CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
