using GeoJSON.Net.Geometry;
using System.ComponentModel.DataAnnotations;

namespace ZeCode.Core.Domain.Entities
{
    public class CoverageArea
    {
        public static string Type => "MultiPolygon";

        [Required]
        public MultiPolygon Coordinates { get; set; }

        public CoverageArea(MultiPolygon coordinates)
        {
            Coordinates = coordinates;
        }
    }
}
