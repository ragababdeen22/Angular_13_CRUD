﻿using System.ComponentModel.DataAnnotations;

namespace API__SQL_Angular_13_CRUD
{
    public class InspectionType
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string InspectionName { get; set; } = string.Empty;
    }
}
