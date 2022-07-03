namespace Business
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MensDate")]
    public partial class MensDate
    {
        public int Id { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Remarks { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public string DoctorRemarks { get; set; }

        public DateTime? CrDate { get; set; }
    }
}
