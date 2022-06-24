using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZeCode.Core.Domain.Entities
{
    public class Partner
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string TradingName { get; set; }

        [Required]
        public string  OwnerName { get; set; }

        [Required, StringLength(maximumLength: 14, MinimumLength = 14, ErrorMessage = "must be 14 characters")]
        public string  Document { get; set; }

        [Required]
        public CoverageArea CoverageArea { get; set; }

        [Required]
        public Address  Address { get; set; }


        public Partner(Guid id, string tradingName, string ownerName, string document, CoverageArea coverageArea, Address address)
        {
            Id = id;
            TradingName = tradingName;
            OwnerName = ownerName;
            Document = document;
            CoverageArea = coverageArea;
            Address = address;
        }
    }
}
