using System.ComponentModel.DataAnnotations;

namespace FaceProductAPI.Models.SearchApp
{
    public class AA_LoanHistory
    {
        [Key]
        [Required]
        public string ApplicationID { get; set; }
        public string? VirtualProfileId { get; set; }
        public string? ApplicationNumber { get; set; }
        public string? LoanType { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductNameTH { get; set; }
        public string? ProdcutNameEN { get; set; }

        public string? ApplicationStatus { get; set; }

        public DateTime? SubmittedDate { get; set; }

        public DateTime? ExpiredDate { get; set; }

        public DateTime? UploadDocumentDate { get; set; }

        public DateTime? ApprovedDate { get; set; }

        public DateTime? RejectedDate { get; set; }

        public DateTime? CancelledDate { get; set; }

    }
}
