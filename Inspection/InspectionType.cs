using System.ComponentModel.DataAnnotations;

namespace Inspection
{
    public class InspectionType
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string InspectionName { get; set; } = string.Empty;

        public string ArabicName { get; set; } = string.Empty;

    }
}
