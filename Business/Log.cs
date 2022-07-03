namespace Business
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Log
    {
        public int Id { get; set; }

        public int? MensId { get; set; }

        public string MenstrualFlow { get; set; }

        public string Moods { get; set; }

        public string Symptoms { get; set; }

        public DateTime? CrDate { get; set; }
    }
}
