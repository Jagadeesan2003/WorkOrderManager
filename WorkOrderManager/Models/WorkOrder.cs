using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorkOrderManager.Models
{
    public class WorkOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string OrderNo { get; set; }

        [Required]
        [StringLength(300)]
        public string Reg { get; set; }

        [Required]
        [StringLength(300)]
        public string Model {get; set;}

        [Required]
        [StringLength(300)]
        public string SerialNo { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [StringLength(300)]
        public string OrderStatus { get; set; }

        [Required]
        public DateTime OpenDate { get; set; }

        public DateTime? ClosedDate { get; set; }

        public int UserID { get; set; }
        public Guid GUID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        
    }
}
