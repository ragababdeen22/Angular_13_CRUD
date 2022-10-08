using System.ComponentModel.DataAnnotations;

namespace API__SQL_Angular_13_CRUD
{
    public class Inspection
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Status { get; set; } = string.Empty;

        [StringLength(200)]
        public string Comments { get; set; } = string.Empty;

        public int InspectionTypeId { get; set; }

        public InspectionType? InspectionType { get; set; }
    }
}
