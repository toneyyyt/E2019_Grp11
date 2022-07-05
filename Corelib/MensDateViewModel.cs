using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corelib
{
  public class MensDateViewModel
    {
        public int Id { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Remarks { get; set; }

       
        public string Status { get; set; }

        public string DoctorRemarks { get; set; }

        public int UserId { get; set; }

        public DateTime? CrDate { get; set; }
    }
}
