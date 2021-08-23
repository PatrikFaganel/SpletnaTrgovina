

namespace TrgovinaPatrikF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Web;

    [Table("DOKUMENT")]

    public class Dokument
    {
        [Key]
        [Column(Order = 0)]
        public int DocumentID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string FileName { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte[] DocumentFile { get; set; }
    }
}