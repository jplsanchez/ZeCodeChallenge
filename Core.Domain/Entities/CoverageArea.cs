using GeoJSON.Net.Geometry;

namespace ZeCode.Core.Domain.Entities
{
    public class CoverageArea
    {
        public string Type => "MultiPolygon";
        public MultiPolygon Coordinates { get; set; }
    }
}
