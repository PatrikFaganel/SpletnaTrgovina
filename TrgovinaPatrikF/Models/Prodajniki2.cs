

namespace TrgovinaPatrikF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class Prodajniki2
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Ime { get; set; }

        [StringLength(50)]
        public string Priimek { get; set; }
    }

}