namespace Drivers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Licences
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_license { get; set; }

        public int? id_driver { get; set; }

        [Column("expire date")]
        public double? expire_date { get; set; }

        [StringLength(255)]
        public string categories { get; set; }

        [Column("licence series")]
        [StringLength(255)]
        public string licence_series { get; set; }

        [Column("licence number")]
        public double? licence_number { get; set; }

        [StringLength(255)]
        public string Status { get; set; }

        [StringLength(255)]
        public string VIN { get; set; }

        [StringLength(255)]
        public string Manufacturer { get; set; }

        [StringLength(255)]
        public string Model { get; set; }

        public double? Year { get; set; }

        public double? Weight { get; set; }

        public double? Color { get; set; }

        [Column("Engine Type")]
        public double? Engine_Type { get; set; }

        [Column("type of drive")]
        [StringLength(255)]
        public string type_of_drive { get; set; }

        public virtual drivers drivers { get; set; }
    }
}
