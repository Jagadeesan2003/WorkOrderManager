using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorkOrderManager.Models
{
    public class Tasks
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public int OrderID { get; set; }

        [Required]
        [StringLength(100)]
        public string TaskNo { get; set; }

        [Required]
        [StringLength(300)]
        public string OrderNo { get; set; }

        [Required]
        [StringLength(300)]
        public string Description { get; set; }

        [Required]
        [StringLength(200)]
        public string OrderTaskStatus { get; set; }

        public DateTime? CODate { get; set; }

        public string? COJourneyNo { get; set; }

        [Required]
        public int UserID { get; set; }

        [Required]
        public Guid GUID { get; set;  }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public DateTime UpdatedDate { get; set; }
    }
}
