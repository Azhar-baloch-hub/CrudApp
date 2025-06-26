using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccounts.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [Required(ErrorMessage = "The Field is required")]
        [DisplayName("Account Number")]
        [MaxLength(12, ErrorMessage = "Length Must be Equel to 16")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Benificiary Name")]
        [Required(ErrorMessage = "The Field is required")]

        public string BenificiaryName { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "The Field is required")]

        public string BankName { get; set; }
        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("SWIFT Code")]
        [Required(ErrorMessage = "The Field is required")]
        [MaxLength(12, ErrorMessage = "Length Must be Equel to 12")]

        public string SWIFTCode { get; set; }
        [Required(ErrorMessage = "The Field is required")]
        public int Amount { get; set; }
        [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
        public DateTime Date { get; set; }
    }
}
