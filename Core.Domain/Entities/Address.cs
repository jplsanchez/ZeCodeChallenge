using GeoJSON.Net.Geometry;
using System.ComponentModel.DataAnnotations;

namespace ZeCode.Core.Domain.Entities
{
    public class Address
    {
        public static string Type => "Point";

        [Required]
        public Point Coordinates { get; set; }

        public Address(Point coordinates)
        {
            Coordinates = coordinates;
        }
    }
}
