using System.ComponentModel.DataAnnotations;

namespace API__SQL_Angular_13_CRUD
{
    public class Status
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string StatusOption { get; set; } = string.Empty;
    }
}
