using GeoJSON.Net.Geometry;

namespace ZeCode.Core.Domain.Entities
{
    public class Address
    {
        public string Type => "Point";
        public Point Coordinates { get; set; }
    }
}
